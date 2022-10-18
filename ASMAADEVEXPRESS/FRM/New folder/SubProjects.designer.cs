
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 41);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(351, 212);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // idTextEdit
            // 
            this.idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.delaytableBindingSource, "id", true));
            this.idTextEdit.Location = new System.Drawing.Point(74, 12);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.idTextEdit.Properties.Mask.EditMask = "N0";
            this.idTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.idTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.idTextEdit.Size = new System.Drawing.Size(265, 20);
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
            this.DurationTextEdit.Location = new System.Drawing.Point(74, 60);
            this.DurationTextEdit.Name = "DurationTextEdit";
            this.DurationTextEdit.Size = new System.Drawing.Size(265, 20);
            this.DurationTextEdit.StyleController = this.dataLayoutControl1;
            this.DurationTextEdit.TabIndex = 6;
            // 
            // from_dateDateEdit
            // 
            this.from_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.delaytableBindingSource, "from_date", true));
            this.from_dateDateEdit.EditValue = null;
            this.from_dateDateEdit.Location = new System.Drawing.Point(74, 84);
            this.from_dateDateEdit.Name = "from_dateDateEdit";
            this.from_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.from_dateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.from_dateDateEdit.Size = new System.Drawing.Size(265, 20);
            this.from_dateDateEdit.StyleController = this.dataLayoutControl1;
            this.from_dateDateEdit.TabIndex = 7;
            // 
            // to_dateDateEdit
            // 
            this.to_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.delaytableBindingSource, "to_date", true));
            this.to_dateDateEdit.EditValue = null;
            this.to_dateDateEdit.Location = new System.Drawing.Point(74, 108);
            this.to_dateDateEdit.Name = "to_dateDateEdit";
            this.to_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.to_dateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.to_dateDateEdit.Size = new System.Drawing.Size(265, 20);
            this.to_dateDateEdit.StyleController = this.dataLayoutControl1;
            this.to_dateDateEdit.TabIndex = 8;
            // 
            // BookNoTextEdit
            // 
            this.BookNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.delaytableBindingSource, "BookNo", true));
            this.BookNoTextEdit.Location = new System.Drawing.Point(74, 132);
            this.BookNoTextEdit.Name = "BookNoTextEdit";
            this.BookNoTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.BookNoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BookNoTextEdit.Properties.Mask.EditMask = "N0";
            this.BookNoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.BookNoTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.BookNoTextEdit.Size = new System.Drawing.Size(265, 20);
            this.BookNoTextEdit.StyleController = this.dataLayoutControl1;
            this.BookNoTextEdit.TabIndex = 9;
            // 
            // BookDateDateEdit
            // 
            this.BookDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.delaytableBindingSource, "BookDate", true));
            this.BookDateDateEdit.EditValue = null;
            this.BookDateDateEdit.Location = new System.Drawing.Point(74, 156);
            this.BookDateDateEdit.Name = "BookDateDateEdit";
            this.BookDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BookDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BookDateDateEdit.Size = new System.Drawing.Size(265, 20);
            this.BookDateDateEdit.StyleController = this.dataLayoutControl1;
            this.BookDateDateEdit.TabIndex = 10;
            // 
            // project_idTextEdit
            // 
            this.project_idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.delaytableBindingSource, "project_id", true));
            this.project_idTextEdit.Location = new System.Drawing.Point(74, 36);
            this.project_idTextEdit.Name = "project_idTextEdit";
            this.project_idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.project_idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.project_idTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.project_idTextEdit.Properties.NullText = "";
            this.project_idTextEdit.Size = new System.Drawing.Size(265, 20);
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
            this.Root.Size = new System.Drawing.Size(351, 212);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(331, 192);
            // 
            // ItemForid
            // 
            this.ItemForid.Control = this.idTextEdit;
            this.ItemForid.Location = new System.Drawing.Point(0, 0);
            this.ItemForid.Name = "ItemForid";
            this.ItemForid.Size = new System.Drawing.Size(331, 24);
            this.ItemForid.Text = "id";
            this.ItemForid.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForproject_id
            // 
            this.ItemForproject_id.Control = this.project_idTextEdit;
            this.ItemForproject_id.Location = new System.Drawing.Point(0, 24);
            this.ItemForproject_id.Name = "ItemForproject_id";
            this.ItemForproject_id.Size = new System.Drawing.Size(331, 24);
            this.ItemForproject_id.Text = "project_id";
            this.ItemForproject_id.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForDuration
            // 
            this.ItemForDuration.Control = this.DurationTextEdit;
            this.ItemForDuration.Location = new System.Drawing.Point(0, 48);
            this.ItemForDuration.Name = "ItemForDuration";
            this.ItemForDuration.Size = new System.Drawing.Size(331, 24);
            this.ItemForDuration.Text = "Duration";
            this.ItemForDuration.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForfrom_date
            // 
            this.ItemForfrom_date.Control = this.from_dateDateEdit;
            this.ItemForfrom_date.Location = new System.Drawing.Point(0, 72);
            this.ItemForfrom_date.Name = "ItemForfrom_date";
            this.ItemForfrom_date.Size = new System.Drawing.Size(331, 24);
            this.ItemForfrom_date.Text = "from_date";
            this.ItemForfrom_date.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForto_date
            // 
            this.ItemForto_date.Control = this.to_dateDateEdit;
            this.ItemForto_date.Location = new System.Drawing.Point(0, 96);
            this.ItemForto_date.Name = "ItemForto_date";
            this.ItemForto_date.Size = new System.Drawing.Size(331, 24);
            this.ItemForto_date.Text = "to_date";
            this.ItemForto_date.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForBookNo
            // 
            this.ItemForBookNo.Control = this.BookNoTextEdit;
            this.ItemForBookNo.Location = new System.Drawing.Point(0, 120);
            this.ItemForBookNo.Name = "ItemForBookNo";
            this.ItemForBookNo.Size = new System.Drawing.Size(331, 24);
            this.ItemForBookNo.Text = "Book No";
            this.ItemForBookNo.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForBookDate
            // 
            this.ItemForBookDate.Control = this.BookDateDateEdit;
            this.ItemForBookDate.Location = new System.Drawing.Point(0, 144);
            this.ItemForBookDate.Name = "ItemForBookDate";
            this.ItemForBookDate.Size = new System.Drawing.Size(331, 48);
            this.ItemForBookDate.Text = "Book Date";
            this.ItemForBookDate.TextSize = new System.Drawing.Size(50, 13);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "add";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "save";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "update";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "delete";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(351, 41);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 253);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(351, 20);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 41);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(0, 212);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(351, 41);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(0, 212);
            // 
            // SubProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 273);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "SubProjects";
            this.Text = "SubProjects";
            this.Load += new System.EventHandler(this.SubProjects_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
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
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraEditors.LookUpEdit project_idTextEdit;
    }
}