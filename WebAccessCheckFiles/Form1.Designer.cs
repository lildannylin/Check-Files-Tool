namespace WebAccessCheckFiles
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroButtonTest = new MetroFramework.Controls.MetroButton();
            this.metroButtonImport = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBoxStandard = new System.Windows.Forms.ListBox();
            this.listBoxLocal = new System.Windows.Forms.ListBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroButtonDetect = new MetroFramework.Controls.MetroButton();
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.metroLabelTitle = new MetroFramework.Controls.MetroLabel();
            this.metroButtonExport = new MetroFramework.Controls.MetroButton();
            this.metroLabelDismatch = new MetroFramework.Controls.MetroLabel();
            this.metroLabelMiss = new MetroFramework.Controls.MetroLabel();
            this.metroLabelMatch = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDismatchNumber = new MetroFramework.Controls.MetroLabel();
            this.metroLabelMissNumber = new MetroFramework.Controls.MetroLabel();
            this.metroLabelMatchNumber = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBoxDll = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxExe = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxAll = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButtonTest
            // 
            this.metroButtonTest.Location = new System.Drawing.Point(17, 461);
            this.metroButtonTest.Margin = new System.Windows.Forms.Padding(2);
            this.metroButtonTest.Name = "metroButtonTest";
            this.metroButtonTest.Size = new System.Drawing.Size(104, 34);
            this.metroButtonTest.TabIndex = 0;
            this.metroButtonTest.Text = "Compare";
            this.metroButtonTest.UseSelectable = true;
            this.metroButtonTest.Click += new System.EventHandler(this.metroButtonTest_Click);
            // 
            // metroButtonImport
            // 
            this.metroButtonImport.Location = new System.Drawing.Point(887, 73);
            this.metroButtonImport.Margin = new System.Windows.Forms.Padding(2);
            this.metroButtonImport.Name = "metroButtonImport";
            this.metroButtonImport.Size = new System.Drawing.Size(74, 24);
            this.metroButtonImport.TabIndex = 1;
            this.metroButtonImport.Text = "Import";
            this.metroButtonImport.UseSelectable = true;
            this.metroButtonImport.Click += new System.EventHandler(this.metroButtonBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBoxStandard
            // 
            this.listBoxStandard.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBoxStandard.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxStandard.FormattingEnabled = true;
            this.listBoxStandard.ItemHeight = 15;
            this.listBoxStandard.Location = new System.Drawing.Point(502, 102);
            this.listBoxStandard.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxStandard.Name = "listBoxStandard";
            this.listBoxStandard.Size = new System.Drawing.Size(459, 304);
            this.listBoxStandard.TabIndex = 2;
            this.listBoxStandard.SelectedIndexChanged += new System.EventHandler(this.listBoxStandard_SelectedIndexChanged);
            // 
            // listBoxLocal
            // 
            this.listBoxLocal.FormattingEnabled = true;
            this.listBoxLocal.ItemHeight = 12;
            this.listBoxLocal.Location = new System.Drawing.Point(19, 102);
            this.listBoxLocal.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLocal.Name = "listBoxLocal";
            this.listBoxLocal.Size = new System.Drawing.Size(461, 304);
            this.listBoxLocal.TabIndex = 3;
            this.listBoxLocal.SelectedIndexChanged += new System.EventHandler(this.listBoxLocal_SelectedIndexChanged);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(138, 461);
            this.metroProgressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(823, 34);
            this.metroProgressBar1.TabIndex = 4;
            // 
            // metroButtonDetect
            // 
            this.metroButtonDetect.Location = new System.Drawing.Point(297, 73);
            this.metroButtonDetect.Margin = new System.Windows.Forms.Padding(2);
            this.metroButtonDetect.Name = "metroButtonDetect";
            this.metroButtonDetect.Size = new System.Drawing.Size(74, 24);
            this.metroButtonDetect.TabIndex = 5;
            this.metroButtonDetect.Text = "Detect";
            this.metroButtonDetect.UseSelectable = true;
            this.metroButtonDetect.Click += new System.EventHandler(this.metroButtonInit_Click);
            // 
            // pictureBoxTitle
            // 
            this.pictureBoxTitle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTitle.Image")));
            this.pictureBoxTitle.InitialImage = null;
            this.pictureBoxTitle.Location = new System.Drawing.Point(17, 10);
            this.pictureBoxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(113, 45);
            this.pictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTitle.TabIndex = 6;
            this.pictureBoxTitle.TabStop = false;
            // 
            // metroLabelTitle
            // 
            this.metroLabelTitle.AutoSize = true;
            this.metroLabelTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelTitle.Location = new System.Drawing.Point(128, 20);
            this.metroLabelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabelTitle.Name = "metroLabelTitle";
            this.metroLabelTitle.Size = new System.Drawing.Size(112, 25);
            this.metroLabelTitle.TabIndex = 7;
            this.metroLabelTitle.Text = "File Compare";
            // 
            // metroButtonExport
            // 
            this.metroButtonExport.Location = new System.Drawing.Point(406, 73);
            this.metroButtonExport.Margin = new System.Windows.Forms.Padding(2);
            this.metroButtonExport.Name = "metroButtonExport";
            this.metroButtonExport.Size = new System.Drawing.Size(74, 24);
            this.metroButtonExport.TabIndex = 8;
            this.metroButtonExport.Text = "Export";
            this.metroButtonExport.UseSelectable = true;
            this.metroButtonExport.Click += new System.EventHandler(this.metroButtonExport_Click);
            // 
            // metroLabelDismatch
            // 
            this.metroLabelDismatch.AutoSize = true;
            this.metroLabelDismatch.Location = new System.Drawing.Point(743, 425);
            this.metroLabelDismatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabelDismatch.Name = "metroLabelDismatch";
            this.metroLabelDismatch.Size = new System.Drawing.Size(65, 19);
            this.metroLabelDismatch.TabIndex = 9;
            this.metroLabelDismatch.Text = "Dismatch:";
            // 
            // metroLabelMiss
            // 
            this.metroLabelMiss.AutoSize = true;
            this.metroLabelMiss.Location = new System.Drawing.Point(832, 425);
            this.metroLabelMiss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabelMiss.Name = "metroLabelMiss";
            this.metroLabelMiss.Size = new System.Drawing.Size(37, 19);
            this.metroLabelMiss.TabIndex = 10;
            this.metroLabelMiss.Text = "Miss:";
            // 
            // metroLabelMatch
            // 
            this.metroLabelMatch.AutoSize = true;
            this.metroLabelMatch.Location = new System.Drawing.Point(893, 425);
            this.metroLabelMatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabelMatch.Name = "metroLabelMatch";
            this.metroLabelMatch.Size = new System.Drawing.Size(48, 19);
            this.metroLabelMatch.TabIndex = 11;
            this.metroLabelMatch.Text = "Match:";
            // 
            // metroLabelDismatchNumber
            // 
            this.metroLabelDismatchNumber.AutoSize = true;
            this.metroLabelDismatchNumber.Location = new System.Drawing.Point(812, 425);
            this.metroLabelDismatchNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabelDismatchNumber.Name = "metroLabelDismatchNumber";
            this.metroLabelDismatchNumber.Size = new System.Drawing.Size(16, 19);
            this.metroLabelDismatchNumber.TabIndex = 12;
            this.metroLabelDismatchNumber.Text = "0";
            // 
            // metroLabelMissNumber
            // 
            this.metroLabelMissNumber.AutoSize = true;
            this.metroLabelMissNumber.Location = new System.Drawing.Point(873, 425);
            this.metroLabelMissNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabelMissNumber.Name = "metroLabelMissNumber";
            this.metroLabelMissNumber.Size = new System.Drawing.Size(16, 19);
            this.metroLabelMissNumber.TabIndex = 13;
            this.metroLabelMissNumber.Text = "0";
            // 
            // metroLabelMatchNumber
            // 
            this.metroLabelMatchNumber.AutoSize = true;
            this.metroLabelMatchNumber.Location = new System.Drawing.Point(945, 425);
            this.metroLabelMatchNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabelMatchNumber.Name = "metroLabelMatchNumber";
            this.metroLabelMatchNumber.Size = new System.Drawing.Size(16, 19);
            this.metroLabelMatchNumber.TabIndex = 14;
            this.metroLabelMatchNumber.Text = "0";
            // 
            // metroCheckBoxDll
            // 
            this.metroCheckBoxDll.AutoSize = true;
            this.metroCheckBoxDll.Location = new System.Drawing.Point(138, 78);
            this.metroCheckBoxDll.Margin = new System.Windows.Forms.Padding(2);
            this.metroCheckBoxDll.Name = "metroCheckBoxDll";
            this.metroCheckBoxDll.Size = new System.Drawing.Size(43, 15);
            this.metroCheckBoxDll.TabIndex = 15;
            this.metroCheckBoxDll.Text = "DLL";
            this.metroCheckBoxDll.UseSelectable = true;
            // 
            // metroCheckBoxExe
            // 
            this.metroCheckBoxExe.AutoSize = true;
            this.metroCheckBoxExe.Location = new System.Drawing.Point(79, 78);
            this.metroCheckBoxExe.Margin = new System.Windows.Forms.Padding(2);
            this.metroCheckBoxExe.Name = "metroCheckBoxExe";
            this.metroCheckBoxExe.Size = new System.Drawing.Size(42, 15);
            this.metroCheckBoxExe.TabIndex = 16;
            this.metroCheckBoxExe.Text = "EXE";
            this.metroCheckBoxExe.UseSelectable = true;
            // 
            // metroCheckBoxAll
            // 
            this.metroCheckBoxAll.AutoSize = true;
            this.metroCheckBoxAll.Location = new System.Drawing.Point(19, 78);
            this.metroCheckBoxAll.Margin = new System.Windows.Forms.Padding(2);
            this.metroCheckBoxAll.Name = "metroCheckBoxAll";
            this.metroCheckBoxAll.Size = new System.Drawing.Size(37, 15);
            this.metroCheckBoxAll.TabIndex = 17;
            this.metroCheckBoxAll.Text = "All";
            this.metroCheckBoxAll.UseSelectable = true;
            this.metroCheckBoxAll.CheckedChanged += new System.EventHandler(this.metroCheckBoxAll_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 552);
            this.Controls.Add(this.metroCheckBoxAll);
            this.Controls.Add(this.metroCheckBoxExe);
            this.Controls.Add(this.metroCheckBoxDll);
            this.Controls.Add(this.metroLabelMatchNumber);
            this.Controls.Add(this.metroLabelMissNumber);
            this.Controls.Add(this.metroLabelDismatchNumber);
            this.Controls.Add(this.metroLabelMatch);
            this.Controls.Add(this.metroLabelMiss);
            this.Controls.Add(this.metroLabelDismatch);
            this.Controls.Add(this.metroButtonExport);
            this.Controls.Add(this.metroLabelTitle);
            this.Controls.Add(this.pictureBoxTitle);
            this.Controls.Add(this.metroButtonDetect);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.listBoxLocal);
            this.Controls.Add(this.listBoxStandard);
            this.Controls.Add(this.metroButtonImport);
            this.Controls.Add(this.metroButtonTest);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButtonTest;
        private MetroFramework.Controls.MetroButton metroButtonImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBoxStandard;
        private System.Windows.Forms.ListBox listBoxLocal;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroButton metroButtonDetect;
        private System.Windows.Forms.PictureBox pictureBoxTitle;
        private MetroFramework.Controls.MetroLabel metroLabelTitle;
        private MetroFramework.Controls.MetroButton metroButtonExport;
        private MetroFramework.Controls.MetroLabel metroLabelDismatch;
        private MetroFramework.Controls.MetroLabel metroLabelMiss;
        private MetroFramework.Controls.MetroLabel metroLabelMatch;
        private MetroFramework.Controls.MetroLabel metroLabelDismatchNumber;
        private MetroFramework.Controls.MetroLabel metroLabelMissNumber;
        private MetroFramework.Controls.MetroLabel metroLabelMatchNumber;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxDll;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxExe;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxAll;
    }
}

