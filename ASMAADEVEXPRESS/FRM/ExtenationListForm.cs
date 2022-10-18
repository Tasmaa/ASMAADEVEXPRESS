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
    public partial class ExtenationListForm : MasterForm
    {
        public int exten_id;
        public int id;
        public ExtenationListForm()
        {
            InitializeComponent();
            refresh();
           
        }

        private void ExtenationListForm_Load(object sender, EventArgs e)
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
            exten_id = Convert.ToInt32(viee.GetFocusedRowCellValue("exten_id"));

            var frm = new ExtenationProject(id, exten_id);
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
                                               كود_الجدول = d.project_id,
                                               اسم_الشروع = proj.project_name,
                                               اسم_المقاول = contract.contract_name1,
                                               نوع_العمل = JobTitle.job_title,

                                               التمديدات = db.extenation_tables.Where(x => x.project_id == d.project_id).Select(d => new
                                               {
                                                   proj_id = d.project_id,

                                                   exten_id = d.id,
                                                   المدة = d.Duration,
                                                   من = d.from_date,
                                                   الى = d.to_date,
                                                   رقم_الكتاب = d.BookNo,
                                                   تاريخ_الكتاب = d.BookDate
                                               }
                )
                                               .ToList(),



                                           }
                 ).ToList();


            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExtenationProject frm = new ExtenationProject();
            frm.Show();
        }

        
    }
}