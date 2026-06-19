namespace DVLD_WinForm.Licenses.Controls
{
    partial class ctrlDriverLicenses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcDriverLicenses = new System.Windows.Forms.TabControl();
            this.tpLocalLicenses = new System.Windows.Forms.TabPage();
            this.lblLocalRecordsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.dgvLocalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.LocalMenuStripe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpInternationalLicenses = new System.Windows.Forms.TabPage();
            this.lblInternationalRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInternationalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InternationalToolMenueStripe = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tcDriverLicenses.SuspendLayout();
            this.tpLocalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).BeginInit();
            this.LocalMenuStripe.SuspendLayout();
            this.tpInternationalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensesHistory)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tcDriverLicenses);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(3, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver License";
            // 
            // tcDriverLicenses
            // 
            this.tcDriverLicenses.Controls.Add(this.tpLocalLicenses);
            this.tcDriverLicenses.Controls.Add(this.tpInternationalLicenses);
            this.tcDriverLicenses.Location = new System.Drawing.Point(6, 45);
            this.tcDriverLicenses.Name = "tcDriverLicenses";
            this.tcDriverLicenses.SelectedIndex = 0;
            this.tcDriverLicenses.Size = new System.Drawing.Size(960, 309);
            this.tcDriverLicenses.TabIndex = 0;
            // 
            // tpLocalLicenses
            // 
            this.tpLocalLicenses.Controls.Add(this.lblLocalRecordsCount);
            this.tpLocalLicenses.Controls.Add(this.label3);
            this.tpLocalLicenses.Controls.Add(this.lblLocal);
            this.tpLocalLicenses.Controls.Add(this.dgvLocalLicensesHistory);
            this.tpLocalLicenses.Location = new System.Drawing.Point(4, 33);
            this.tpLocalLicenses.Name = "tpLocalLicenses";
            this.tpLocalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocalLicenses.Size = new System.Drawing.Size(952, 272);
            this.tpLocalLicenses.TabIndex = 0;
            this.tpLocalLicenses.Text = "Local ";
            this.tpLocalLicenses.UseVisualStyleBackColor = true;
            // 
            // lblLocalRecordsCount
            // 
            this.lblLocalRecordsCount.AutoSize = true;
            this.lblLocalRecordsCount.Location = new System.Drawing.Point(105, 201);
            this.lblLocalRecordsCount.Name = "lblLocalRecordsCount";
            this.lblLocalRecordsCount.Size = new System.Drawing.Size(37, 24);
            this.lblLocalRecordsCount.TabIndex = 3;
            this.lblLocalRecordsCount.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Records :";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(6, 11);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(206, 24);
            this.lblLocal.TabIndex = 1;
            this.lblLocal.Text = "Local Licenses History";
            // 
            // dgvLocalLicensesHistory
            // 
            this.dgvLocalLicensesHistory.AllowUserToAddRows = false;
            this.dgvLocalLicensesHistory.AllowUserToDeleteRows = false;
            this.dgvLocalLicensesHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicensesHistory.ContextMenuStrip = this.LocalMenuStripe;
            this.dgvLocalLicensesHistory.Location = new System.Drawing.Point(0, 38);
            this.dgvLocalLicensesHistory.Name = "dgvLocalLicensesHistory";
            this.dgvLocalLicensesHistory.ReadOnly = true;
            this.dgvLocalLicensesHistory.RowHeadersWidth = 51;
            this.dgvLocalLicensesHistory.RowTemplate.Height = 26;
            this.dgvLocalLicensesHistory.Size = new System.Drawing.Size(940, 150);
            this.dgvLocalLicensesHistory.TabIndex = 0;
            // 
            // LocalMenuStripe
            // 
            this.LocalMenuStripe.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.LocalMenuStripe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.LocalMenuStripe.Name = "contextMenuStrip1";
            this.LocalMenuStripe.Size = new System.Drawing.Size(213, 42);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = global::DVLD_WinForm.Properties.Resources.License_View_32;
            this.showLicenseInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(212, 38);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // tpInternationalLicenses
            // 
            this.tpInternationalLicenses.Controls.Add(this.lblInternationalRecordsCount);
            this.tpInternationalLicenses.Controls.Add(this.label2);
            this.tpInternationalLicenses.Controls.Add(this.label1);
            this.tpInternationalLicenses.Controls.Add(this.dgvInternationalLicensesHistory);
            this.tpInternationalLicenses.Location = new System.Drawing.Point(4, 33);
            this.tpInternationalLicenses.Name = "tpInternationalLicenses";
            this.tpInternationalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternationalLicenses.Size = new System.Drawing.Size(952, 272);
            this.tpInternationalLicenses.TabIndex = 1;
            this.tpInternationalLicenses.Text = "International ";
            this.tpInternationalLicenses.UseVisualStyleBackColor = true;
            // 
            // lblInternationalRecordsCount
            // 
            this.lblInternationalRecordsCount.AutoSize = true;
            this.lblInternationalRecordsCount.Location = new System.Drawing.Point(105, 203);
            this.lblInternationalRecordsCount.Name = "lblInternationalRecordsCount";
            this.lblInternationalRecordsCount.Size = new System.Drawing.Size(37, 24);
            this.lblInternationalRecordsCount.TabIndex = 3;
            this.lblInternationalRecordsCount.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Records :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "International Licenses History";
            // 
            // dgvInternationalLicensesHistory
            // 
            this.dgvInternationalLicensesHistory.AllowUserToAddRows = false;
            this.dgvInternationalLicensesHistory.AllowUserToDeleteRows = false;
            this.dgvInternationalLicensesHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternationalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicensesHistory.ContextMenuStrip = this.contextMenuStrip2;
            this.dgvInternationalLicensesHistory.Location = new System.Drawing.Point(6, 35);
            this.dgvInternationalLicensesHistory.Name = "dgvInternationalLicensesHistory";
            this.dgvInternationalLicensesHistory.ReadOnly = true;
            this.dgvInternationalLicensesHistory.RowHeadersWidth = 51;
            this.dgvInternationalLicensesHistory.RowTemplate.Height = 26;
            this.dgvInternationalLicensesHistory.Size = new System.Drawing.Size(940, 165);
            this.dgvInternationalLicensesHistory.TabIndex = 0;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InternationalToolMenueStripe});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(213, 42);
            // 
            // InternationalToolMenueStripe
            // 
            this.InternationalToolMenueStripe.Image = global::DVLD_WinForm.Properties.Resources.License_View_32;
            this.InternationalToolMenueStripe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InternationalToolMenueStripe.Name = "InternationalToolMenueStripe";
            this.InternationalToolMenueStripe.Size = new System.Drawing.Size(212, 38);
            this.InternationalToolMenueStripe.Text = "Show License Info";
            this.InternationalToolMenueStripe.Click += new System.EventHandler(this.InternationalToolMenueStripe_Click);
            // 
            // ctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlDriverLicenses";
            this.Size = new System.Drawing.Size(991, 347);
            this.groupBox1.ResumeLayout(false);
            this.tcDriverLicenses.ResumeLayout(false);
            this.tpLocalLicenses.ResumeLayout(false);
            this.tpLocalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).EndInit();
            this.LocalMenuStripe.ResumeLayout(false);
            this.tpInternationalLicenses.ResumeLayout(false);
            this.tpInternationalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensesHistory)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tcDriverLicenses;
        private System.Windows.Forms.TabPage tpLocalLicenses;
        private System.Windows.Forms.TabPage tpInternationalLicenses;
        private System.Windows.Forms.DataGridView dgvInternationalLicensesHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLocalRecordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.DataGridView dgvLocalLicensesHistory;
        private System.Windows.Forms.Label lblInternationalRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip LocalMenuStripe;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem InternationalToolMenueStripe;
    }
}
