namespace DVLD_WinForm.Tests.Controls
{
    partial class frmTakeTest
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
            this.ctrlScheduledTest1 = new DVLD_WinForm.Tests.Controls.ctrlScheduledTest();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbFail = new System.Windows.Forms.RadioButton();
            this.lblUserMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNotes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlScheduledTest1
            // 
            this.ctrlScheduledTest1.Location = new System.Drawing.Point(-3, 12);
            this.ctrlScheduledTest1.Name = "ctrlScheduledTest1";
            this.ctrlScheduledTest1.Size = new System.Drawing.Size(565, 547);
            this.ctrlScheduledTest1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result :";
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPass.Location = new System.Drawing.Point(191, 587);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(76, 28);
            this.rbPass.TabIndex = 2;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "Pass";
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_WinForm.Properties.Resources.Number_323;
            this.pictureBox1.Location = new System.Drawing.Point(146, 588);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFail.Location = new System.Drawing.Point(283, 587);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(67, 28);
            this.rbFail.TabIndex = 4;
            this.rbFail.TabStop = true;
            this.rbFail.Text = "Fail";
            this.rbFail.UseVisualStyleBackColor = true;
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.AutoSize = true;
            this.lblUserMessage.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserMessage.Location = new System.Drawing.Point(66, 546);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(382, 28);
            this.lblUserMessage.TabIndex = 5;
            this.lblUserMessage.Text = "You Can Not Change The Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 638);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Notes :";
            // 
            // txbNotes
            // 
            this.txbNotes.Location = new System.Drawing.Point(191, 638);
            this.txbNotes.Multiline = true;
            this.txbNotes.Name = "txbNotes";
            this.txbNotes.Size = new System.Drawing.Size(324, 51);
            this.txbNotes.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSave.Image = global::DVLD_WinForm.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(399, 711);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 37);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save   ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Image = global::DVLD_WinForm.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(272, 711);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 37);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close    ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_WinForm.Properties.Resources.Notes_32;
            this.pictureBox2.Location = new System.Drawing.Point(146, 638);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 776);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUserMessage);
            this.Controls.Add(this.rbFail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlScheduledTest1);
            this.Name = "frmTakeTest";
            this.Text = "frmTakeTest";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlScheduledTest ctrlScheduledTest1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.Label lblUserMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}