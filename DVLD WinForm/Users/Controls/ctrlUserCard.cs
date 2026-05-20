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

namespace DVLD_WinForm.Users
{
    public partial class ctrlUserCard : UserControl
    {
        private clsUsers _User;
        private int _UserID;

        public int UserID
        {
            get { return _UserID; }
        }

        public ctrlUserCard()
        {
            InitializeComponent();
        }

        private void _ResetDefaultInfo()
        {
            ctrlPersonCard1._ResetPersonInfo();
            lblUserNameValue.Text = "???";
            lblUserIDValue.Text = "???";
            lblIsActiveValue.Text = "???";

        }
        private void _FillUserInfo()
        {
            ctrlPersonCard1.LoadPersonInfo(_User._PersonID);
            lblUserNameValue.Text= _User._UserName.ToString();
            lblUserIDValue.Text=_User._UserID.ToString();
            if (_User._IsActive)
            {
                lblIsActiveValue.Text = "Yes";
            }
            else
            {
                lblIsActiveValue.Text = "No";
            }

        }
        public void LoadUserInfo(int UserID)
        {
            _UserID=UserID;
            _User= clsUsers.FindByUserID(_UserID);
            if (_User!=null)
            {
                _FillUserInfo();

            }
            else
            {
                _ResetDefaultInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


    }
}
