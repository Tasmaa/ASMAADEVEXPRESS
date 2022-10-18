
namespace ASMAADEVEXPRESS.FRM
{
    partial class DelayProjects
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.delaytableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DurationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.from_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.to_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.BookNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BookDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.project_idTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForid = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForproject_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDuration = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForfrom_date = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForto_date = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBookNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBookDate = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delaytableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.from_dateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.from_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.to_dateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.to_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForproject_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfrom_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForto_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBookNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBookDate)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.idTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DurationTextEdit);
            this.dataLayoutControl1.Controls.Add(this.from_dateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.to_dateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.BookNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BookDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.project_idTextEdit);
            this.dataLayoutControl1.DataSource = this.delaytableBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 51);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(396, 213);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // idTextEdit
            // 
            this.idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.delaytableBindingSource, "id", true));
            this.idTextEdit.Location = new System.Drawing.Point(12, 12);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.idTextEdit.Properties.Mask.EditMask = "N0";
            this.idTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.idTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.idTextEdit.Size = new System.Drawing.Size(301, 20);
            this.idTextEdit.StyleController = this.dataLayoutControl1;
            this.idTextEdit.TabIndex = 4;
            this.idTextEdit.Visible = false;
            // 
            // delaytableBindingSource
            // 
            this.delaytableBindingSource.DataSource = typeof(ASMAADEVEXPRESS.DAl.delay_table);
            // 
            // DurationTextEdit
            // 
            this.DurationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.delaytableBindingSource, "Duration", true));
            this.DurationTextEdit.Location = new System.Drawing.Point(12, 60);
            this.DurationTextEdit.Name = "DurationTextEdit";
            this.DurationTextEdit.Size = new System.Drawing.Size(301, 20);
            this.DurationTextEdit.StyleController = this.dataLayoutControl1;
            this.DurationTextEdit.TabIndex = 6;
            // 
            // from_dateDateEdit
            // 
            this.from_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.delaytableBindingSource, "from_date", true));
            this.from_dateDateEdit.EditValue = null;
            this.from_dateDateEdit.Location = new System.Drawing.Point(12, 84);
            this.from_dateDateEdit.Name = "from_dateDateEdit";
            this.from_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.from_dateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.from_dateDateEdit.Size = new System.Drawing.Size(301, 20);
            this.from_dateDateEdit.StyleController = this.dataLayoutControl1;
            this.from_dateDateEdit.TabIndex = 7;
            // 
            // to_dateDateEdit
            // 
            this.to_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.delaytableBindingSource, "to_date", true));
            this.to_dateDateEdit.EditValue = null;
            this.to_dateDateEdit.Location = new System.Drawing.Point(12, 108);
            this.to_dateDateEdit.Name = "to_dateDateEdit";
            this.to_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.to_dateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.to_dateDateEdit.Size = new System.Drawing.Size(301, 20);
            this.to_dateDateEdit.StyleController = this.dataLayoutControl1;
            this.to_dateDateEdit.TabIndex = 8;
            // 
            // BookNoTextEdit
            // 
            this.BookNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.delaytableBindingSource, "BookNo", true));
            this.BookNoTextEdit.Location = new System.Drawing.Point(12, 132);
            this.BookNoTextEdit.Name = "BookNoTextEdit";
            this.BookNoTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.BookNoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BookNoTextEdit.Properties.Mask.EditMask = "N0";
            this.BookNoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.BookNoTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.BookNoTextEdit.Size = new System.Drawing.Size(301, 20);
            this.BookNoTextEdit.StyleController = this.dataLayoutControl1;
            this.BookNoTextEdit.TabIndex = 9;
            // 
            // BookDateDateEdit
            // 
            this.BookDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.delaytableBindingSource, "BookDate", true));
            this.BookDateDateEdit.EditValue = null;
            this.BookDateDateEdit.Location = new System.Drawing.Point(12, 156);
            this.BookDateDateEdit.Name = "BookDateDateEdit";
            this.BookDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BookDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BookDateDateEdit.Size = new System.Drawing.Size(301, 20);
            this.BookDateDateEdit.StyleController = this.dataLayoutControl1;
            this.BookDateDateEdit.TabIndex = 10;
            // 
            // project_idTextEdit
            // 
            this.project_idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.delaytableBindingSource, "project_id", true));
            this.project_idTextEdit.Location = new System.Drawing.Point(12, 36);
            this.project_idTextEdit.Name = "project_idTextEdit";
            this.project_idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.project_idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.project_idTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.project_idTextEdit.Properties.NullText = "";
            this.project_idTextEdit.Size = new System.Drawing.Size(301, 20);
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
            this.Root.Size = new System.Drawing.Size(396, 213);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForid,
            this.ItemForproject_id,
            this.ItemForDuration,
            this.ItemForfrom_date,
            this.ItemForto_date,
            this.ItemForBookNo,
            this.ItemForBookDate});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(376, 193);
            // 
            // ItemForid
            // 
            this.ItemForid.Control = this.idTextEdit;
            this.ItemForid.Location = new System.Drawing.Point(0, 0);
            this.ItemForid.Name = "ItemForid";
            this.ItemForid.Size = new System.Drawing.Size(376, 24);
            this.ItemForid.Text = "id";
            this.ItemForid.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForproject_id
            // 
            this.ItemForproject_id.Control = this.project_idTextEdit;
            this.ItemForproject_id.Location = new System.Drawing.Point(0, 24);
            this.ItemForproject_id.Name = "ItemForproject_id";
            this.ItemForproject_id.Size = new System.Drawing.Size(376, 24);
            this.ItemForproject_id.Text = "اسم المشروع";
            this.ItemForproject_id.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForDuration
            // 
            this.ItemForDuration.Control = this.DurationTextEdit;
            this.ItemForDuration.Location = new System.Drawing.Point(0, 48);
            this.ItemForDuration.Name = "ItemForDuration";
            this.ItemForDuration.Size = new System.Drawing.Size(376, 24);
            this.ItemForDuration.Text = "المدة";
            this.ItemForDuration.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForfrom_date
            // 
            this.ItemForfrom_date.Control = this.from_dateDateEdit;
            this.ItemForfrom_date.Location = new System.Drawing.Point(0, 72);
            this.ItemForfrom_date.Name = "ItemForfrom_date";
            this.ItemForfrom_date.Size = new System.Drawing.Size(376, 24);
            this.ItemForfrom_date.Text = "من";
            this.ItemForfrom_date.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForto_date
            // 
            this.ItemForto_date.Control = this.to_dateDateEdit;
            this.ItemForto_date.Location = new System.Drawing.Point(0, 96);
            this.ItemForto_date.Name = "ItemForto_date";
            this.ItemForto_date.Size = new System.Drawing.Size(376, 24);
            this.ItemForto_date.Text = "الى";
            this.ItemForto_date.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForBookNo
            // 
            this.ItemForBookNo.Control = this.BookNoTextEdit;
            this.ItemForBookNo.Location = new System.Drawing.Point(0, 120);
            this.ItemForBookNo.Name = "ItemForBookNo";
            this.ItemForBookNo.Size = new System.Drawing.Size(376, 24);
            this.ItemForBookNo.Text = "رقم الكتاب";
            this.ItemForBookNo.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForBookDate
            // 
            this.ItemForBookDate.Control = this.BookDateDateEdit;
            this.ItemForBookDate.Location = new System.Drawing.Point(0, 144);
            this.ItemForBookDate.Name = "ItemForBookDate";
            this.ItemForBookDate.Size = new System.Drawing.Size(376, 49);
            this.ItemForBookDate.Text = "تاريخ الكتاب";
            this.ItemForBookDate.TextSize = new System.Drawing.Size(67, 13);
            // 
            // DelayProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 290);
            this.Controls.Add(this.dataLayoutControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "DelayProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DelayProjects";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.DelayProjects_Load);
            this.Controls.SetChildIndex(this.dataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delaytableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.from_dateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.from_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.to_dateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.to_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForproject_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfrom_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForto_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBookNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBookDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource delaytableBindingSource;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private DevExpress.XtraEditors.TextEdit DurationTextEdit;
        private DevExpress.XtraEditors.DateEdit from_dateDateEdit;
        private DevExpress.XtraEditors.DateEdit to_dateDateEdit;
        private DevExpress.XtraEditors.TextEdit BookNoTextEdit;
        private DevExpress.XtraEditors.DateEdit BookDateDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForid;
        private DevExpress.XtraLayout.LayoutControlItem ItemForproject_id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDuration;
        private DevExpress.XtraLayout.LayoutControlItem ItemForfrom_date;
        private DevExpress.XtraLayout.LayoutControlItem ItemForto_date;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBookNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBookDate;
        private DevExpress.XtraEditors.LookUpEdit project_idTextEdit;
    }
}