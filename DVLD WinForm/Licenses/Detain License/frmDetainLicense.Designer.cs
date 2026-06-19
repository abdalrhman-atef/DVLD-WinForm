namespace DVLD_WinForm.Licenses.Detain_License
{
    partial class frmDetainLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlDriverLicensInfoWithFilter1 = new DVLD_WinForm.Licenses.Local_Licens.Controls.ctrlDriverLicensInfoWithFilter();
            this.gbDetainInfo = new System.Windows.Forms.GroupBox();
            this.txbFineFees = new System.Windows.Forms.TextBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDetainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detain License ";
            // 
            // ctrlDriverLicensInfoWithFilter1
            // 
            this.ctrlDriverLicensInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicensInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicensInfoWithFilter1.Location = new System.Drawing.Point(3, 53);
            this.ctrlDriverLicensInfoWithFilter1.Name = "ctrlDriverLicensInfoWithFilter1";
            this.ctrlDriverLicensInfoWithFilter1.Size = new System.Drawing.Size(981, 470);
            this.ctrlDriverLicensInfoWithFilter1.TabIndex = 1;
            this.ctrlDriverLicensInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicensInfoWithFilter1_OnLicenseSelected);
            // 
            // gbDetainInfo
            // 
            this.gbDetainInfo.Controls.Add(this.txbFineFees);
            this.gbDetainInfo.Controls.Add(this.lblCreatedBy);
            this.gbDetainInfo.Controls.Add(this.pictureBox4);
            this.gbDetainInfo.Controls.Add(this.label8);
            this.gbDetainInfo.Controls.Add(this.lblLicenseID);
            this.gbDetainInfo.Controls.Add(this.pictureBox5);
            this.gbDetainInfo.Controls.Add(this.label10);
            this.gbDetainInfo.Controls.Add(this.pictureBox3);
            this.gbDetainInfo.Controls.Add(this.label6);
            this.gbDetainInfo.Controls.Add(this.lblDetainDate);
            this.gbDetainInfo.Controls.Add(this.pictureBox2);
            this.gbDetainInfo.Controls.Add(this.label4);
            this.gbDetainInfo.Controls.Add(this.lblDetainID);
            this.gbDetainInfo.Controls.Add(this.pictureBox1);
            this.gbDetainInfo.Controls.Add(this.label2);
            this.gbDetainInfo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbDetainInfo.Location = new System.Drawing.Point(22, 529);
            this.gbDetainInfo.Name = "gbDetainInfo";
            this.gbDetainInfo.Size = new System.Drawing.Size(943, 177);
            this.gbDetainInfo.TabIndex = 2;
            this.gbDetainInfo.TabStop = false;
            this.gbDetainInfo.Text = "Detain Info";
            // 
            // txbFineFees
            // 
            this.txbFineFees.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txbFineFees.Location = new System.Drawing.Point(197, 124);
            this.txbFineFees.Name = "txbFineFees";
            this.txbFineFees.Size = new System.Drawing.Size(180, 28);
            this.txbFineFees.TabIndex = 15;
            this.txbFineFees.Validating += new System.ComponentModel.CancelEventHandler(this.txbFineFees_Validating);
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(553, 85);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(46, 24);
            this.lblCreatedBy.TabIndex = 14;
            this.lblCreatedBy.Text = "????";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_WinForm.Properties.Resources.User_32__2;
            this.pictureBox4.Location = new System.Drawing.Point(503, 85);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Created By :";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Location = new System.Drawing.Point(553, 46);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(46, 24);
            this.lblLicenseID.TabIndex = 11;
            this.lblLicenseID.Text = "????";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD_WinForm.Properties.Resources.Number_32;
            this.pictureBox5.Location = new System.Drawing.Point(503, 46);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "License ID :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_WinForm.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(143, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fine Fees :";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Location = new System.Drawing.Point(193, 85);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(46, 24);
            this.lblDetainDate.TabIndex = 5;
            this.lblDetainDate.Text = "????";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_WinForm.Properties.Resources.Calendar_321;
            this.pictureBox2.Location = new System.Drawing.Point(143, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Detain Date :";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Location = new System.Drawing.Point(193, 46);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(46, 24);
            this.lblDetainID.TabIndex = 2;
            this.lblDetainID.Text = "????";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_WinForm.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(143, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Detain ID :";
            // 
            // btnDetain
            // 
            this.btnDetain.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDetain.Image = global::DVLD_WinForm.Properties.Resources.Detain_32;
            this.btnDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetain.Location = new System.Drawing.Point(845, 722);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(102, 42);
            this.btnDetain.TabIndex = 3;
            this.btnDetain.Text = "Detain    ";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Image = global::DVLD_WinForm.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(718, 722);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 42);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close    ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.llShowLicenseInfo.Location = new System.Drawing.Point(29, 722);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(171, 24);
            this.llShowLicenseInfo.TabIndex = 5;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show License Info";
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 784);
            this.Controls.Add(this.llShowLicenseInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.gbDetainInfo);
            this.Controls.Add(this.ctrlDriverLicensInfoWithFilter1);
            this.Controls.Add(this.label1);
            this.Name = "frmDetainLicense";
            this.Text = "frmDetainLicense";
            this.Activated += new System.EventHandler(this.frmDetainLicense_Activated);
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            this.gbDetainInfo.ResumeLayout(false);
            this.gbDetainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Local_Licens.Controls.ctrlDriverLicensInfoWithFilter ctrlDriverLicensInfoWithFilter1;
        private System.Windows.Forms.GroupBox gbDetainInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbFineFees;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}