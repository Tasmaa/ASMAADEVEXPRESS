using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMAADEVEXPRESS.FRM
{
    public partial class mainform2 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public mainform2()
        {
            InitializeComponent();

            try
            {
                FluentSplashScreenOptions fluent = new FluentSplashScreenOptions();
                fluent.Title = "نظام متابعة سلف المقاولين";
                fluent.Subtitle = " وزارة الاعمار والاسكان والاشغال العامة \n " +
                    "دائرة المباني/قسم تكنولوجيا المعلومات والاتصالات";

                fluent.RightFooter = "Starting";

                fluent.LeftFooter = $"Copyright © {DateTime.Now.Year} { Environment.NewLine } All Right Reserved ";
                fluent.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
                fluent.OpacityColor = System.Drawing.Color.FromArgb(16, 110, 190);

                fluent.Opacity = 90;
                fluent.AppearanceLeftFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                DevExpress.XtraSplashScreen.SplashScreenManager.ShowFluentSplashScreen(fluent, parentForm: this, useFadeIn: true, useFadeOut: true);






                using (var db = new DAl.dbDataContext())
                {

                    db.Connection.Open();
                    db.Connection.Close();
                    // InitializeComponent();
                    accordionControl1.ElementClick += AccordionControl1_ElementClick;
                    refresh();


                    gridView1.OptionsBehavior.Editable = false;


                }

            }
            catch (SqlException ex)
            {

                XtraMessageBox.Show(ex.Message, "Message Exception");

                var frm = new EditConnectionString();

                //frm.Show();
                Application.Run(frm);

                System.Environment.Exit(1);

            }
            finally
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false, 1200, this);
            }






        }

        private void AccordionControl1_ElementClick(object sender, ElementClickEventArgs e)
        {
            //6t
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
        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {

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

                                               التاخيرات = db.delay_tables.Where(x => x.project_id == d.project_id).ToList(),
                                               التمديدات = db.extenation_tables.Where(x => x.project_id == d.project_id).ToList(),
                                               السلف = db.invoice_tables.Where(x => x.project_id == d.project_id).ToList()



                                           }
                 ).ToList();


            }
        }

        //private void AccordionControl1_ElementClick(object sender, ElementClickEventArgs e)
        //{
        //    var tag = e.Element.Tag as string;
        //    if (tag != string.Empty)
        //    {
        //        OpenFormByName(tag);
        //    }
        //}
        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            FRM.EditConnectionString setting = new EditConnectionString();
            setting.Show();
        }

        private void mainform2_Load(object sender, EventArgs e)
        {

        }
    }
}