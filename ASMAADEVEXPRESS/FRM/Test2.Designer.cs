
namespace ASMAADEVEXPRESS.FRM
{
    partial class Test2
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.projecttableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colproject_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobTitleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractNameId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectNameId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreferralNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreferralDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontractNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractDuration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompletionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDailyFineAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtensionTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsurancePolicyNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinancialStampFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEngineersPensionFundFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatutoryInsurances = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontract_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljobTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproject_t = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecttableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            gridLevelNode2.RelationName = "Level2";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(44, 56);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(363, 189);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproject_id,
            this.colJobTitleId,
            this.colContractNameId,
            this.colProjectNameId,
            this.colreferralNo,
            this.colreferralDate,
            this.colcontractNo,
            this.colContractDate,
            this.colContractAmount,
            this.colContractDuration,
            this.colStartDate,
            this.colCompletionDate,
            this.colDailyFineAmount,
            this.colExtensionTime,
            this.colInsurancePolicyNumber,
            this.colFinancialStampFee,
            this.colEngineersPensionFundFee,
            this.colStatutoryInsurances,
            this.colImage,
            this.colFileName,
            this.colcontract_name,
            this.coljobTitle,
            this.colproject_t});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // projecttableBindingSource
            // 
            this.projecttableBindingSource.DataSource = typeof(ASMAADEVEXPRESS.DAl.project_table);
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
            // colreferralNo
            // 
            this.colreferralNo.FieldName = "referralNo";
            this.colreferralNo.Name = "colreferralNo";
            this.colreferralNo.Visible = true;
            this.colreferralNo.VisibleIndex = 4;
            // 
            // colreferralDate
            // 
            this.colreferralDate.FieldName = "referralDate";
            this.colreferralDate.Name = "colreferralDate";
            this.colreferralDate.Visible = true;
            this.colreferralDate.VisibleIndex = 5;
            // 
            // colcontractNo
            // 
            this.colcontractNo.FieldName = "contractNo";
            this.colcontractNo.Name = "colcontractNo";
            this.colcontractNo.Visible = true;
            this.colcontractNo.VisibleIndex = 6;
            // 
            // colContractDate
            // 
            this.colContractDate.FieldName = "ContractDate";
            this.colContractDate.Name = "colContractDate";
            this.colContractDate.Visible = true;
            this.colContractDate.VisibleIndex = 7;
            // 
            // colContractAmount
            // 
            this.colContractAmount.FieldName = "ContractAmount";
            this.colContractAmount.Name = "colContractAmount";
            this.colContractAmount.Visible = true;
            this.colContractAmount.VisibleIndex = 8;
            // 
            // colContractDuration
            // 
            this.colContractDuration.FieldName = "ContractDuration";
            this.colContractDuration.Name = "colContractDuration";
            this.colContractDuration.Visible = true;
            this.colContractDuration.VisibleIndex = 9;
            // 
            // colStartDate
            // 
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 10;
            // 
            // colCompletionDate
            // 
            this.colCompletionDate.FieldName = "CompletionDate";
            this.colCompletionDate.Name = "colCompletionDate";
            this.colCompletionDate.Visible = true;
            this.colCompletionDate.VisibleIndex = 11;
            // 
            // colDailyFineAmount
            // 
            this.colDailyFineAmount.FieldName = "DailyFineAmount";
            this.colDailyFineAmount.Name = "colDailyFineAmount";
            this.colDailyFineAmount.Visible = true;
            this.colDailyFineAmount.VisibleIndex = 12;
            // 
            // colExtensionTime
            // 
            this.colExtensionTime.FieldName = "ExtensionTime";
            this.colExtensionTime.Name = "colExtensionTime";
            this.colExtensionTime.Visible = true;
            this.colExtensionTime.VisibleIndex = 13;
            // 
            // colInsurancePolicyNumber
            // 
            this.colInsurancePolicyNumber.FieldName = "InsurancePolicyNumber";
            this.colInsurancePolicyNumber.Name = "colInsurancePolicyNumber";
            this.colInsurancePolicyNumber.Visible = true;
            this.colInsurancePolicyNumber.VisibleIndex = 14;
            // 
            // colFinancialStampFee
            // 
            this.colFinancialStampFee.FieldName = "FinancialStampFee";
            this.colFinancialStampFee.Name = "colFinancialStampFee";
            this.colFinancialStampFee.Visible = true;
            this.colFinancialStampFee.VisibleIndex = 15;
            // 
            // colEngineersPensionFundFee
            // 
            this.colEngineersPensionFundFee.FieldName = "EngineersPensionFundFee";
            this.colEngineersPensionFundFee.Name = "colEngineersPensionFundFee";
            this.colEngineersPensionFundFee.Visible = true;
            this.colEngineersPensionFundFee.VisibleIndex = 16;
            // 
            // colStatutoryInsurances
            // 
            this.colStatutoryInsurances.FieldName = "StatutoryInsurances";
            this.colStatutoryInsurances.Name = "colStatutoryInsurances";
            this.colStatutoryInsurances.Visible = true;
            this.colStatutoryInsurances.VisibleIndex = 17;
            // 
            // colImage
            // 
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 18;
            // 
            // colFileName
            // 
            this.colFileName.FieldName = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 19;
            // 
            // colcontract_name
            // 
            this.colcontract_name.FieldName = "contract_name";
            this.colcontract_name.Name = "colcontract_name";
            this.colcontract_name.Visible = true;
            this.colcontract_name.VisibleIndex = 20;
            // 
            // coljobTitle
            // 
            this.coljobTitle.FieldName = "jobTitle";
            this.coljobTitle.Name = "coljobTitle";
            this.coljobTitle.Visible = true;
            this.coljobTitle.VisibleIndex = 21;
            // 
            // colproject_t
            // 
            this.colproject_t.FieldName = "project_t";
            this.colproject_t.Name = "colproject_t";
            this.colproject_t.Visible = true;
            this.colproject_t.VisibleIndex = 22;
            // 
            // Test2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 343);
            this.Controls.Add(this.gridControl1);
            this.Name = "Test2";
            this.Text = "Test2";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecttableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colproject_id;
        private DevExpress.XtraGrid.Columns.GridColumn colJobTitleId;
        private DevExpress.XtraGrid.Columns.GridColumn colContractNameId;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectNameId;
        private DevExpress.XtraGrid.Columns.GridColumn colreferralNo;
        private DevExpress.XtraGrid.Columns.GridColumn colreferralDate;
        private DevExpress.XtraGrid.Columns.GridColumn colcontractNo;
        private DevExpress.XtraGrid.Columns.GridColumn colContractDate;
        private DevExpress.XtraGrid.Columns.GridColumn colContractAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colContractDuration;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCompletionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDailyFineAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colExtensionTime;
        private DevExpress.XtraGrid.Columns.GridColumn colInsurancePolicyNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colFinancialStampFee;
        private DevExpress.XtraGrid.Columns.GridColumn colEngineersPensionFundFee;
        private DevExpress.XtraGrid.Columns.GridColumn colStatutoryInsurances;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colcontract_name;
        private DevExpress.XtraGrid.Columns.GridColumn coljobTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colproject_t;
        private System.Windows.Forms.BindingSource projecttableBindingSource;
    }
}