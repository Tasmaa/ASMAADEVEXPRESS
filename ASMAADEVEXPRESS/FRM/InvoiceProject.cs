using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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
    public partial class InvoiceProject : MasterForm
    {
        DAl.invoice_table invoice;
        private int proj_id;
        public InvoiceProject()
        {
            InitializeComponent();
            New();
            Refresh();
        }
        public InvoiceProject(int id,int invoice_id)
        {

            InitializeComponent();
            proj_id = id;
            using (var db = new DAl.dbDataContext())

            {
                db.DeferredLoadingEnabled = false;
                invoice = db.invoice_tables.SingleOrDefault(x => x.project_id == id);
            }
            invoicetableBindingSource.DataSource = invoice;

            Refresh();
        }

        public void Refresh()
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
        public void New()
        {
            invoicetableBindingSource.DataSource = new DAl.invoice_table()
            {
                check_date = DateTime.Now,
               
                document_date = DateTime.Now,
                invoice_date = DateTime.Now,
            };
        }
        







        private void InvoiceProject_Load(object sender, EventArgs e)
        {


        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            invoice_noTextEdit.Focus();
            DAl.invoice_table invoice_ = invoicetableBindingSource.Current as DAl.invoice_table;
            int Work_Performed = 0;
            int invoice_offer=0;
            int decres_tax=0;
            int decres_secretariats = 0;
            int decres_deffrent1 = 0;
            int decres_deffrent2 = 0;
            int amount_received = 0;
            Work_Performed = Convert.ToInt32(Work_PerformedTextEdit.Text);
            invoice_offer = Convert.ToInt32(invoice_offerTextEdit.Text);
            decres_tax= Convert.ToInt32(decres_taxTextEdit.Text);
            decres_secretariats = Convert.ToInt32(decres_secretariatsTextEdit.Text);
            decres_deffrent1 = Convert.ToInt32(decres_deffrent1TextEdit.Text);

            decres_deffrent2 = Convert.ToInt32(decres_deffrent2TextEdit.Text);

            invoice_.amount_received = Work_Performed - invoice_offer - decres_tax - decres_secretariats - decres_deffrent1 - decres_deffrent2;


            using (var db = new DAl.dbDataContext())
            {

                if (invoice_.invoice_id == 0)
                {
                    db.invoice_tables.InsertOnSubmit(invoice_);
                }
                else
                {
                    invoice_.project_id = proj_id;
                    db.DeferredLoadingEnabled = false;
                    db.invoice_tables.Attach(invoice_);
                    db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, invoice_);
                }


                db.SubmitChanges();
                MessageBox.Show("تم الحفظ");
                New();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New();

        }
    }
}