namespace DVLD_WinForm.Tests.Test_Types
{
    partial class frmUpdateTestTypes
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblTestTypeIdValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTestTypeTitle = new System.Windows.Forms.TextBox();
            this.txbTestTypeFeees = new System.Windows.Forms.TextBox();
            this.txbTestTypeDescription = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(242, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Test Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(106, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test Type ID";
            // 
            // lblTestTypeIdValue
            // 
            this.lblTestTypeIdValue.AutoSize = true;
            this.lblTestTypeIdValue.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTestTypeIdValue.Location = new System.Drawing.Point(280, 116);
            this.lblTestTypeIdValue.Name = "lblTestTypeIdValue";
            this.lblTestTypeIdValue.Size = new System.Drawing.Size(28, 24);
            this.lblTestTypeIdValue.TabIndex = 2;
            this.lblTestTypeIdValue.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(87, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Test Type Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(86, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Test Type Fees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(27, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Test Type Description";
            // 
            // txbTestTypeTitle
            // 
            this.txbTestTypeTitle.Location = new System.Drawing.Point(284, 159);
            this.txbTestTypeTitle.Name = "txbTestTypeTitle";
            this.txbTestTypeTitle.Size = new System.Drawing.Size(192, 24);
            this.txbTestTypeTitle.TabIndex = 6;
            this.txbTestTypeTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txbTestTypeTitle_Validating);
            // 
            // txbTestTypeFeees
            // 
            this.txbTestTypeFeees.Location = new System.Drawing.Point(284, 202);
            this.txbTestTypeFeees.Name = "txbTestTypeFeees";
            this.txbTestTypeFeees.Size = new System.Drawing.Size(192, 24);
            this.txbTestTypeFeees.TabIndex = 7;
            this.txbTestTypeFeees.Validating += new System.ComponentModel.CancelEventHandler(this.txbTestTypeFeees_Validating);
            // 
            // txbTestTypeDescription
            // 
            this.txbTestTypeDescription.Location = new System.Drawing.Point(284, 245);
            this.txbTestTypeDescription.Multiline = true;
            this.txbTestTypeDescription.Name = "txbTestTypeDescription";
            this.txbTestTypeDescription.Size = new System.Drawing.Size(351, 69);
            this.txbTestTypeDescription.TabIndex = 8;
            this.txbTestTypeDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txbTestTypeDescription_Validating);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_WinForm.Properties.Resources.Notes_32;
            this.pictureBox3.Location = new System.Drawing.Point(248, 245);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_WinForm.Properties.Resources.money_32;
            this.pictureBox2.Location = new System.Drawing.Point(248, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_WinForm.Properties.Resources.Test_32;
            this.pictureBox1.Location = new System.Drawing.Point(248, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Image = global::DVLD_WinForm.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(665, 381);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 29);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close   ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSave.Image = global::DVLD_WinForm.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(537, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 29);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save   ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUpdateTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbTestTypeDescription);
            this.Controls.Add(this.txbTestTypeFeees);
            this.Controls.Add(this.txbTestTypeTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTestTypeIdValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateTestTypes";
            this.Text = "frmUpdateTestTypes";
            this.Load += new System.EventHandler(this.frmUpdateTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTestTypeIdValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbTestTypeTitle;
        private System.Windows.Forms.TextBox txbTestTypeFeees;
        private System.Windows.Forms.TextBox txbTestTypeDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}