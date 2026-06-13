using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_WinForm.Licenses.Intrnational_Linss
{
    public partial class frmShowInternationalLicenseInfo : Form
    {
        int _InternationalLicenseId;
        public frmShowInternationalLicenseInfo(int internationalLicenseId)
        {
            InitializeComponent();
            _InternationalLicenseId = internationalLicenseId;
        }

        private void frmShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlDriverInternationalLicenseInfo1.LoadInfo(_InternationalLicenseId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
