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
    public partial class frmLoadLocalDrivingLicenseAppInfo : Form
    {
        int _LocalDrivingLicenseAppID = -1;
        public frmLoadLocalDrivingLicenseAppInfo(int LocalDrivingLicenseAppID)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID=LocalDrivingLicenseAppID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLoadLocalDrivingLicenseAppInfo_Load(object sender, EventArgs e)
        {
            ctrlLocalDrivingApplicationInfo1._LoadInfoByLocalDrivingLicenseApplicationID(_LocalDrivingLicenseAppID);
        }
    }
}
