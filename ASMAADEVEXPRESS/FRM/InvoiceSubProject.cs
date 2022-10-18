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
    public partial class InvoiceSubProject : MasterForm
    {
        DAl.invoice_table2 invoice;
        private int proj_id;
        public int p;
        public int project_id;
        public int subproject_id;
        public int invoice_id;
        public InvoiceSubProject()
        {
            InitializeComponent();
            New();
            Refresh();
        }
        public InvoiceSubProject(int n, int m, int s)
        {

            InitializeComponent();
            project_id = n;
            subproject_id = m;
            invoice_id = s;

            using (var db = new DAl.dbDataContext())

            {
                db.DeferredLoadingEnabled = false;
                invoice = db.invoice_table2s.FirstOrDefault(x => x.ContractExtensionId == m && x.invoice_id == s);
            }
            invoicetable2BindingSource.DataSource = invoice;
            Refresh();


        }

        public override void Refresh()
        {
            using (var db = new DAl.dbDataContext())
            {
                project_idTextEdit.Properties.DataSource = (from p in db.project_tables
                                                            from p1 in db.project_ts.Where(x => x.ProjectNameId == p.ProjectNameId)
                                                            select new
                                                            {
                                                                الكود = p.project_id,
                                                               اسم_المشروع = p1.project_name
                                                            }).ToList();
            }
            project_idTextEdit.Properties.DisplayMember = "اسم_المشروع";
            project_idTextEdit.Properties.ValueMember = "الكود";

        }

        public override void New()
        {
            invoicetable2BindingSource.DataSource = new DAl.invoice_table()
            {
                check_date = DateTime.Now,

                document_date = DateTime.Now,
                invoice_date = DateTime.Now,
                Work_Performed = 0,
                invoice_offer = 0,
                decres_deffrent1 = 0,
                decres_deffrent2 = 0,
                decres_tax = 0,
                decres_secretariats = 0
            };
            base.New();
        }
        







      

        public override void Save()
        {
            p = (int)SubProId.EditValue;

            invoice_noTextEdit.Focus();
            DAl.invoice_table2 invoice_ = invoicetable2BindingSource.Current as DAl.invoice_table2;
            //int Work_Performed = 0;
            //int invoice_offer = 0;
            //int decres_tax = 0;
            //int decres_secretariats = 0;
            //int decres_deffrent1 = 0;
            //int decres_deffrent2 = 0;
            //int amount_received = 0;
            invoice_.Work_Performed = Convert.ToInt32(Work_PerformedTextEdit.Text);
            invoice_.invoice_offer = Convert.ToInt32(invoice_offerTextEdit.Text);
            invoice_.decres_tax = Convert.ToInt32(decres_taxTextEdit.Text);
            invoice_.decres_secretariats = Convert.ToInt32(decres_secretariatsTextEdit.Text);
            invoice_.decres_deffrent1 = Convert.ToInt32(decres_deffrent1TextEdit.Text);

            invoice_.decres_deffrent2 = Convert.ToInt32(decres_deffrent2TextEdit.Text);

            invoice_.amount_received = invoice_.Work_Performed - invoice_.invoice_offer - invoice_.decres_tax - invoice_.decres_secretariats - invoice_.decres_deffrent1 - invoice_.decres_deffrent2;


            using (var db = new DAl.dbDataContext())
            {

                if (invoice_.invoice_id == 0)
                {
                    invoice_.ContractExtensionId = p;

                    db.invoice_table2s.InsertOnSubmit(invoice_);
                }
                else
                {
                    //invoice_.ContractExtensionId = proj_id;///????
                    //db.DeferredLoadingEnabled = false;
                    //db.invoice_table2s.Attach(invoice_);
                    //db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, invoice_);
                }


                db.SubmitChanges();
                New();
            }
            base.Save();
        }



     


        public void getSubProId(int a)
        {

            using (var db = new DAl.dbDataContext())
            {
                SubProId.Properties.DataSource =
                                                       (from p1 in db.ContractExtensions.Where(x => x.project_id == a)
                                                        select new
                                                        {
                                                            الكود = p1.ContractExtensionId,
                                                            رقم_العقد = p1.ContractExtenationNo
                                                        }).ToList();
            }
            SubProId.Properties.DisplayMember = "اسم_العقد";
            SubProId.Properties.ValueMember = "الكود";
        }

        private void project_idTextEdit_EditValueChanged(object sender, EventArgs e)
        {


            int a;
            a = (int)project_idTextEdit.EditValue;
            getSubProId(a);
        }
    }
}