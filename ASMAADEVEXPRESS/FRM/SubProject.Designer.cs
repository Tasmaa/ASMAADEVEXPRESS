
namespace ASMAADEVEXPRESS.FRM
{
    partial class SubProject
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.project_idTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ContractExtenationNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.contractExtensionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractExtenationNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // contractExtensionBindingSource
            // 
            this.contractExtensionBindingSource.DataSource = typeof(ASMAADEVEXPRESS.DAl.ContractExtension);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.treeList1);
            this.layoutControl1.Controls.Add(this.project_idTextEdit);
            this.layoutControl1.Controls.Add(this.ContractExtenationNoTextEdit);
            this.layoutControl1.Location = new System.Drawing.Point(164, 46);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(708, 339);
            this.layoutControl1.TabIndex = 10;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // treeList1
            // 
            this.treeList1.Location = new System.Drawing.Point(12, 60);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(684, 20);
            this.treeList1.TabIndex = 6;
            // 
            // project_idTextEdit
            // 
            this.project_idTextEdit.Location = new System.Drawing.Point(12, 36);
            this.project_idTextEdit.Name = "project_idTextEdit";
            this.project_idTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.project_idTextEdit.Properties.NullText = "";
            this.project_idTextEdit.Size = new System.Drawing.Size(579, 20);
            this.project_idTextEdit.StyleController = this.layoutControl1;
            this.project_idTextEdit.TabIndex = 5;
            // 
            // ContractExtenationNoTextEdit
            // 
            this.ContractExtenationNoTextEdit.Location = new System.Drawing.Point(12, 12);
            this.ContractExtenationNoTextEdit.Name = "ContractExtenationNoTextEdit";
            this.ContractExtenationNoTextEdit.Size = new System.Drawing.Size(579, 20);
            this.ContractExtenationNoTextEdit.StyleController = this.layoutControl1;
            this.ContractExtenationNoTextEdit.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(708, 339);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ContractExtenationNoTextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(688, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(688, 247);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.project_idTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(688, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.treeList1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(688, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // SubProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 543);
            this.Controls.Add(this.layoutControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "SubProject";
            this.Text = "SubProject";
            this.Load += new System.EventHandler(this.SubProject_Load);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.contractExtensionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractExtenationNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource contractExtensionBindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.LookUpEdit project_idTextEdit;
        private DevExpress.XtraEditors.TextEdit ContractExtenationNoTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}