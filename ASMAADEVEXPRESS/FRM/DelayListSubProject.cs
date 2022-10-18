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
    public partial class DelayListSubProject : MasterForm
    {
        int n;
        public DelayListSubProject()
        {
            InitializeComponent();

            refresh();
            gridView1.MasterRowExpanded += GridView1_MasterRowExpanded;

        }

        private void GridView1_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView master = sender as GridView;
            GridView detail = master.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            detail.MasterRowExpanded += Detail_MasterRowExpanded;
        }

        private void Detail_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView master2 = sender as GridView;
            n = Convert.ToInt32(master2.GetFocusedRowCellValue("ContractExtensionId"));
            GridView detail2 = master2.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            detail2.DoubleClick += Detail2_DoubleClick;
        }

        private void Detail2_DoubleClick(object sender, EventArgs e)
        {
            GridView viee = sender as GridView;

            int m;
            int s;

            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridHitInfo info = viee.CalcHitInfo(ea.Location);

            if (info.InRow || info.InRowCell)
            {
                m = Convert.ToInt32(gridView1.GetFocusedRowCellValue("proj_id"));

                s = Convert.ToInt32(viee.GetFocusedRowCellValue("delay_id"));

                var frm = new DelaySubProjects(m, n, s);
                frm.ShowDialog();
                refresh();
            }
        }

      
        public override void New()
        {
            DelaySubProjects frm = new DelaySubProjects();
            frm.Show();
            base.New();
        }


        private void DelayListSubProject_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
           // gridView1.MasterRowExpanded += GridView1_MasterRowExpanded;
            gridView1.GroupPanelText = "اسحب الجدول هنا لترتيب النتائج على اساس هذا الجدول";



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

                                               // التاخيرات = 
                                               ملحق_عقد = db.ContractExtensions.Where(x => x.project_id == d.project_id).Select(x => new
                                               {

                                                   project_id = x.project_id,
                                                   ContractExtensionId = x.ContractExtensionId,

                                                   تأخيرات = db.delay_table2s.Where(d => d.ContractExtensionId == x.ContractExtensionId).Select(d => new
                                                   {
                                                       delay_id = d.id,
                                                       من = d.from_date,
                                                       الى = d.to_date,
                                                       رقم_الكتاب = d.BookNo,
                                                       تاريخ_الكتاب = d.BookDate
                                                   }
                                                   )

                                                   .ToList(),


                                               }





                                                   ).ToList()



                                           }
                 ).ToList();


            }

        }

        public override void Refresh()
        {
            refresh();

            base.Refresh();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}