using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class SubProjectList : DevExpress.XtraEditors.XtraForm
    {
        public SubProjectList()
        {
            InitializeComponent();
        }

        private void SubProjectList_Load(object sender, EventArgs e)
        {
            refresh();


            gridView1.OptionsBehavior.Editable = false;
            //gridView1.Columns["ID"].Visible = false;
            //gridView1.Columns["Name"].Caption = "الاسم";
            // gridView1.DoubleClick += gridView1_DoubleClick;
            gridView1.MasterRowExpanded += GridView1_MasterRowExpanded;

        }

        private void GridView1_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView master = sender as GridView;
            GridView detail = master.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            detail.Click += Detail_Click;
        }

        private void Detail_Click(object sender, EventArgs e)
        {
            int m;
            int n;
            GridView viee = sender as GridView;


            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridHitInfo info = viee.CalcHitInfo(ea.Location);

            if (info.InRow || info.InRowCell)
            {
                m = Convert.ToInt32(viee.GetFocusedRowCellValue("proj_id"));
                n = Convert.ToInt32(viee.GetFocusedRowCellValue("subproject_id"));

                var frm = new SubProjects(m, n);
                frm.ShowDialog();
                refresh();
            }
        }






        void refresh()
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

                                              ملحق_عقد = db.ContractExtensions.Where(m => m.project_id == d.project_id).Select(n => new
                                               {
                                                   subproject_id = n.ContractExtensionId,
                                                   اسم_المشروع = n.project_id,
                                                  
                                               }
                                               ).ToList()



                                           }
                                           ).ToList();



            }

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
    }
}