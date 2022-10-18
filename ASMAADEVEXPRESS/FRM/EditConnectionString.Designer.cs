
namespace ASMAADEVEXPRESS.FRM
{
    partial class EditConnectionString
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditConnectionString));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAuth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editPassword = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditPort = new DevExpress.XtraEditors.TextEdit();
            this.editUsername = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.editServerName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.EditDatabase = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.edt_comanydes = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.edy_comanynmae = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAuth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDatabase.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_comanydes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edy_comanynmae.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Location = new System.Drawing.Point(397, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاتصال الشبكي";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(29, 234);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(103, 23);
            this.simpleButton3.TabIndex = 16;
            this.simpleButton3.Text = "Test Connction";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbAuth);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.editPassword);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.EditPort);
            this.groupBox3.Controls.Add(this.editUsername);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.editServerName);
            this.groupBox3.Controls.Add(this.EditDatabase);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 208);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 98);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "الموثوقية";
            // 
            // cmbAuth
            // 
            this.cmbAuth.EditValue = "Windows Authentication";
            this.cmbAuth.Location = new System.Drawing.Point(3, 95);
            this.cmbAuth.Name = "cmbAuth";
            this.cmbAuth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAuth.Properties.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Authentication "});
            this.cmbAuth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbAuth.Size = new System.Drawing.Size(143, 20);
            this.cmbAuth.TabIndex = 12;
            this.cmbAuth.SelectedValueChanged += new System.EventHandler(this.cmbAuth_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 39);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "اسم السيرفر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 182);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "كلمة السر";
            // 
            // editPassword
            // 
            this.editPassword.EditValue = "";
            this.editPassword.Location = new System.Drawing.Point(3, 179);
            this.editPassword.Name = "editPassword";
            this.editPassword.Size = new System.Drawing.Size(143, 20);
            this.editPassword.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 67);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "قاعدة البيانات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 153);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "اسم المستخدم";
            // 
            // EditPort
            // 
            this.EditPort.EditValue = "1433";
            this.EditPort.Location = new System.Drawing.Point(3, 121);
            this.EditPort.Name = "EditPort";
            this.EditPort.Size = new System.Drawing.Size(143, 20);
            this.EditPort.TabIndex = 6;
            // 
            // editUsername
            // 
            this.editUsername.EditValue = "";
            this.editUsername.Location = new System.Drawing.Point(3, 150);
            this.editUsername.Name = "editUsername";
            this.editUsername.Size = new System.Drawing.Size(143, 20);
            this.editUsername.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 124);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "رقم المنفذ";
            // 
            // editServerName
            // 
            this.editServerName.EditValue = "";
            this.editServerName.Location = new System.Drawing.Point(3, 36);
            this.editServerName.Name = "editServerName";
            this.editServerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editServerName.Size = new System.Drawing.Size(143, 20);
            this.editServerName.TabIndex = 2;
            this.editServerName.SelectedIndexChanged += new System.EventHandler(this.editServerName_SelectedIndexChanged);
            // 
            // EditDatabase
            // 
            this.EditDatabase.EditValue = "";
            this.EditDatabase.Location = new System.Drawing.Point(3, 64);
            this.EditDatabase.Name = "EditDatabase";
            this.EditDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EditDatabase.Size = new System.Drawing.Size(143, 20);
            this.EditDatabase.TabIndex = 4;
            this.EditDatabase.SelectedIndexChanged += new System.EventHandler(this.EditDatabase_SelectedIndexChanged);
            this.EditDatabase.Popup += new System.EventHandler(this.EditDatabase_Popup);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(-2, -2);
            this.simpleButton1.Location = new System.Drawing.Point(218, 233);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(110, 34);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "حفظ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(322, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "اخذ نسخة احتياطية";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleButton2);
            this.groupBox2.Controls.Add(this.pictureEdit1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.edt_comanydes);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.edy_comanynmae);
            this.groupBox2.Location = new System.Drawing.Point(53, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 362);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اعدادات عامه";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton2.ImageOptions.SvgImageSize = new System.Drawing.Size(-2, -2);
            this.simpleButton2.Location = new System.Drawing.Point(212, 310);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(110, 34);
            this.simpleButton2.TabIndex = 15;
            this.simpleButton2.Text = "حفظ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(19, 201);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(115, 111);
            this.pictureEdit1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "الشعار";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "وصف المؤسسة";
            // 
            // edt_comanydes
            // 
            this.edt_comanydes.Location = new System.Drawing.Point(6, 163);
            this.edt_comanydes.Name = "edt_comanydes";
            this.edt_comanydes.Size = new System.Drawing.Size(276, 20);
            this.edt_comanydes.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "اسم المؤسسة";
            // 
            // edy_comanynmae
            // 
            this.edy_comanynmae.Location = new System.Drawing.Point(6, 94);
            this.edy_comanynmae.Name = "edy_comanynmae";
            this.edy_comanynmae.Size = new System.Drawing.Size(276, 20);
            this.edy_comanynmae.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(461, 326);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(260, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "يجب تشغيل البرنامج كمسؤول حتى  اجراء النسخ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(585, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "label11";
            // 
            // EditConnectionString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 496);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.ShowIcon = false;
            this.Name = "EditConnectionString";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditConnectionString_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAuth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDatabase.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_comanydes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edy_comanynmae.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit editPassword;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit editUsername;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit EditPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit edt_comanydes;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit edy_comanynmae;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ComboBoxEdit editServerName;
        private DevExpress.XtraEditors.ComboBoxEdit EditDatabase;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAuth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}