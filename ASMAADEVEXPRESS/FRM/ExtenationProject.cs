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
    public partial class ExtenationProject : MasterForm
    {
        DAl.extenation_table extenation;
        public int proj_id;
        public int sub_project;

        public ExtenationProject()
        {
            InitializeComponent();
            GetData();
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
        public override void GetData()
        {

            extenationtableBindingSource.DataSource = new DAl.extenation_table()
            {
                from_date = DateTime.Now,
                to_date = DateTime.Now,
                BookDate = DateTime.Now,
            };

            base.GetData();
        }

        public override void New()
        {
            GetData();
            base.New();

        }

        public ExtenationProject(int id,int exten_id)
        {

            InitializeComponent();
            proj_id = id;
            sub_project = exten_id;
            using (var db = new DAl.dbDataContext())

            {
                db.DeferredLoadingEnabled = false;
                extenation = db.extenation_tables.SingleOrDefault(x => x.project_id == id);
            }
            extenationtableBindingSource.DataSource = extenation;
            // extenation.id = sub_project;
            refr();

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        public override void Save()
        {

            from_dateDateEdit.Focus();
            DAl.extenation_table extenation_ = extenationtableBindingSource.Current as DAl.extenation_table;

            using (var db = new DAl.dbDataContext())
            {

                if (extenation_.id == 0)
                {
                    db.extenation_tables.InsertOnSubmit(extenation_);
                }
                else
                {
                    extenation_.project_id = proj_id;
                    db.DeferredLoadingEnabled = false;
                    db.extenation_tables.Attach(extenation_);
                    db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, extenation_);
                }


                db.SubmitChanges();
                MessageBox.Show("تم الحفظ");
                New();
            }
            base.Save();
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

           
        }

        public override void Delete()
        {
            var db = new DAl.dbDataContext();
            DAl.project_table project_Table = extenationtableBindingSource.Current as DAl.project_table;

            var table = db.project_tables.Where(s => s.project_id == project_Table.project_id).FirstOrDefault();

            if (XtraMessageBox.Show("هل تريد الحذف", "تأكيد الحذف", buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.project_tables.DeleteOnSubmit(table);
                db.SubmitChanges();
                XtraMessageBox.Show("تم الحذف");
                New();
            }

            base.Delete();

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ExtenationProject_Load(object sender, EventArgs e)
        {

        }
    }
}