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
    public partial class DelayProjects : MasterForm
    {


        DAl.delay_table delay;
        public int project_id;
        public int delay_id;


        public DelayProjects()
        {

            InitializeComponent();
            New();
            refr();
        }


        public void refr()
        {
            using (var db = new DAl.dbDataContext())
            {
                project_idTextEdit.Properties.DataSource = (from p in db.project_tables
                                                            from p1 in db.project_ts.Where(x => x.ProjectNameId == p.ProjectNameId )
                                                            select new
                                                            {
                                                                الكود = p.project_id,
                                                                اسم_المشروع = p1.project_name
                                                            }).ToList();
            }
            project_idTextEdit.Properties.DisplayMember = "اسم_المشروع";
            project_idTextEdit.Properties.ValueMember = "الكود";


        }
        public override void New ()
        {
            delaytableBindingSource.DataSource = new DAl.delay_table()
            {
                from_date= DateTime.Now,
                to_date=DateTime.Now,
                BookDate=DateTime.Now,
            };

           base.New();

        }
        public DelayProjects(int proj_id, int id)
        {

            InitializeComponent();
            project_id = proj_id;
            delay_id = id;
            using (var db = new DAl.dbDataContext())

            {
                db.DeferredLoadingEnabled = false;
                delay = db.delay_tables.SingleOrDefault(x => x.id == id &&  x.project_id == proj_id);
            }
            delaytableBindingSource.DataSource = delay;
            refr();


        }


        public override void Save()
        {
            from_dateDateEdit.Focus();
            DAl.delay_table delay_ = delaytableBindingSource.Current as DAl.delay_table;

            using (var db = new DAl.dbDataContext())
            {

                if (delay_.id == 0)
                {
                    db.delay_tables.InsertOnSubmit(delay_);
                }
                else
                {
                   // delay_.project_id = project_id;
                   // delay_.id = delay_id;
                    db.DeferredLoadingEnabled = false;
                    db.delay_tables.Attach(delay_);
                    db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, delay_);
                }


                db.SubmitChanges();
            }
            base.Save();
            New();

        }

        public override void Delete()
        {
            var db = new DAl.dbDataContext();
            DAl.project_table project_Table = delaytableBindingSource.Current as DAl.project_table;

            var table = db.project_tables.Where(s => s.project_id == project_Table.project_id).FirstOrDefault();

            if (XtraMessageBox.Show("هل تريد الحذف", "تأكيد الحذف", buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // db.project_tables.Attach(table);
                db.project_tables.DeleteOnSubmit(table);
                db.SubmitChanges();
                XtraMessageBox.Show("تم الحذف");
                New();
            }
            base.Delete();
        }

        private void DelayProjects_Load(object sender, EventArgs e)
        {

        }
    }
}