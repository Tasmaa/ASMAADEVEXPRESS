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
    public partial class ProjectsList : DevExpress.XtraEditors.XtraForm
    {
        public ProjectsList()
        {
            InitializeComponent();
        }

        private void ProjectsList_Load(object sender, EventArgs e)
        {
            refresh();


            gridView1.OptionsBehavior.Editable = false;
            //gridView1.Columns["ID"].Visible = false;
            //gridView1.Columns["Name"].Caption = "الاسم";
            gridView1.DoubleClick += gridView1_DoubleClick;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("project_id"));
            Projects frm = new Projects(id);
            frm.Show();
        }
        void refresh()
        {
            var db = new DAl.dbDataContext();
            gridControl1.DataSource = db.project_tables;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            refresh();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Projects frm = new Projects();
            frm.Show();
        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            var db = new DAl.dbDataContext();
            var table= db.project_tables.Where(s => s.contractNo == textEdit1.Text).FirstOrDefault();
            gridControl1.DataSource = table;
          //  var table = db.project_tables.Where(s => s.project_id == project_Table.project_id).FirstOrDefault();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var db = new DAl.dbDataContext();        
            var table = db.project_tables.Where(s => s.contractNo == textEdit1.Text).FirstOrDefault();
            gridControl1.DataSource = table;
            //  var table = db.project_tables.Where(s => s.project_id == project_Table.project_id).FirstOrDefault();

        }
    }
}