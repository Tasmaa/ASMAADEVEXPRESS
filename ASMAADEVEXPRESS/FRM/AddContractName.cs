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
    public partial class AddContractName : MasterForm
    {

        DAl.contract_name contract;

        public AddContractName()
        {
            InitializeComponent();
            New();

        }

        public override void New()
        {
            contract = new DAl.contract_name();
            base.New();
        }
        public override void SetData()
        {
            contract.contract_name1 = textEdit1.Text;
           // category.ParentID = (ParentIDTextEdit.EditValue as int?) ?? 0;
            base.SetData();
        }
        public override void Save()
        {
            if (IsDataValid() == false)
                return;
            var db = new DAl.dbDataContext();
            if (contract.ContractNameId == 0)
            {
                db.contract_names.InsertOnSubmit(contract);
            }
            else
            {
                db.contract_names.Attach(contract);
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
            var oldObj = db.contract_names.Where(x => x.contract_name1.Trim() == textEdit1.Text.Trim());
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
            var groups = db.contract_names;
            treeList1.DataSource = groups;
            base.RefreshData();
        }

        private void AddContractName_Load(object sender, EventArgs e)
        {
            RefreshData();

        }
    }
}