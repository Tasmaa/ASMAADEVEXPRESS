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
    public partial class AddJobTitle : MasterForm
    {
        DAl.jobTitle jobtitle;

        public AddJobTitle()
        {
            InitializeComponent();
            New();

        }

        public override void New()
        {
            jobtitle = new DAl.jobTitle();
            base.New();
        }
        public override void SetData()
        {
            jobtitle.job_title = textEdit1.Text;
            // category.ParentID = (ParentIDTextEdit.EditValue as int?) ?? 0;
            base.SetData();
        }
        public override void Save()
        {
            if (IsDataValid() == false)
                return;
            var db = new DAl.dbDataContext();
            if (jobtitle.JobTitleId == 0)
            {
                db.jobTitles.InsertOnSubmit(jobtitle);
            }
            else
            {
                db.jobTitles.Attach(jobtitle);
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
            var oldObj = db.jobTitles.Where(x => x.job_title.Trim() == textEdit1.Text.Trim());
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
            var groups = db.jobTitles;
            treeList1.DataSource = groups;
            base.RefreshData();
        }


        private void AddJobTitle_Load(object sender, EventArgs e)
        {
            RefreshData();

        }
    }
}