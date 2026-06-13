namespace DVLD_WinForm.Applications.Replace_Lost_Or_Damage_License
{
    partial class frmReplaceLostOrDamageLicense
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlDriverLicensInfoWithFilter1 = new DVLD_WinForm.Licenses.Local_Licens.Controls.ctrlDriverLicensInfoWithFilter();
            this.gbReplacementFor = new System.Windows.Forms.GroupBox();
            this.rbLost = new System.Windows.Forms.RadioButton();
            this.rbDamage = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNewLicenseID = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLostOrDamageApplicationID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIssueReplacement = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.gbReplacementFor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(344, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(335, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "License Replacement";
            // 
            // ctrlDriverLicensInfoWithFilter1
            // 
            this.ctrlDriverLicensInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicensInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicensInfoWithFilter1.Location = new System.Drawing.Point(12, 87);
            this.ctrlDriverLicensInfoWithFilter1.Name = "ctrlDriverLicensInfoWithFilter1";
            this.ctrlDriverLicensInfoWithFilter1.Size = new System.Drawing.Size(981, 531);
            this.ctrlDriverLicensInfoWithFilter1.TabIndex = 1;
            this.ctrlDriverLicensInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicensInfoWithFilter1_OnLicenseSelected);
            // 
            // gbReplacementFor
            // 
            this.gbReplacementFor.Controls.Add(this.rbLost);
            this.gbReplacementFor.Controls.Add(this.rbDamage);
            this.gbReplacementFor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbReplacementFor.Location = new System.Drawing.Point(488, 87);
            this.gbReplacementFor.Name = "gbReplacementFor";
            this.gbReplacementFor.Size = new System.Drawing.Size(483, 100);
            this.gbReplacementFor.TabIndex = 2;
            this.gbReplacementFor.TabStop = false;
            this.gbReplacementFor.Text = "Replacement For :";
            // 
            // rbLost
            // 
            this.rbLost.AutoSize = true;
            this.rbLost.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rbLost.Location = new System.Drawing.Point(215, 31);
            this.rbLost.Name = "rbLost";
            this.rbLost.Size = new System.Drawing.Size(152, 28);
            this.rbLost.TabIndex = 1;
            this.rbLost.TabStop = true;
            this.rbLost.Text = "Lost License .";
            this.rbLost.UseVisualStyleBackColor = true;
            this.rbLost.CheckedChanged += new System.EventHandler(this.rbLost_CheckedChanged);
            // 
            // rbDamage
            // 
            this.rbDamage.AutoSize = true;
            this.rbDamage.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rbDamage.Location = new System.Drawing.Point(6, 31);
            this.rbDamage.Name = "rbDamage";
            this.rbDamage.Size = new System.Drawing.Size(190, 28);
            this.rbDamage.TabIndex = 0;
            this.rbDamage.TabStop = true;
            this.rbDamage.Text = "Damage License .";
            this.rbDamage.UseVisualStyleBackColor = true;
            this.rbDamage.CheckedChanged += new System.EventHandler(this.rbDamage_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCreatedBy);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblOldLicenseID);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblNewLicenseID);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblApplicationFees);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblApplicationDate);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblLostOrDamageApplicationID);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 570);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 176);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacement Application Info";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(636, 133);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(46, 24);
            this.lblCreatedBy.TabIndex = 17;
            this.lblCreatedBy.Text = "????";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_WinForm.Properties.Resources.User_32__2;
            this.pictureBox4.Location = new System.Drawing.Point(587, 136);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Created By :";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Location = new System.Drawing.Point(636, 95);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(46, 24);
            this.lblOldLicenseID.TabIndex = 14;
            this.lblOldLicenseID.Text = "????";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD_WinForm.Properties.Resources.Number_32;
            this.pictureBox5.Location = new System.Drawing.Point(587, 98);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 21);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(429, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "Old License ID :";
            // 
            // lblNewLicenseID
            // 
            this.lblNewLicenseID.AutoSize = true;
            this.lblNewLicenseID.Location = new System.Drawing.Point(636, 51);
            this.lblNewLicenseID.Name = "lblNewLicenseID";
            this.lblNewLicenseID.Size = new System.Drawing.Size(46, 24);
            this.lblNewLicenseID.TabIndex = 11;
            this.lblNewLicenseID.Text = "????";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD_WinForm.Properties.Resources.Number_32;
            this.pictureBox6.Location = new System.Drawing.Point(587, 54);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 21);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(420, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 24);
            this.label13.TabIndex = 9;
            this.label13.Text = "New License ID :";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Location = new System.Drawing.Point(179, 130);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(46, 24);
            this.lblApplicationFees.TabIndex = 8;
            this.lblApplicationFees.Text = "????";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_WinForm.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(130, 133);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "App Fees :";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Location = new System.Drawing.Point(179, 92);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(46, 24);
            this.lblApplicationDate.TabIndex = 5;
            this.lblApplicationDate.Text = "????";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_WinForm.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(130, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "App Date :";
            // 
            // lblLostOrDamageApplicationID
            // 
            this.lblLostOrDamageApplicationID.AutoSize = true;
            this.lblLostOrDamageApplicationID.Location = new System.Drawing.Point(179, 51);
            this.lblLostOrDamageApplicationID.Name = "lblLostOrDamageApplicationID";
            this.lblLostOrDamageApplicationID.Size = new System.Drawing.Size(46, 24);
            this.lblLostOrDamageApplicationID.TabIndex = 2;
            this.lblLostOrDamageApplicationID.Text = "????";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_WinForm.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(130, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "L.R.App.ID :";
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnIssueReplacement.Image = global::DVLD_WinForm.Properties.Resources.Renew_Driving_License_32;
            this.btnIssueReplacement.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssueReplacement.Location = new System.Drawing.Point(853, 767);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.Size = new System.Drawing.Size(109, 37);
            this.btnIssueReplacement.TabIndex = 4;
            this.btnIssueReplacement.Text = "Issue         ";
            this.btnIssueReplacement.UseVisualStyleBackColor = true;
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacment_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Image = global::DVLD_WinForm.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(703, 767);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 37);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close        ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.llShowLicenseInfo.Location = new System.Drawing.Point(18, 767);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(171, 24);
            this.llShowLicenseInfo.TabIndex = 6;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show License Info";
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // frmReplaceLostOrDamageLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 819);
            this.Controls.Add(this.llShowLicenseInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbReplacementFor);
            this.Controls.Add(this.ctrlDriverLicensInfoWithFilter1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmReplaceLostOrDamageLicense";
            this.Text = "Replace Lost Or Damage License";
            this.Activated += new System.EventHandler(this.frmReplaceLostOrDamageLicense_Activated);
            this.Load += new System.EventHandler(this.frmReplaceLostOrDamageLicense_Load);
            this.gbReplacementFor.ResumeLayout(false);
            this.gbReplacementFor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Licenses.Local_Licens.Controls.ctrlDriverLicensInfoWithFilter ctrlDriverLicensInfoWithFilter1;
        private System.Windows.Forms.GroupBox gbReplacementFor;
        private System.Windows.Forms.RadioButton rbLost;
        private System.Windows.Forms.RadioButton rbDamage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNewLicenseID;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLostOrDamageApplicationID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIssueReplacement;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
    }
}