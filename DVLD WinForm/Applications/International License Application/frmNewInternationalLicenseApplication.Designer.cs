namespace DVLD_WinForm.Applications.International_License_Application
{
    partial class frmNewInternationalLicenseApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlDriverLicensInfoWithFilter1 = new DVLD_WinForm.Licenses.Local_Licens.Controls.ctrlDriverLicensInfoWithFilter();
            this.gbApplicationInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblCreatedByUserID = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblLocalLicenseID = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblIntLicenseAppID = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.gbApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "International License Application ";
            // 
            // ctrlDriverLicensInfoWithFilter1
            // 
            this.ctrlDriverLicensInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicensInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicensInfoWithFilter1.Location = new System.Drawing.Point(14, 68);
            this.ctrlDriverLicensInfoWithFilter1.Name = "ctrlDriverLicensInfoWithFilter1";
            this.ctrlDriverLicensInfoWithFilter1.Size = new System.Drawing.Size(981, 466);
            this.ctrlDriverLicensInfoWithFilter1.TabIndex = 1;
            this.ctrlDriverLicensInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicensInfoWithFilter1_OnLicenseSelected);
            // 
            // gbApplicationInfo
            // 
            this.gbApplicationInfo.Controls.Add(this.pictureBox6);
            this.gbApplicationInfo.Controls.Add(this.pictureBox4);
            this.gbApplicationInfo.Controls.Add(this.lblCreatedByUserID);
            this.gbApplicationInfo.Controls.Add(this.pictureBox5);
            this.gbApplicationInfo.Controls.Add(this.label10);
            this.gbApplicationInfo.Controls.Add(this.lblExpirationDate);
            this.gbApplicationInfo.Controls.Add(this.label12);
            this.gbApplicationInfo.Controls.Add(this.lblLocalLicenseID);
            this.gbApplicationInfo.Controls.Add(this.pictureBox7);
            this.gbApplicationInfo.Controls.Add(this.label14);
            this.gbApplicationInfo.Controls.Add(this.lblIntLicenseAppID);
            this.gbApplicationInfo.Controls.Add(this.pictureBox8);
            this.gbApplicationInfo.Controls.Add(this.label16);
            this.gbApplicationInfo.Controls.Add(this.lblFees);
            this.gbApplicationInfo.Controls.Add(this.pictureBox3);
            this.gbApplicationInfo.Controls.Add(this.label6);
            this.gbApplicationInfo.Controls.Add(this.lblIssueDate);
            this.gbApplicationInfo.Controls.Add(this.label8);
            this.gbApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.gbApplicationInfo.Controls.Add(this.pictureBox2);
            this.gbApplicationInfo.Controls.Add(this.label4);
            this.gbApplicationInfo.Controls.Add(this.lblApplicationID);
            this.gbApplicationInfo.Controls.Add(this.pictureBox1);
            this.gbApplicationInfo.Controls.Add(this.label2);
            this.gbApplicationInfo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbApplicationInfo.Location = new System.Drawing.Point(14, 540);
            this.gbApplicationInfo.Name = "gbApplicationInfo";
            this.gbApplicationInfo.Size = new System.Drawing.Size(968, 200);
            this.gbApplicationInfo.TabIndex = 2;
            this.gbApplicationInfo.TabStop = false;
            this.gbApplicationInfo.Text = "Application Info";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD_WinForm.Properties.Resources.Calendar_32;
            this.pictureBox6.Location = new System.Drawing.Point(670, 105);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 23);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_WinForm.Properties.Resources.Calendar_32;
            this.pictureBox4.Location = new System.Drawing.Point(184, 105);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // lblCreatedByUserID
            // 
            this.lblCreatedByUserID.AutoSize = true;
            this.lblCreatedByUserID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblCreatedByUserID.Location = new System.Drawing.Point(713, 141);
            this.lblCreatedByUserID.Name = "lblCreatedByUserID";
            this.lblCreatedByUserID.Size = new System.Drawing.Size(37, 24);
            this.lblCreatedByUserID.TabIndex = 23;
            this.lblCreatedByUserID.Text = "???";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD_WinForm.Properties.Resources.Users_2_64;
            this.pictureBox5.Location = new System.Drawing.Point(670, 141);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.Location = new System.Drawing.Point(496, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Created By User :";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblExpirationDate.Location = new System.Drawing.Point(713, 103);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(37, 24);
            this.lblExpirationDate.TabIndex = 20;
            this.lblExpirationDate.Text = "???";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.Location = new System.Drawing.Point(502, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 24);
            this.label12.TabIndex = 18;
            this.label12.Text = "Expiration Date :";
            // 
            // lblLocalLicenseID
            // 
            this.lblLocalLicenseID.AutoSize = true;
            this.lblLocalLicenseID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblLocalLicenseID.Location = new System.Drawing.Point(713, 68);
            this.lblLocalLicenseID.Name = "lblLocalLicenseID";
            this.lblLocalLicenseID.Size = new System.Drawing.Size(37, 24);
            this.lblLocalLicenseID.TabIndex = 17;
            this.lblLocalLicenseID.Text = "???";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD_WinForm.Properties.Resources.Number_32;
            this.pictureBox7.Location = new System.Drawing.Point(670, 68);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 23);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label14.Location = new System.Drawing.Point(495, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 24);
            this.label14.TabIndex = 15;
            this.label14.Text = "Local License ID :";
            // 
            // lblIntLicenseAppID
            // 
            this.lblIntLicenseAppID.AutoSize = true;
            this.lblIntLicenseAppID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblIntLicenseAppID.Location = new System.Drawing.Point(713, 30);
            this.lblIntLicenseAppID.Name = "lblIntLicenseAppID";
            this.lblIntLicenseAppID.Size = new System.Drawing.Size(37, 24);
            this.lblIntLicenseAppID.TabIndex = 14;
            this.lblIntLicenseAppID.Text = "???";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD_WinForm.Properties.Resources.Number_32;
            this.pictureBox8.Location = new System.Drawing.Point(670, 30);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(28, 23);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label16.Location = new System.Drawing.Point(507, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(156, 24);
            this.label16.TabIndex = 12;
            this.label16.Text = " I.L.Application :";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblFees.Location = new System.Drawing.Point(227, 142);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(37, 24);
            this.lblFees.TabIndex = 11;
            this.lblFees.Text = "???";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_WinForm.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(184, 142);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(6, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fees :";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblIssueDate.Location = new System.Drawing.Point(227, 104);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(37, 24);
            this.lblIssueDate.TabIndex = 8;
            this.lblIssueDate.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(6, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Issue Date :";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicationDate.Location = new System.Drawing.Point(227, 69);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(37, 24);
            this.lblApplicationDate.TabIndex = 5;
            this.lblApplicationDate.Text = "???";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_WinForm.Properties.Resources.Calendar_32;
            this.pictureBox2.Location = new System.Drawing.Point(184, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Application Date :";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicationID.Location = new System.Drawing.Point(227, 31);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(37, 24);
            this.lblApplicationID.TabIndex = 2;
            this.lblApplicationID.Text = "???";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_WinForm.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(184, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "ApplicationID :";
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnIssue.Image = global::DVLD_WinForm.Properties.Resources.International_32;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssue.Location = new System.Drawing.Point(853, 787);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(113, 31);
            this.btnIssue.TabIndex = 3;
            this.btnIssue.Text = "Issue    ";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Image = global::DVLD_WinForm.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(714, 787);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 31);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close    ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.llShowLicenseInfo.Location = new System.Drawing.Point(21, 761);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(171, 24);
            this.llShowLicenseInfo.TabIndex = 5;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show License Info";
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // frmNewInternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 843);
            this.Controls.Add(this.llShowLicenseInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.gbApplicationInfo);
            this.Controls.Add(this.ctrlDriverLicensInfoWithFilter1);
            this.Controls.Add(this.label1);
            this.Name = "frmNewInternationalLicenseApplication";
            this.Text = "New International License";
            this.Load += new System.EventHandler(this.frmNewInternationalLicenseApplication_Load);
            this.gbApplicationInfo.ResumeLayout(false);
            this.gbApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Licenses.Local_Licens.Controls.ctrlDriverLicensInfoWithFilter ctrlDriverLicensInfoWithFilter1;
        private System.Windows.Forms.GroupBox gbApplicationInfo;
        private System.Windows.Forms.Label lblCreatedByUserID;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblLocalLicenseID;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblIntLicenseAppID;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
    }
}