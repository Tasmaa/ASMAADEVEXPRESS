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
    public partial class SubProject : MasterForm
    {
        DAl.ContractExtension SubPro;
        private int proj_id;


        public SubProject()
        {
            InitializeComponent();
            RefreshData();

            New();

        }

        public SubProject(int id)
        {

            InitializeComponent();
            proj_id = id;
            using (var db = new DAl.dbDataContext())

            {
                db.DeferredLoadingEnabled = false;
                SubPro = db.ContractExtensions.SingleOrDefault(x => x.project_id == id);
            }
            contractExtensionBindingSource.DataSource = SubPro;


        }

        public override void New()
        {
            contractExtensionBindingSource.DataSource = new DAl.ContractExtension();
            base.New();


        }
        //public override void GetData()
        //{
        //    ContractExtenationNoTextEdit.Text = SubPro.ContractExtenationNo;
        //    project_idTextEdit.EditValue = SubPro.project_id;
        //    base.GetData();
        //}
        public override void SetData()
        {
            SubPro.ContractExtenationNo = ContractExtenationNoTextEdit.Text;
            //   SubPro.project_id = (project_idTextEdit.EditValue as int?) ?? 0;
             SubPro.project_id = Convert.ToInt32(project_idTextEdit.EditValue);
               // subproject.project_id = 0;
               base.SetData();
        }
        public override void Save()
        {
            ContractExtenationNoTextEdit.Focus();

            //if (IsDataValid() == false)
            //    return;
            SetData();

            var db = new DAl.dbDataContext();
            if (SubPro.ContractExtensionId == 0)
            {
                db.ContractExtensions.InsertOnSubmit(SubPro);
            }
            else
            {
                SubPro.project_id = proj_id;
                db.DeferredLoadingEnabled = false;

                db.ContractExtensions.Attach(SubPro);
                db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, SubPro);

            }
            db.SubmitChanges();
            base.Save();

              }

        private bool IsDataValid()
        {
            if (ContractExtenationNoTextEdit.Text.Trim() == string.Empty)
            {
                ContractExtenationNoTextEdit.ErrorText = "هذا الحقل مطلوب";
                return false;
            }
            var db = new DAl.dbDataContext();
            var oldObj = db.ContractExtensions.Where(x => x.ContractExtenationNo.Trim() == ContractExtenationNoTextEdit.Text.Trim() && x.ContractExtensionId != SubPro.ContractExtensionId);
            if (oldObj.Count() > 0)
            {
                ContractExtenationNoTextEdit.ErrorText = "هذا الاسم مسجل مسبقا";
                return false;
            }
            return true;
        }
        private void SubProject_Load(object sender, EventArgs e)
        {
            RefreshData();


            project_idTextEdit.Properties.DisplayMember = "NAME";
            project_idTextEdit.Properties.ValueMember = "ID";
        }

        public override void RefreshData()
           {

            using (var db1 = new DAl.dbDataContext())
            {

                project_idTextEdit.Properties.DataSource = (from p in db1.project_tables
                                                            from p1 in db1.project_ts.Where(x => x.ProjectNameId == p.ProjectNameId)
                                                            select new
                                                            {
                                                                الكود = p.project_id,
                                                                اسم_المشروع = p1.project_name
                                                            }).ToList();

            }
            project_idTextEdit.Properties.DisplayMember = "اسم_المشروع";
            project_idTextEdit.Properties.ValueMember = "الكود";


            var db = new DAl.dbDataContext();
            var groups = db.ContractExtensions;
            treeList1.DataSource = groups;
            treeList1.ParentFieldName = "ParentID";
            treeList1.KeyFieldName = "ID";

            base.RefreshData();

        }
    }
}