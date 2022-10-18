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
    public partial class MasterForm : DevExpress.XtraEditors.XtraForm
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        public virtual void Save()
        {
            XtraMessageBox.Show("تم الحفظ بنجاح");
        }
        public virtual void GetData()
        {

        }
        public virtual void SetData()
        {


        }
        public virtual void New()
        {
            GetData();
        }
        public virtual void Delete()
        {
            XtraMessageBox.Show("تم الحذف بنجاح");


        }


        private void MasterForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Save();
            }
            if (e.KeyCode == Keys.F1)
            {
                New();
            }
            if (e.KeyCode == Keys.Delete)
            {
                Delete();
            }

        }

        private void MasterForm_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
            RefreshData();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshData();
        }

        public virtual void RefreshData()
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Delete();
        }
    }
}