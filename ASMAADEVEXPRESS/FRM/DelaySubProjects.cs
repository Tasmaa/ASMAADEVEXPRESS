using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMAADEVEXPRESS.FRM
{
    public partial class DelaySubProjects : MasterForm
    {
        

        DAl.delay_table2 delay2;
        private int proj_id;
    

       public int project_id;
        public int subproject_id;
        public int delay_id;


        public DelaySubProjects()
        {
            InitializeComponent();
            New();
            refr();
          
        }


       

        public DelaySubProjects(int n, int m, int s)
        {

            InitializeComponent();
            project_id = n;
            subproject_id = m;
            delay_id = s;

            using (var db = new DAl.dbDataContext())

            {
                db.DeferredLoadingEnabled = false;
                delay2 = db.delay_table2s.FirstOrDefault(x => x.ContractExtensionId == m && x.id == s);
            }
            delaytable2BindingSource.DataSource = delay2;
            refr();


        }


        public void refr()

        {
            using (var db = new DAl.dbDataContext())
            {
                project_idTextEdit.Properties.DataSource = (from p in db.project_tables
                                                            from p1 in db.project_ts.Where(x => x.ProjectNameId == p.ProjectNameId)
                                                            select new
                                                            {
                                                                الكود = p.project_id,
                                                                اسم_المشروع = p1.project_name
                                                            }).ToList();
            }
            project_idTextEdit.Properties.DisplayMember = "اسم_المشروع";
            project_idTextEdit.Properties.ValueMember = "الكود";
           
        }

       
        public void New ()
        {
            delaytable2BindingSource.DataSource = new DAl.delay_table2()
            {
                from_date= DateTime.Now,
                to_date=DateTime.Now,
                BookDate=DateTime.Now,
            };
        }
       








        public override void Save()
        {

            from_dateDateEdit.Focus();
            DAl.delay_table2 delay_ = delaytable2BindingSource.Current as DAl.delay_table2;

            using (var db = new DAl.dbDataContext())
            {

                if (delay_.id == 0)
                {
                    delay_.ContractExtensionId = proj_id;

                    db.delay_table2s.InsertOnSubmit(delay_);
                }
                else
                {
                  //  delay_.ContractExtensionId = proj_id;
                    db.DeferredLoadingEnabled = false;
                    db.delay_table2s.Attach(delay_);
                    db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, delay_);
                }


                db.SubmitChanges();
                New();
            }
            base.Save();
        }

        public override void Delete()
        {
            var db = new DAl.dbDataContext();
            DAl.ContractExtension SupProj = delaytable2BindingSource.Current as DAl.ContractExtension;

            var table = db.delay_table2s.Where(s => s.ContractExtensionId == SupProj.ContractExtensionId).FirstOrDefault();

            if (XtraMessageBox.Show("هل تريد الحذف", "تأكيد الحذف", buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // db.project_tables.Attach(table);
                db.delay_table2s.DeleteOnSubmit(table);
                db.SubmitChanges();
                XtraMessageBox.Show("تم الحذف");
                New();
            }
            base.Delete();
        }



        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New();
        }

       
    }
}