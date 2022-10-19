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
            gridView1.Columns["project_id"].Visible = false;
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
            gridControl1.DataSource = (from pro in db.project_tables
                                       from proT in db.project_ts.Where(x => x.ProjectNameId == pro.ProjectNameId)
                                       from conT in db.contract_names.Where(x => x.ContractNameId == pro.ContractNameId)
                                       from jopT in db.jobTitles.Where(x => x.JobTitleId == pro.JobTitleId)

                                       select new
                                       {
                                           اسم_المشروع = proT.project_name,
                                           اسم_المقاول = conT.contract_name1,
                                           نوع_العمل = jopT.job_title,
                                           project_id=pro.project_id,
                                           رقم_الاحالة=pro.referralNo,
                                           تاريخ_الاحالة = pro.referralDate,
                                           رقم_المقاولة = pro.contractNo,
                                           تاريخ_المقاولة = pro.ContractDate,
                                           مبلغ_المقاولة = pro.ContractAmount,
                                           مدة_المقاولة = pro.ContractDuration,
                                           تاريخ_الانجاز = pro.CompletionDate,

                                           تاريخ_المباشرة= pro.StartDate,
                                           مبلغ_الغرامة_اليومية = pro.DailyFineAmount,
                                           مدة_التمديد = pro.ExtensionTime,

                                           رقم = pro.InsurancePolicyNumber,
                                           رسم = pro.FinancialStampFee,
                                           رسم_طابع_نقابه_المهندسين = pro.EngineersPensionFundFee,
                                           مدة_ = pro.StatutoryInsurances




  


                                       }).ToList();

           ;
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
          //  var db = new DAl.dbDataContext();
          //  var table= db.project_tables.Where(s => s.contractNo == textEdit1.Text).FirstOrDefault();
          //  gridControl1.DataSource = table;
          ////  var table = db.project_tables.Where(s => s.project_id == project_Table.project_id).FirstOrDefault();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //var db = new DAl.dbDataContext();        
            //var table = db.project_tables.Where(s => s.contractNo == textEdit1.Text).FirstOrDefault();
            //gridControl1.DataSource = table;
            ////  var table = db.project_tables.Where(s => s.project_id == project_Table.project_id).FirstOrDefault();

        }
    }
}