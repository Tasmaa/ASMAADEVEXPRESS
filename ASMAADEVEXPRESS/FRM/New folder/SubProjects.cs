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
    public partial class SubProjects : DevExpress.XtraEditors.XtraForm
    {
        

        DAl.delay_table delay;
        private int proj_id;

        public SubProjects()
        {

            InitializeComponent();
            New();
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
            delaytableBindingSource.DataSource = new DAl.delay_table()
            {
                from_date= DateTime.Now,
                to_date=DateTime.Now,
                BookDate=DateTime.Now,
            };
        }
        public SubProjects(int id)
        {

            InitializeComponent();
            proj_id = id;
            using (var db = new DAl.dbDataContext())

            {
                db.DeferredLoadingEnabled = false;
                delay = db.delay_tables.SingleOrDefault(x => x.project_id == id);
            }
            delaytableBindingSource.DataSource = delay;

        
        }


       
       
  

 

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            from_dateDateEdit.Focus();
            DAl.delay_table delay_ = delaytableBindingSource.Current as DAl.delay_table;
            
            using (var db = new DAl.dbDataContext())
            {
                
                if (delay_.id == 0)
                {
                    db.delay_tables.InsertOnSubmit(delay_);
                }
                else
                {
                    delay_.project_id = proj_id;
                    db.DeferredLoadingEnabled = false;
                    db.delay_tables.Attach(delay_);
                    db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, delay_);
                }


                db.SubmitChanges();
                MessageBox.Show("تم الحفظ");
                New();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            var db = new DAl.dbDataContext();
            DAl.project_table project_Table = delaytableBindingSource.Current as DAl.project_table;

            var table = db.project_tables.Where(s => s.project_id == project_Table.project_id).FirstOrDefault();

            if (XtraMessageBox.Show("هل تريد الحذف", "تأكيد الحذف", buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // db.project_tables.Attach(table);
                db.project_tables.DeleteOnSubmit(table);
                db.SubmitChanges();
                XtraMessageBox.Show("تم الحذف");
                New();
            }
        }

        

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New();
        }

        private void SubProjects_Load(object sender, EventArgs e)
        {

        }
    }
}