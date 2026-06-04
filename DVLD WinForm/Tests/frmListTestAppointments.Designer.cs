namespace DVLD_WinForm.Tests
{
    partial class frmListTestAppointments
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
            this.pbTestTypeImage = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlLocalDrivingApplicationInfo1 = new DVLD_WinForm.Applications.LocalDrivingLicenseApplication.ctrlLocalDrivingApplicationInfo();
            this.dgvTestAppointmentsList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointmentsList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTestTypeImage
            // 
            this.pbTestTypeImage.Image = global::DVLD_WinForm.Properties.Resources.Vision_5121;
            this.pbTestTypeImage.Location = new System.Drawing.Point(293, 3);
            this.pbTestTypeImage.Name = "pbTestTypeImage";
            this.pbTestTypeImage.Size = new System.Drawing.Size(148, 115);
            this.pbTestTypeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTestTypeImage.TabIndex = 0;
            this.pbTestTypeImage.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(278, 137);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Vision Test";
            // 
            // ctrlLocalDrivingApplicationInfo1
            // 
            this.ctrlLocalDrivingApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalDrivingApplicationInfo1.Location = new System.Drawing.Point(24, 185);
            this.ctrlLocalDrivingApplicationInfo1.Name = "ctrlLocalDrivingApplicationInfo1";
            this.ctrlLocalDrivingApplicationInfo1.Size = new System.Drawing.Size(748, 425);
            this.ctrlLocalDrivingApplicationInfo1.TabIndex = 2;
            // 
            // dgvTestAppointmentsList
            // 
            this.dgvTestAppointmentsList.AllowUserToAddRows = false;
            this.dgvTestAppointmentsList.AllowUserToDeleteRows = false;
            this.dgvTestAppointmentsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestAppointmentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestAppointmentsList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTestAppointmentsList.Location = new System.Drawing.Point(24, 662);
            this.dgvTestAppointmentsList.Name = "dgvTestAppointmentsList";
            this.dgvTestAppointmentsList.ReadOnly = true;
            this.dgvTestAppointmentsList.RowHeadersWidth = 51;
            this.dgvTestAppointmentsList.RowTemplate.Height = 26;
            this.dgvTestAppointmentsList.Size = new System.Drawing.Size(727, 150);
            this.dgvTestAppointmentsList.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(227, 108);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_WinForm.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Appointments :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 827);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Records :";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(141, 827);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(65, 24);
            this.lblRecordsCount.TabIndex = 6;
            this.lblRecordsCount.Text = "?????";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Image = global::DVLD_WinForm.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(609, 827);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 32);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close   ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddAppointment.Image = global::DVLD_WinForm.Properties.Resources.AddAppointment_32;
            this.btnAddAppointment.Location = new System.Drawing.Point(693, 596);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(45, 48);
            this.btnAddAppointment.TabIndex = 8;
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD_WinForm.Properties.Resources.Test_32;
            this.takeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // frmListTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 865);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTestAppointmentsList);
            this.Controls.Add(this.ctrlLocalDrivingApplicationInfo1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbTestTypeImage);
            this.Name = "frmListTestAppointments";
            this.Text = "frmListTestAppointments";
            this.Load += new System.EventHandler(this.frmListTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointmentsList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTestTypeImage;
        private System.Windows.Forms.Label lblTitle;
        private Applications.LocalDrivingLicenseApplication.ctrlLocalDrivingApplicationInfo ctrlLocalDrivingApplicationInfo1;
        private System.Windows.Forms.DataGridView dgvTestAppointmentsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}