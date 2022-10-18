using ASMAADEVEXPRESS.DAl;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMAADEVEXPRESS.FRM
{
    public partial class Projects : MasterForm
    {


       DAl.project_table proj;
       bool PhotoFlag;


        public Projects()
        {

            InitializeComponent();
            New();
            SetData();
            lkp_Joptitle1.QueryPopUp += JobTitleIdTextEdit_QueryPopUp;
            lkp_ProjectName.QueryPopUp += ProjectNameIdTextEdit_QueryPopUp;
            lkp_ContractName.QueryPopUp += ContractNameIdTextEdit_QueryPopUp;


        }

        private void ContractNameIdTextEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = sender as LookUpEdit;
            lookUpEdit.Properties.PopulateColumns();
        //    lookUpEdit.Properties.Columns["الكود"].Visible = false;
        }

        private void ProjectNameIdTextEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = sender as LookUpEdit;
            lookUpEdit.Properties.PopulateColumns();
          //  lookUpEdit.Properties.Columns["الكود"].Visible = false;
        }

        private void JobTitleIdTextEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = sender as LookUpEdit;
            lookUpEdit.Properties.PopulateColumns();
            //lookUpEdit.Properties.Columns["الكود"].Visible = false;
        }

        public Projects(int id)
        {

            InitializeComponent();

            using (var db = new DAl.dbDataContext())

            {
                db.DeferredLoadingEnabled = false;
                proj= db.project_tables.SingleOrDefault(x => x.project_id == id);
            }
            projecttableBindingSource.DataSource = proj;

            dbDataContext dc = new dbDataContext();
            var listprojNames=(from x in dc.project_ts select x).ToList();

            lkp_Joptitle1.QueryPopUp += JobTitleIdTextEdit_QueryPopUp;
            lkp_ProjectName.QueryPopUp += ProjectNameIdTextEdit_QueryPopUp;
            lkp_ContractName.QueryPopUp += ContractNameIdTextEdit_QueryPopUp;


            GetData();
        }
     
      
        public byte[] ImageToByteArray( System.Drawing.Image image)
        {
            using (var ms =new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
       
     


        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
      public override void GetData()
        {
            DAl.project_table project_Table = projecttableBindingSource.Current as DAl.project_table;
        }
    public  override  void SetData()
        {

            using (var db = new DAl.dbDataContext())
            {
                lkp_Joptitle1.Properties.DataSource = db.jobTitles.Select(x => new {

                    JobTitleId = x.JobTitleId,
                    job_title = x.job_title

                }).ToList();
                lkp_ContractName.Properties.DataSource = db.contract_names.Select(x => new {

                    ContractNameId = x.ContractNameId,
                    contract_name1 = x.contract_name1

                }).ToList();

                lkp_ProjectName.Properties.DataSource = (from p in db.project_ts
                                                         select new
                                                         {
                                                             ProjectNameId = p.ProjectNameId,
                                                             project_name = p.project_name
                                                         }).ToList();
            }
            //JobTitleIdTextEdit.Properties.ValueMember = "الكود";
            //JobTitleIdTextEdit.Properties.DisplayMember = "نوع_العمل";


            //ContractNameIdTextEdit.Properties.DisplayMember = "اسم_المقاول";
            //ContractNameIdTextEdit.Properties.ValueMember = "الكود";
            // ContractNameIdTextEdit.Properties.Columns["الكود"].Visible = false;





            //   ProjectNameIdTextEdit.Properties.ValueMember = "الكود";
            ////   ProjectNameIdTextEdit.Properties.Columns["الكود"].Visible = false;
            //   ProjectNameIdTextEdit.Properties.DisplayMember = "اسم_المشروع";
        }
        public   override  void New()
        {
            projecttableBindingSource.DataSource = new DAl.project_table();

            base.New();
        }

        public override void Save()
        {
            referralDateDateEdit.Focus();
            DAl.project_table project_Table = projecttableBindingSource.Current as DAl.project_table;

            using (var db = new DAl.dbDataContext())
            {
                //byte[] file_byte = ImageToByteArray(ImagePictureEdit.Image);
                //System.Data.Linq.Binary file_Binary = new System.Data.Linq.Binary(file_byte);
                //project_Table.Image = file_Binary;
                if (project_Table.project_id == 0)
                {
                    db.project_tables.InsertOnSubmit(project_Table);
                }
                else
                {
                    db.DeferredLoadingEnabled = false;
                    db.project_tables.Attach(project_Table);
                    db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, project_Table);
                }


                db.SubmitChanges();
            }

            base.Save();
        }

        public override void Delete()
        {
            int id = 0;
            var db = new DAl.dbDataContext();
            DAl.project_table project_Table = projecttableBindingSource.Current as DAl.project_table;

            var table = db.project_tables.Where(s => s.project_id == project_Table.project_id).FirstOrDefault();

            if (XtraMessageBox.Show("هل تريد الحذف", "تأكيد الحذف", buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // db.project_tables.Attach(table);
                db.project_tables.DeleteOnSubmit(table);
                db.SubmitChanges();
                New();
            }
            base.Delete();
        }
    
       
        void refresh()
        {
            var db = new DAl.dbDataContext();
            projecttableBindingSource.DataSource = db.project_tables;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            refresh();

        }

        private void Projects_Load(object sender, EventArgs e)
        {

            lkp_ContractName.Properties.DisplayMember = "contract_name1";
            lkp_ContractName.Properties.ValueMember = "ContractNameId";

            lkp_ProjectName.Properties.DisplayMember = "project_name";
            lkp_ProjectName.Properties.ValueMember = "ProjectNameId";

            lkp_Joptitle1.Properties.DisplayMember = "job_title";
            lkp_Joptitle1.Properties.ValueMember = "JobTitleId";




            lkp_ContractName.ProcessNewValue += ContractNameIdTextEdit_ProcessNewValue;

            lkp_ContractName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            lkp_ProjectName.ProcessNewValue += ProjectNameIdTextEdit_ProcessNewValue;  
            lkp_ProjectName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            lkp_Joptitle1.ProcessNewValue += JobTitleIdTextEdit_ProcessNewValue; ;

            lkp_Joptitle1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        private void ContractNameIdTextEdit_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            if (e.DisplayValue is string str && str.Trim() != string.Empty)
            {
                var NewObject = new DAl.contract_name() { contract_name1 = str };
                using (var db = new DAl.dbDataContext())
                {
                    db.contract_names.InsertOnSubmit(NewObject);
                    db.SubmitChanges();
                }
              // ((List<DAl.contract_name>)lkp_ContractName.Properties.DataSource).Add(NewObject);
                e.Handled = true;
            }
        }

        private void JobTitleIdTextEdit_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            if (e.DisplayValue is string str && str.Trim() != string.Empty)
            {
                var NewObject = new DAl.jobTitle() { job_title = str };
                using (var db = new DAl.dbDataContext())
                {
                    db.jobTitles.InsertOnSubmit(NewObject);
                    db.SubmitChanges();
                }
                //                      ((List<DAl.jobTitle>)lkp_Joptitle.Properties.DataSource).Add(NewObject);
                e.Handled = true;
            }
        }

       


        private void ProjectNameIdTextEdit_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            if (e.DisplayValue is string str && str.Trim() != string.Empty)
            {
                var NewObject = new DAl.project_t() { project_name = str };
                using (var db = new DAl.dbDataContext())
                {
                    db.project_ts.InsertOnSubmit(NewObject);
                    db.SubmitChanges();
                }

                         //  ((List<DAl.project_t>)lkp_ProjectName.Properties.DataSource).Add(NewObject);
                e.Handled = true;
            }
        }

     
    }
}