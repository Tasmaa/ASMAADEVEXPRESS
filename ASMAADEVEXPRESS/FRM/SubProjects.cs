using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMAADEVEXPRESS.FRM
{
    public partial class SubProjects : MasterForm
    {


        DAl.ContractExtension SubProject;
        private int proj_id;

        public SubProjects()
        {

            InitializeComponent();
            New();
            Refresh();
        }

        public override void Refresh()
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
        public  void New ()
        {


            contractExtensionBindingSource.DataSource = new DAl.ContractExtension();
            base.New();

        }
        public SubProjects(int id,int subpro_id)
        {

            InitializeComponent();
            proj_id = id;
            using (var db = new DAl.dbDataContext())

            {
                db.DeferredLoadingEnabled = false;
                SubProject = db.ContractExtensions.SingleOrDefault(x => x.project_id == id);
            }
            contractExtensionBindingSource.DataSource = SubProject;

        
        }






        public override void Save()
        {

            project_idTextEdit.Focus();
            DAl.ContractExtension subproject_ = contractExtensionBindingSource.Current as DAl.ContractExtension;
            subproject_.project_id =(int) project_idTextEdit.EditValue;
          //  subproject_.Image = GetByteFromImage(ImagePictureEdit.Image);


            using (var db = new DAl.dbDataContext())
            {

                if (subproject_.ContractExtensionId == 0)
                {
                    db.ContractExtensions.InsertOnSubmit(subproject_);
                }
                else
                {
                    subproject_.project_id = proj_id;
                    db.DeferredLoadingEnabled = false;
                    db.ContractExtensions.Attach(subproject_);
                    db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, subproject_);
                }


                db.SubmitChanges();
                MessageBox.Show("تم الحفظ");
                New();
            }


            base.Save();

        }

     

        //private Binary GetByteFromImage(Image image)
        //{
        //    using (MemoryStream steam = new MemoryStream())
        //    {
        //        try
        //        {
        //            image.Save(steam, ImageFormat.Jpeg);
        //            return steam.ToArray();
        //        }
        //        catch
        //        {
        //            return steam.ToArray();

        //        }
        //    }

        //}
     

        public override void Delete()
        {
            var db = new DAl.dbDataContext();
            DAl.project_table project_Table = contractExtensionBindingSource.Current as DAl.project_table;

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

        private void SubProjects_Load(object sender, EventArgs e)
        {

        }
    }
}