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
    public partial class ExtenationSubProject : MasterForm
    {
        DAl.extenation_table2 extenation;
        private int project_id;
        public int ContractExtensionId;
        public int exteation_id;
        public ExtenationSubProject()
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
                project_idTextEdit.Properties.DisplayMember = "اسم_المشروع";
                project_idTextEdit.Properties.ValueMember = "الكود";
            }
         


            using (var db = new DAl.dbDataContext())
            {
                SubProject_id.Properties.DataSource = (from p1 in db.ContractExtensions.Where(x => x.ContractExtensionId == ContractExtensionId)
                                                            select new
                                                            {
                                                                الكود = p1.ContractExtensionId,
                                                                رقم_ملحق_العقد= p1.ContractExtenationNo
                                                            }).ToList();
                project_idTextEdit.Properties.DisplayMember = "اسم_ملحق_العقد";
                project_idTextEdit.Properties.ValueMember = "ContractExtensionId";
            }
           
        }
        public override void GetData()
        {
            extenationtable2BindingSource.DataSource = new DAl.extenation_table2()
            {
                from_date = DateTime.Now,
                to_date = DateTime.Now,
                BookDate = DateTime.Now,
            };
            base.GetData();
        }
  

        public ExtenationSubProject(int n,int m, int s)
        {

            InitializeComponent();
            project_id = n;
            ContractExtensionId = m;
            exteation_id = s;

            using (var db = new DAl.dbDataContext())

            {
                db.DeferredLoadingEnabled = false;
                extenation = db.extenation_table2s.SingleOrDefault(x => x.ContractExtensionId == m && x.id==s);
            }
            extenationtable2BindingSource.DataSource = extenation;
            refr();


        }

        public override void Save()
        {
           // ContractExtensionId = (int)SubProject_id.EditValue;

            from_dateDateEdit.Focus();
            DAl.extenation_table2 extenation_ = extenationtable2BindingSource.Current as DAl.extenation_table2;

            using (var db = new DAl.dbDataContext())
            {

                if (extenation_.id == 0)
                {
                    extenation_.ContractExtensionId = ContractExtensionId;

                    db.extenation_table2s.InsertOnSubmit(extenation_);
                }
                else
                {
                  //  extenation_.ContractExtensionId = proj_id;
                    db.DeferredLoadingEnabled = false;
                    db.extenation_table2s.Attach(extenation_);
                    db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, extenation_);
                }


                db.SubmitChanges();
                MessageBox.Show("تم الحفظ");
                New();
            }
            base.Save();
        }

        public override void Delete()
        {
            var db = new DAl.dbDataContext();
            DAl.ContractExtension Subproject_Table = extenationtable2BindingSource.Current as DAl.ContractExtension;

            var table = db.extenation_table2s.Where(s => s.ContractExtensionId == Subproject_Table.ContractExtensionId).FirstOrDefault();

            if (XtraMessageBox.Show("هل تريد الحذف", "تأكيد الحذف", buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.extenation_table2s.DeleteOnSubmit(table);
                db.SubmitChanges();
                XtraMessageBox.Show("تم الحذف");
                New();
            }
            base.Delete();
        }

        public override void New()
        {
            GetData();
            base.New();
        }

        

        private void ExtenationSubProject_Load(object sender, EventArgs e)
        {

        }
    }
}