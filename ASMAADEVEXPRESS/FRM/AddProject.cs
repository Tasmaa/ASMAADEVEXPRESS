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
    public partial class AddProject : MasterForm
    {
        DAl.project_t project;

        public AddProject()
        {
            InitializeComponent();
            New();

        }


        public override void New()
        {
            project = new DAl.project_t();
            base.New();
        }
        public override void SetData()
        {
            project.project_name = textEdit1.Text;
            // category.ParentID = (ParentIDTextEdit.EditValue as int?) ?? 0;
            base.SetData();
        }
        public override void Save()
        {
            if (IsDataValid() == false)
                return;
            var db = new DAl.dbDataContext();
            if (project.ProjectNameId == 0)
            {
                db.project_ts.InsertOnSubmit(project);
            }
            else
            {
                db.project_ts.Attach(project);
            }
            SetData();
            db.SubmitChanges();
            base.Save();
        }
        private bool IsDataValid()
        {
            if (textEdit1.Text.Trim() == string.Empty)
            {
                textEdit1.ErrorText = "هذا الحقل مطلوب";
                return false;
            }
            var db = new DAl.dbDataContext();
            var oldObj = db.project_ts.Where(x => x.project_name.Trim() == textEdit1.Text.Trim());
            if (oldObj.Count() > 0)
            {
                textEdit1.ErrorText = "هذا الاسم مسجل مسبقا";
                return false;
            }
            return true;
        }

        public override void RefreshData()
        {

            var db = new DAl.dbDataContext();
            var groups = db.project_ts;
            treeList1.DataSource = groups;
            base.RefreshData();
        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            RefreshData();

        }
    }
}