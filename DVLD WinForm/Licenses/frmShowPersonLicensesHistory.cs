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

namespace DVLD_WinForm.Licenses
{
    public partial class frmShowPersonLicensesHistory : Form
    {
      
        int _PersonID=-1;
        public frmShowPersonLicensesHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID=PersonID;
        }
        public frmShowPersonLicensesHistory()
        {
            InitializeComponent();
            
        }

        private void ctrlDriverLicenses1_Load(object sender, EventArgs e)
        {

            if (_PersonID != -1)
            {
                ctrlPersonCardWithFilter1.LoadPersonInfo(_PersonID);
                ctrlPersonCardWithFilter1.FilterEnabled = false;
                ctrlDriverLicenses1.LoadInfoByPersonID(_PersonID);
            }
            else
            {
                ctrlPersonCardWithFilter1.Enabled = true;
                ctrlPersonCardWithFilter1.FilterFocus();
            }

        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID=obj;
            if (_PersonID==-1)
            {
                ctrlDriverLicenses1.Clear();
            }
            else
            {
                ctrlDriverLicenses1.LoadInfoByPersonID(_PersonID);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
