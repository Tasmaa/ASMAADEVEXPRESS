using DevExpress.XtraEditors;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMAADEVEXPRESS.FRM
{
    public partial class EditConnectionString : DevExpress.XtraEditors.XtraForm
    {
       public  string con1;
        public SqlConnection BackCon;
        public SqlCommand cmd;
        SqlDataReader dr;

        List<String> databases = new List<String>();
        public EditConnectionString()
        {
            InitializeComponent();
            string con = Properties.Settings.Default.Contract_invoiceConnectionString.ToString();
            string con1 = "Data Source=" + editServerName.Properties.Items + ";Initial Catalog=" + EditDatabase.Properties.Items + ";Integrated Security=True";
            GetServersName();
            
            //GetDatabaseString();
        }

        public  void GetDataBaese()
        {
            databases.Clear();
            string NewDataSource =  editServerName.Text;
            using (var db = new DAl.dbDataContext())
            {
               

                SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();


                connection.DataSource = NewDataSource;
               

                // enter credentials if you want
                //connection.UserID = //get username;
                // connection.Password = //get password;
                connection.IntegratedSecurity = true;
                //MessageBox.Show(connection.ToString());
                string strConn = connection.ToString();

                //create connection
                SqlConnection sqlConn = new SqlConnection(strConn);


                //open connection
                sqlConn.Open();

                //get databases
                DataTable tblDatabases = sqlConn.GetSchema("Databases");
               // MessageBox.Show("Done");
                //close connection
                sqlConn.Close();

                //add to list
                foreach (DataRow row in tblDatabases.Rows)
                {
                    String strDatabaseName = row["database_name"].ToString();

                    databases.Add(strDatabaseName);
                    EditDatabase.Properties.Items.Add(strDatabaseName);

                }
               

            }
        }
        public void GetServersName()
        {
            string ServerName = Environment.MachineName;
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm =RegistryKey.OpenBaseKey(RegistryHive.LocalMachine,registryView))
            {
                RegistryKey instancKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instancKey != null)
                {
                    foreach (var InstanceName in instancKey.GetValueNames())
                    {
                        editServerName.Properties.Items.Add(ServerName + "\\" + InstanceName);
                    }
                }
            }
        }

        private void GetData()
        {
            try
            {
                edy_comanynmae.Text = Properties.Settings.Default.CompanyName;
                edt_comanydes.Text = Properties.Settings.Default.CompanyDes;

                var ByteImage = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo);
                if (ByteImage != null)
                {
                    var ma = new MemoryStream(ByteImage);
                    pictureEdit1.Image = Image.FromStream(ma);


                }

                Properties.Settings.Default.Save();
                MessageBox.Show("تمت عملية الحفظ بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SaveSetting()
        {
            try
            {
                edy_comanynmae.Text = Properties.Settings.Default.CompanyName;
                edt_comanydes.Text = Properties.Settings.Default.CompanyDes;

                var ma = new MemoryStream();
                pictureEdit1.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Png);
                Properties.Settings.Default.CompanyLogo = Convert.ToBase64String(ma.ToArray());



                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SaveSetting();
        }

       
        private void SaveConStrign()
        {
            var server = editServerName.Text;
            var dbname = EditDatabase.Text;
            var port = "," + EditPort.Text;
            var user = editUsername.Text;
            var password = editPassword.Text;

            if (cmbAuth.SelectedIndex ==0)
            {
                 con1 = "Data Source=" + editServerName.SelectedItem + ";Initial Catalog=" + EditDatabase.SelectedItem + ";Integrated Security=True";

            }
            else
            {
                 con1 = "Data Source=" + editServerName.SelectedItem + ";Initial Catalog=" + EditDatabase.SelectedItem + "; User ID=" + editUsername.Text+ "Password="+editPassword.Text;

            }


            MessageBox.Show(con1);
        


                //////////////////////////////////////////////////

                Configuration config = ConfigurationManager
                .OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location);

                ConnectionStringsSection section =
                  (ConnectionStringsSection)config.GetSection("connectionStrings");

                section.ConnectionStrings["ASMAADEVEXPRESS.Properties.Settings.Contract_invoiceConnectionString"].ConnectionString =con1;

                config.Save();


                MessageBox.Show(section.ConnectionStrings["ASMAADEVEXPRESS.Properties.Settings.Contract_invoiceConnectionString"].ConnectionString);
                Application.Restart();
          
        }

        private void EditDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
           
           /* using (var db = new DAl.dbDataContext())
            {
                db.Connection.ConnectionString = con1;
            }

            using (var db = new DAl.dbDataContext())
            {
                try
                {
                    db.Connection.Open();
                    MessageBox.Show("yes");


                    var frm = new MainForm();
                    frm.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("No");
                    throw;
                }
            }*/
        }

        private void editServerName_SelectedIndexChanged(object sender, EventArgs e)
        {

            GetDataBaese();


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            GetDataBaese();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
      //      SaveConStrign();

           
        }

        private void EditDatabase_Popup(object sender, EventArgs e)
        {
            using (var db = new DAl.dbDataContext())
            {
                int Connt_x = databases.Where(x => x.Contains("Contract_invoice")).Count();
                if (Connt_x == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("DataBase is not found , Do you want Create it ?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();

                        string NewDataSource = editServerName.Text;
                        connection.DataSource = NewDataSource;
                        connection.IntegratedSecurity = true;
                        db.Connection.ConnectionString = connection.ToString();
                        db.CreateDatabase();

                    }
                }
            }
        }
        
        private async void button2_Click(object sender, EventArgs e)
        {
            using (var db=new DAl.dbDataContext())
            {
                saveFileDialog1.FileName = (EditDatabase.SelectedItem).ToString();
                saveFileDialog1.ShowDialog();
                saveFileDialog1.AddExtension = true;
               
                saveFileDialog1.DefaultExt = "sql";
                string s = null;
                s = saveFileDialog1.FileName;
               
                string databese = db.Connection.Database;
                string qur = "Backup database " + EditDatabase.SelectedItem + " to disk='" + s + ".bak'";

                MessageBox.Show(qur);
                db.ExecuteCommand(qur);
            }

        }
     

        private void EditConnectionString_Load(object sender, EventArgs e)
        {

        }

        

        private void cmbAuth_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbAuth.SelectedIndex == 0)
            {
                editPassword.Visible = false;
                editUsername.Visible = false;
            }
            else
            {
                editPassword.Visible = true;
                editUsername.Visible = true;
            }
        }
    }
}
