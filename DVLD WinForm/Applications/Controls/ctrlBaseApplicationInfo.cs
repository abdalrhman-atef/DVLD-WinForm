using DVLD_BusinessLayer;
using DVLD_WinForm.Global_classes;
using DVLD_WinForm.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_WinForm.Applications.Controls
{
    public partial class ctrlBaseApplicationInfo : UserControl
    {
        int _ApplicationID=-1;
        clsApplications _Application;
        public int ApplicationID
        {
            get { return _ApplicationID; }
        }
        public ctrlBaseApplicationInfo()
        {
            InitializeComponent();
           
        }
        public void ResetApplicationInfo()
        {
            _ApplicationID = -1;

            LblAppID.Text = "[????]";
            lblStatus.Text = "[????]";
            lblType.Text = "[????]";
            lblFees.Text = "[????]";
            lblApplicant.Text = "[????]";
            lblDate.Text = "[????]";
            lblLastStatusDate.Text = "[????]";
            lblCreatedBy.Text = "[????]";

        }
        private void FillApplicationInfo() 
        {
            _ApplicationID = _Application._ApplicationID;
            LblAppID.Text = _Application._ApplicationID.ToString();
            lblStatus.Text = _Application.StatusText;
            lblType.Text = _Application._ApplicationTypeInfo._ApplicationTitle;
            lblFees.Text = _Application._PaidFees.ToString();
            lblApplicant.Text = _Application.ApplicantFullName;
            lblDate.Text = clsFormat.DateToShort(_Application._AppDate);
            lblLastStatusDate.Text = clsFormat.DateToShort(_Application._LastStatusDate);
            lblCreatedBy.Text = _Application._CreatedByUserInfo._UserName;

        }
        public void _LoadApplicationInfo(int ApplicationID) 
        {
            _ApplicationID=ApplicationID;
              _Application = clsApplications.FindBaseApplicationByID( _ApplicationID );
            if (_Application==null)
            {

                ResetApplicationInfo();
                MessageBox.Show("No Application with ApplicationID = " + _ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                FillApplicationInfo();
            }



        }

        private void llPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonInfo frm = new frmPersonInfo(_Application._ApplicantPersonID);
            frm.ShowDialog();
            _LoadApplicationInfo(this._ApplicationID);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ctrlBaseApplicationInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
