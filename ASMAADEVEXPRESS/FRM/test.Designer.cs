
namespace ASMAADEVEXPRESS.FRM
{
    partial class test
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.projecttableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractinvoiceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproject_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobTitleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractNameId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectNameId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecttableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractinvoiceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.projecttableBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "FK_delay_table_project_table";
            gridLevelNode3.RelationName = "Level3";
            gridLevelNode2.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            gridLevelNode2.RelationName = "Level2";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(759, 413);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // projecttableBindingSource
            // 
            this.projecttableBindingSource.DataMember = "project_table";
            this.projecttableBindingSource.DataSource = this.contractinvoiceDataSetBindingSource;
            // 
            // contractinvoiceDataSetBindingSource
            // 
            this.contractinvoiceDataSetBindingSource.Position = 0;
            // 
            // contract_invoiceDataSet
            // 
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproject_id,
            this.colJobTitleId,
            this.colContractNameId,
            this.colProjectNameId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colproject_id
            // 
            this.colproject_id.FieldName = "project_id";
            this.colproject_id.Name = "colproject_id";
            this.colproject_id.Visible = true;
            this.colproject_id.VisibleIndex = 0;
            // 
            // colJobTitleId
            // 
            this.colJobTitleId.FieldName = "JobTitleId";
            this.colJobTitleId.Name = "colJobTitleId";
            this.colJobTitleId.Visible = true;
            this.colJobTitleId.VisibleIndex = 1;
            // 
            // colContractNameId
            // 
            this.colContractNameId.FieldName = "ContractNameId";
            this.colContractNameId.Name = "colContractNameId";
            this.colContractNameId.Visible = true;
            this.colContractNameId.VisibleIndex = 2;
            // 
            // colProjectNameId
            // 
            this.colProjectNameId.FieldName = "ProjectNameId";
            this.colProjectNameId.Name = "colProjectNameId";
            this.colProjectNameId.Visible = true;
            this.colProjectNameId.VisibleIndex = 3;
            // 
            // project_tableTableAdapter
            // 
            // 
            // delay_tableTableAdapter1
            // 
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 413);
            this.Controls.Add(this.gridControl1);
            this.Name = "test";
            this.Load += new System.EventHandler(this.test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecttableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractinvoiceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource contractinvoiceDataSetBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource projecttableBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colproject_id;
        private DevExpress.XtraGrid.Columns.GridColumn colJobTitleId;
        private DevExpress.XtraGrid.Columns.GridColumn colContractNameId;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectNameId;
    }
}