namespace MutantTestingApp
{
    partial class XCompareCode
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.memoEditOrgCode = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.memoEditMutantCode = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OrgLineNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrgCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mutantLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MutantCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCompare = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditOrgCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditMutantCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.treeList1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(294, 505);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Mutants";
            // 
            // treeList1
            // 
            this.treeList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.Location = new System.Drawing.Point(15, 32);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[0], -1);
            this.treeList1.EndUnboundLoad();
            this.treeList1.Size = new System.Drawing.Size(261, 455);
            this.treeList1.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.memoEditMutantCode);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.memoEditOrgCode);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(324, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(657, 137);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Location Information";
            // 
            // memoEditOrgCode
            // 
            this.memoEditOrgCode.Enabled = false;
            this.memoEditOrgCode.Location = new System.Drawing.Point(14, 51);
            this.memoEditOrgCode.Name = "memoEditOrgCode";
            this.memoEditOrgCode.Size = new System.Drawing.Size(314, 74);
            this.memoEditOrgCode.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Original Code";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // memoEditMutantCode
            // 
            this.memoEditMutantCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEditMutantCode.Enabled = false;
            this.memoEditMutantCode.Location = new System.Drawing.Point(335, 51);
            this.memoEditMutantCode.Name = "memoEditMutantCode";
            this.memoEditMutantCode.Size = new System.Drawing.Size(314, 74);
            this.memoEditMutantCode.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(335, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mutant Code";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(324, 167);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(657, 350);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.OrgLineNumber,
            this.OrgCode,
            this.mutantLine,
            this.MutantCode});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // OrgLineNumber
            // 
            this.OrgLineNumber.Caption = "Line Number";
            this.OrgLineNumber.Name = "OrgLineNumber";
            this.OrgLineNumber.OptionsColumn.ReadOnly = true;
            this.OrgLineNumber.Visible = true;
            this.OrgLineNumber.VisibleIndex = 0;
            // 
            // OrgCode
            // 
            this.OrgCode.Caption = "Source Code";
            this.OrgCode.Name = "OrgCode";
            this.OrgCode.OptionsColumn.ReadOnly = true;
            this.OrgCode.Visible = true;
            this.OrgCode.VisibleIndex = 1;
            // 
            // mutantLine
            // 
            this.mutantLine.Caption = "Line Number";
            this.mutantLine.Name = "mutantLine";
            this.mutantLine.OptionsColumn.ReadOnly = true;
            this.mutantLine.Visible = true;
            this.mutantLine.VisibleIndex = 2;
            // 
            // MutantCode
            // 
            this.MutantCode.Caption = "Mutant Code";
            this.MutantCode.Name = "MutantCode";
            this.MutantCode.OptionsColumn.ReadOnly = true;
            this.MutantCode.Visible = true;
            this.MutantCode.VisibleIndex = 3;
            // 
            // simpleButtonClose
            // 
            this.simpleButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonClose.Location = new System.Drawing.Point(906, 534);
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonClose.TabIndex = 3;
            this.simpleButtonClose.Text = "Close";
            this.simpleButtonClose.Click += new System.EventHandler(this.simpleButtonClose_Click);
            // 
            // simpleButtonCompare
            // 
            this.simpleButtonCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonCompare.Location = new System.Drawing.Point(802, 534);
            this.simpleButtonCompare.Name = "simpleButtonCompare";
            this.simpleButtonCompare.Size = new System.Drawing.Size(98, 23);
            this.simpleButtonCompare.TabIndex = 4;
            this.simpleButtonCompare.Text = "Compare Code";
            // 
            // XCompareCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 562);
            this.Controls.Add(this.simpleButtonCompare);
            this.Controls.Add(this.simpleButtonClose);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "XCompareCode";
            this.Text = "Mutation Testing - Compare Code";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditOrgCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditMutantCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.MemoEdit memoEditOrgCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit memoEditMutantCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn OrgLineNumber;
        private DevExpress.XtraGrid.Columns.GridColumn OrgCode;
        private DevExpress.XtraGrid.Columns.GridColumn mutantLine;
        private DevExpress.XtraGrid.Columns.GridColumn MutantCode;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClose;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCompare;
    }
}