namespace DVLD_WinForm.Licenses
{
    partial class frmShowPersonLicensesHistory
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
            this.ctrlDriverLicenses1 = new DVLD_WinForm.Licenses.Controls.ctrlDriverLicenses();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new DVLD_WinForm.People.Controls.ctrlPersonCardWithFilter();
            this.SuspendLayout();
            // 
            // ctrlDriverLicenses1
            // 
            this.ctrlDriverLicenses1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenses1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ctrlDriverLicenses1.Location = new System.Drawing.Point(12, 586);
            this.ctrlDriverLicenses1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
            this.ctrlDriverLicenses1.Size = new System.Drawing.Size(1104, 322);
            this.ctrlDriverLicenses1.TabIndex = 0;
            this.ctrlDriverLicenses1.Load += new System.EventHandler(this.ctrlDriverLicenses1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Driver Licenses History";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.Image = global::DVLD_WinForm.Properties.Resources.Close_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(899, 913);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close    ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(12, 65);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(1143, 506);
            this.ctrlPersonCardWithFilter1.TabIndex = 4;
            this.ctrlPersonCardWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonCardWithFilter1_OnPersonSelected);
            // 
            // frmShowPersonLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 1006);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlDriverLicenses1);
            this.Name = "frmShowPersonLicensesHistory";
            this.Text = "frmShowPersonLicensesHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlDriverLicenses ctrlDriverLicenses1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
    }
}