
namespace ASMAADEVEXPRESS.FRM
{
    partial class SubProjects
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
            this.contractExtensionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ContractExtensionIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ContractExtenationNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ImagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.project_idTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForContractExtensionId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForproject_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForImage = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForContractExtenationNo = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.contractExtensionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractExtensionIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractExtenationNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContractExtensionId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForproject_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContractExtenationNo)).BeginInit();
            this.SuspendLayout();
            // 
            // contractExtensionBindingSource
            // 
            this.contractExtensionBindingSource.DataSource = typeof(ASMAADEVEXPRESS.DAl.ContractExtension);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.ContractExtensionIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ContractExtenationNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ImagePictureEdit);
            this.dataLayoutControl1.Controls.Add(this.project_idTextEdit);
            this.dataLayoutControl1.DataSource = this.contractExtensionBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(38, 32);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(515, 256);
            this.dataLayoutControl1.TabIndex = 9;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ContractExtensionIdTextEdit
            // 
            this.ContractExtensionIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contractExtensionBindingSource, "ContractExtensionId", true));
            this.ContractExtensionIdTextEdit.Location = new System.Drawing.Point(12, 12);
            this.ContractExtensionIdTextEdit.Name = "ContractExtensionIdTextEdit";
            this.ContractExtensionIdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ContractExtensionIdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ContractExtensionIdTextEdit.Properties.Mask.EditMask = "N0";
            this.ContractExtensionIdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ContractExtensionIdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ContractExtensionIdTextEdit.Size = new System.Drawing.Size(382, 20);
            this.ContractExtensionIdTextEdit.StyleController = this.dataLayoutControl1;
            this.ContractExtensionIdTextEdit.TabIndex = 4;
            // 
            // ContractExtenationNoTextEdit
            // 
            this.ContractExtenationNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contractExtensionBindingSource, "ContractExtenationNo", true));
            this.ContractExtenationNoTextEdit.Location = new System.Drawing.Point(12, 36);
            this.ContractExtenationNoTextEdit.Name = "ContractExtenationNoTextEdit";
            this.ContractExtenationNoTextEdit.Size = new System.Drawing.Size(382, 20);
            this.ContractExtenationNoTextEdit.StyleController = this.dataLayoutControl1;
            this.ContractExtenationNoTextEdit.TabIndex = 6;
            // 
            // ImagePictureEdit
            // 
            this.ImagePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contractExtensionBindingSource, "Image", true));
            this.ImagePictureEdit.Location = new System.Drawing.Point(12, 84);
            this.ImagePictureEdit.Name = "ImagePictureEdit";
            this.ImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.ImagePictureEdit.Size = new System.Drawing.Size(491, 160);
            this.ImagePictureEdit.StyleController = this.dataLayoutControl1;
            this.ImagePictureEdit.TabIndex = 7;
            // 
            // project_idTextEdit
            // 
            this.project_idTextEdit.Location = new System.Drawing.Point(12, 60);
            this.project_idTextEdit.Name = "project_idTextEdit";
            this.project_idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.project_idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.project_idTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.project_idTextEdit.Properties.NullText = "";
            this.project_idTextEdit.Size = new System.Drawing.Size(382, 20);
            this.project_idTextEdit.StyleController = this.dataLayoutControl1;
            this.project_idTextEdit.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(515, 256);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForContractExtensionId,
            this.ItemForproject_id,
            this.ItemForImage,
            this.ItemForContractExtenationNo});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(495, 236);
            // 
            // ItemForContractExtensionId
            // 
            this.ItemForContractExtensionId.Control = this.ContractExtensionIdTextEdit;
            this.ItemForContractExtensionId.Location = new System.Drawing.Point(0, 0);
            this.ItemForContractExtensionId.Name = "ItemForContractExtensionId";
            this.ItemForContractExtensionId.Size = new System.Drawing.Size(495, 24);
            this.ItemForContractExtensionId.Text = "Contract Extension Id";
            this.ItemForContractExtensionId.TextSize = new System.Drawing.Size(105, 13);
            this.ItemForContractExtensionId.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // ItemForproject_id
            // 
            this.ItemForproject_id.Control = this.project_idTextEdit;
            this.ItemForproject_id.Location = new System.Drawing.Point(0, 48);
            this.ItemForproject_id.Name = "ItemForproject_id";
            this.ItemForproject_id.Size = new System.Drawing.Size(495, 24);
            this.ItemForproject_id.Text = "اختر اسم المشروع";
            this.ItemForproject_id.TextSize = new System.Drawing.Size(105, 13);
            // 
            // ItemForImage
            // 
            this.ItemForImage.Control = this.ImagePictureEdit;
            this.ItemForImage.Location = new System.Drawing.Point(0, 72);
            this.ItemForImage.Name = "ItemForImage";
            this.ItemForImage.Size = new System.Drawing.Size(495, 164);
            this.ItemForImage.StartNewLine = true;
            this.ItemForImage.Text = "Image";
            this.ItemForImage.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForImage.TextVisible = false;
            // 
            // ItemForContractExtenationNo
            // 
            this.ItemForContractExtenationNo.Control = this.ContractExtenationNoTextEdit;
            this.ItemForContractExtenationNo.Location = new System.Drawing.Point(0, 24);
            this.ItemForContractExtenationNo.Name = "ItemForContractExtenationNo";
            this.ItemForContractExtenationNo.Size = new System.Drawing.Size(495, 24);
            this.ItemForContractExtenationNo.Text = "ادخل رقم ملحق العقد";
            this.ItemForContractExtenationNo.TextSize = new System.Drawing.Size(105, 13);
            // 
            // SubProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 369);
            this.Controls.Add(this.dataLayoutControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "SubProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubProjects";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.SubProjects_Load);
            this.Controls.SetChildIndex(this.dataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.contractExtensionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContractExtensionIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractExtenationNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContractExtensionId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForproject_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContractExtenationNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource contractExtensionBindingSource;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit ContractExtensionIdTextEdit;
        private DevExpress.XtraEditors.TextEdit ContractExtenationNoTextEdit;
        private DevExpress.XtraEditors.PictureEdit ImagePictureEdit;
        private DevExpress.XtraEditors.LookUpEdit project_idTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContractExtensionId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForproject_id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForImage;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContractExtenationNo;
    }
}