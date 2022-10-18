using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class InvoiceListProject : MasterForm
    {
        public int id;
        public int invoice_id;
        public InvoiceListProject()
        {
            InitializeComponent();
            refresh();

        }

        private void InvoiceListProject_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            // gridView1.Columns["Project_id"].Visible = false;
            // gridView1.Columns["Name"].Caption = "الاسم";
            gridView1.MasterRowExpanded += GridView1_MasterRowExpanded;
        }

        private void GridView1_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView master = sender as GridView;
            GridView detail = master.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;

            id = Convert.ToInt32(master.GetFocusedRowCellValue("proj_id"));
            GridView detail1 = master.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            detail1.DoubleClick += Detail1_DoubleClick;
        }

        private void Detail1_DoubleClick(object sender, EventArgs e)
        {
            GridView viee = sender as GridView;
            int id = 0;
            id = Convert.ToInt32(viee.GetFocusedRowCellValue("proj_id"));
            invoice_id = Convert.ToInt32(viee.GetFocusedRowCellValue("invoice_id"));

            var frm = new InvoiceProject(id, invoice_id);
            frm.Show();
            refresh();
        }

       
        public void refresh()
        {

            using (var db = new DAl.dbDataContext())
            {


                db.DeferredLoadingEnabled = false;
                gridControl1.DataSource = (from d in db.project_tables
                                           from proj in db.project_ts.Where(x => x.ProjectNameId == d.ProjectNameId)

                                           from JobTitle in db.jobTitles.Where(x => x.JobTitleId == d.JobTitleId)
                                           from contract in db.contract_names.Where(x => x.ContractNameId == d.ContractNameId)


                                           select new
                                           {
                                               proj_id = d.project_id,
                                               اسم_المشروع = proj.project_name,
                                               اسم_المقاول = contract.contract_name1,
                                               نوع_العمل = JobTitle.job_title,

                                              // التاخيرات = db.delay_tables.Where(x => x.project_id == d.project_id).ToList(),
                                              // التمديدات = db.extenation_tables.Where(x => x.project_id == d.project_id).ToList(),
                                               السلف = db.invoice_tables.Where(x => x.project_id == d.project_id).ToList()



                                           }
                 ).ToList();


            }

        }

        public override void New()
        {

            InvoiceProject frm = new InvoiceProject();
            frm.Show();
            base.New();
        }
    

        public override void Refresh()
        {
            refresh();

            base.Refresh();
        }
    
    }
}