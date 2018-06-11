namespace MutantTestingApp
{
    partial class XMainForm
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
            this.comboBoxEditUnitTest = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkCompileSolution = new DevExpress.XtraEditors.CheckEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.textEditKilledMutant = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditAllMutant = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEditTestCaseCount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnCheckAllObjectOperator = new DevExpress.XtraEditors.SimpleButton();
            this.btnCheckAllStandardOperator = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.checkedListBoxControlObjectOperator = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.checkEditOffut = new DevExpress.XtraEditors.CheckEdit();
            this.checkedListBoxControlStandardOperator = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnViewReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowMutant = new DevExpress.XtraEditors.SimpleButton();
            this.btnGenerateMutant = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditUnitTest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCompileSolution.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKilledMutant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAllMutant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTestCaseCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControlObjectOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditOffut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControlStandardOperator)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBoxEditUnitTest);
            this.groupControl1.Controls.Add(this.chkCompileSolution);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.btnRemove);
            this.groupControl1.Controls.Add(this.memoEdit1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(397, 204);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Solution";
            // 
            // comboBoxEditUnitTest
            // 
            this.comboBoxEditUnitTest.EditValue = "NUnitTest";
            this.comboBoxEditUnitTest.Location = new System.Drawing.Point(119, 167);
            this.comboBoxEditUnitTest.Name = "comboBoxEditUnitTest";
            this.comboBoxEditUnitTest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditUnitTest.Properties.Items.AddRange(new object[] {
            "NUnitTest",
            "MsTest"});
            this.comboBoxEditUnitTest.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditUnitTest.TabIndex = 4;
            // 
            // chkCompileSolution
            // 
            this.chkCompileSolution.EditValue = true;
            this.chkCompileSolution.Location = new System.Drawing.Point(15, 167);
            this.chkCompileSolution.Name = "chkCompileSolution";
            this.chkCompileSolution.Properties.Caption = "Compile Solution";
            this.chkCompileSolution.Size = new System.Drawing.Size(110, 19);
            this.chkCompileSolution.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(225, 163);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(306, 163);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(16, 23);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(365, 134);
            this.memoEdit1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.separatorControl1);
            this.groupControl2.Controls.Add(this.textEditKilledMutant);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.textEditAllMutant);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txtEditTestCaseCount);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 222);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(397, 176);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Statistic Information";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Location = new System.Drawing.Point(5, 137);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Mutant Score:";
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineColor = System.Drawing.Color.Black;
            this.separatorControl1.Location = new System.Drawing.Point(15, 108);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(353, 23);
            this.separatorControl1.TabIndex = 6;
            // 
            // textEditKilledMutant
            // 
            this.textEditKilledMutant.Enabled = false;
            this.textEditKilledMutant.Location = new System.Drawing.Point(105, 75);
            this.textEditKilledMutant.Name = "textEditKilledMutant";
            this.textEditKilledMutant.Size = new System.Drawing.Size(263, 20);
            this.textEditKilledMutant.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Killed Mutant Count:";
            // 
            // textEditAllMutant
            // 
            this.textEditAllMutant.Enabled = false;
            this.textEditAllMutant.Location = new System.Drawing.Point(105, 49);
            this.textEditAllMutant.Name = "textEditAllMutant";
            this.textEditAllMutant.Size = new System.Drawing.Size(263, 20);
            this.textEditAllMutant.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "All Mutants Count:";
            // 
            // txtEditTestCaseCount
            // 
            this.txtEditTestCaseCount.Enabled = false;
            this.txtEditTestCaseCount.Location = new System.Drawing.Point(105, 23);
            this.txtEditTestCaseCount.Name = "txtEditTestCaseCount";
            this.txtEditTestCaseCount.Size = new System.Drawing.Size(263, 20);
            this.txtEditTestCaseCount.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Test Case Count:";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnCheckAllObjectOperator);
            this.groupControl3.Controls.Add(this.btnCheckAllStandardOperator);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.checkedListBoxControlObjectOperator);
            this.groupControl3.Controls.Add(this.checkEditOffut);
            this.groupControl3.Controls.Add(this.checkedListBoxControlStandardOperator);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Location = new System.Drawing.Point(424, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(329, 293);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Mutant Operators";
            // 
            // btnCheckAllObjectOperator
            // 
            this.btnCheckAllObjectOperator.Location = new System.Drawing.Point(163, 254);
            this.btnCheckAllObjectOperator.Name = "btnCheckAllObjectOperator";
            this.btnCheckAllObjectOperator.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAllObjectOperator.TabIndex = 13;
            this.btnCheckAllObjectOperator.Text = "Check All";
            // 
            // btnCheckAllStandardOperator
            // 
            this.btnCheckAllStandardOperator.Location = new System.Drawing.Point(14, 254);
            this.btnCheckAllStandardOperator.Name = "btnCheckAllStandardOperator";
            this.btnCheckAllStandardOperator.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAllStandardOperator.TabIndex = 12;
            this.btnCheckAllStandardOperator.Text = "Check All";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(163, 24);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(77, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Object operator";
            // 
            // checkedListBoxControlObjectOperator
            // 
            this.checkedListBoxControlObjectOperator.CheckOnClick = true;
            this.checkedListBoxControlObjectOperator.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("DMC"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("EHR"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("EOA"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("EOC"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("EXS"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("IHD"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("IHI"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("IOD"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("IOK"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("IOP")});
            this.checkedListBoxControlObjectOperator.Location = new System.Drawing.Point(163, 44);
            this.checkedListBoxControlObjectOperator.Name = "checkedListBoxControlObjectOperator";
            this.checkedListBoxControlObjectOperator.Size = new System.Drawing.Size(143, 197);
            this.checkedListBoxControlObjectOperator.TabIndex = 10;
            // 
            // checkEditOffut
            // 
            this.checkEditOffut.Location = new System.Drawing.Point(14, 227);
            this.checkEditOffut.Name = "checkEditOffut";
            this.checkEditOffut.Properties.Caption = "Offut selective operators";
            this.checkEditOffut.Size = new System.Drawing.Size(153, 19);
            this.checkEditOffut.TabIndex = 4;
            // 
            // checkedListBoxControlStandardOperator
            // 
            this.checkedListBoxControlStandardOperator.CheckOnClick = true;
            this.checkedListBoxControlStandardOperator.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("ABS"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("AOR"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("ASR"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("LCR"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("LOR"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("ROR"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("UOI"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("UOR")});
            this.checkedListBoxControlStandardOperator.Location = new System.Drawing.Point(14, 44);
            this.checkedListBoxControlStandardOperator.Name = "checkedListBoxControlStandardOperator";
            this.checkedListBoxControlStandardOperator.Size = new System.Drawing.Size(133, 174);
            this.checkedListBoxControlStandardOperator.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 25);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Standard operator";
            // 
            // btnViewReport
            // 
            this.btnViewReport.Location = new System.Drawing.Point(678, 430);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(75, 23);
            this.btnViewReport.TabIndex = 14;
            this.btnViewReport.Text = "View Report";
            // 
            // btnShowMutant
            // 
            this.btnShowMutant.Location = new System.Drawing.Point(597, 430);
            this.btnShowMutant.Name = "btnShowMutant";
            this.btnShowMutant.Size = new System.Drawing.Size(75, 23);
            this.btnShowMutant.TabIndex = 15;
            this.btnShowMutant.Text = "Show Mutants";
            this.btnShowMutant.Click += new System.EventHandler(this.btnShowMutant_Click);
            // 
            // btnGenerateMutant
            // 
            this.btnGenerateMutant.Location = new System.Drawing.Point(490, 430);
            this.btnGenerateMutant.Name = "btnGenerateMutant";
            this.btnGenerateMutant.Size = new System.Drawing.Size(101, 23);
            this.btnGenerateMutant.TabIndex = 16;
            this.btnGenerateMutant.Text = "Generate Mutants";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(383, 430);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(101, 23);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "Run test";
            // 
            // XMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 464);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnGenerateMutant);
            this.Controls.Add(this.btnShowMutant);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.Name = "XMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mutant Testing - Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditUnitTest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCompileSolution.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKilledMutant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAllMutant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTestCaseCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControlObjectOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditOffut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControlStandardOperator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chkCompileSolution;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditKilledMutant;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditAllMutant;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtEditTestCaseCount;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControlStandardOperator;
        private DevExpress.XtraEditors.CheckEdit checkEditOffut;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControlObjectOperator;
        private DevExpress.XtraEditors.SimpleButton btnCheckAllObjectOperator;
        private DevExpress.XtraEditors.SimpleButton btnCheckAllStandardOperator;
        private DevExpress.XtraEditors.SimpleButton btnViewReport;
        private DevExpress.XtraEditors.SimpleButton btnShowMutant;
        private DevExpress.XtraEditors.SimpleButton btnGenerateMutant;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditUnitTest;
    }
}