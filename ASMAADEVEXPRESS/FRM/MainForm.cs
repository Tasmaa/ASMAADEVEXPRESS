using ASMAADEVEXPRESS.Properties;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ASMAADEVEXPRESS.FRM
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainForm()
        {
            InitializeComponent();
            accordionControl1.ElementClick += AccordionControl1_ElementClick;
            ribbonControl1.ItemClick += RibbonControl1_ItemClick;

        }

        private void RibbonControl1_ItemClick(object sender, ItemClickEventArgs e)
        {

            var tag = e.Item.Tag as string;
            if (tag != string.Empty)
            {
                OpenFormByName(tag);
            }
        }

        private void AccordionControl1_ElementClick(object sender, ElementClickEventArgs e)
        {
            var tag = e.Element.Tag as string;
            if (tag != string.Empty)
            {
                OpenFormByName(tag);
            }
        }
        public static void OpenFormByName(string name)
        {
            var ins = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == name);
            if (ins != null)
            {

                var frm = Activator.CreateInstance(ins) as Form;
                if (Application.OpenForms[frm.Name] != null)
                {
                    frm = (Form)Application.OpenForms[frm.Name];
                }
                else
                {
                    frm.Show();

                }
                frm.BringToFront();
            }
        }

       

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            FRM.EditConnectionString setting = new EditConnectionString();
            setting.Show();
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //UserLookAndFeel.Default.SkinName = Settings.Default["SkinName"].ToString();
            refresh();


            gridView1.OptionsBehavior.Editable = false;
          
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
                                               اسم_الشروع = proj.project_name,
                                               اسم_المقاول = contract.contract_name1,
                                               نوع_العمل = JobTitle.job_title,
                                           
                                               رقم_الاحالة = d.referralNo,
                                               تاريخ_الاحالة = d.referralDate,
                                               رقم_المقاولة = d.contractNo,
                                               تاريخ_المقاولة = d.ContractDate,
                                               مبلغ_المقاولة = d.ContractAmount,
                                               مدة_المقاولة = d.ContractDuration,
                                               تاريخ_الانجاز = d.CompletionDate,

                                               تاريخ_المباشرة = d.StartDate,
                                               مبلغ_الغرامة_اليومية = d.DailyFineAmount,
                                               مدة_التمديد = d.ExtensionTime,

                                               رقم = d.InsurancePolicyNumber,
                                               رسم = d.FinancialStampFee,
                                               رسم_طابع_نقابه_المهندسين = d.EngineersPensionFundFee,
                                               مدة_ = d.StatutoryInsurances,

                                               التاخيرات = db.delay_tables.Where(x => x.project_id == d.project_id).ToList(),
                                               التمديدات = db.extenation_tables.Where(x => x.project_id == d.project_id).ToList(),
                                               السلف = db.invoice_tables.Where(x => x.project_id == d.project_id).ToList()



                                           }
                 ).ToList();


            }
        }

        /*
         * 
         *   var db = new DAl.dbDataContext();
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
          
         * 
         */
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default["SkinName"] = UserLookAndFeel.Default.SkinName;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
