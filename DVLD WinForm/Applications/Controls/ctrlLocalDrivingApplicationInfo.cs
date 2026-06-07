using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_WinForm.Applications.LocalDrivingLicenseApplication
{
    public partial class ctrlLocalDrivingApplicationInfo : UserControl
    {
        int _LocalDrivingLicenseApplicationID = -1;
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        public int LocalDrivingLicenseApplicationID
        {
            get { return _LocalDrivingLicenseApplicationID; }
        }
        public ctrlLocalDrivingApplicationInfo()
        {
            InitializeComponent();
        }
        
        private void _ResetLocalDrivingLicenseApplicationInfo()
        {
            _LocalDrivingLicenseApplicationID = -1;
            ctrlBaseApplicationInfo1.ResetApplicationInfo();
            lblDrivingLicenseApplicationID.Text = "[????]";
            lblLicenseType.Text = "[????]";


        }

        public void _LoadInfoByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID) 
        {
            _LocalDrivingLicenseApplicationID= LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);
            if (_LocalDrivingLicenseApplication == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();


                MessageBox.Show("No Application with ApplicationID = " + LocalDrivingLicenseApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _FillLocalDrivingLicenseApplicationInfo();

            }


        }
        private void _FillLocalDrivingLicenseApplicationInfo()
        {


            lblDrivingLicenseApplicationID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseType.Text = clsLicenseClass.Find(_LocalDrivingLicenseApplication.LicenseClassID).ClassName;
            ctrlBaseApplicationInfo1._LoadApplicationInfo(_LocalDrivingLicenseApplication._ApplicationID);
            lblPassedTests.Text = _LocalDrivingLicenseApplication.GetPassedTestCount().ToString() + "/3";
        }

        public void _LoadInfoByApplicationID(int ApplicationID)
        {
            
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindLocalDrivingAppLicenseByApplicationID(ApplicationID);
            if (_LocalDrivingLicenseApplication == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();


                MessageBox.Show("No Application with ApplicationID = " + ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLocalDrivingLicenseApplicationInfo();


        }


    }
}
