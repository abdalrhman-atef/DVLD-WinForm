using DVLD_BusinessLayer;
using DVLD_WinForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_WinForm.People
{
    public partial class ctrlPersonCard : UserControl
    {
        private int _PersonID = -1;
        private clsPeople _Person;
        public int PersonID
        {
            get { return _PersonID; }
        }
        public clsPeople SelectedPerson 
        {
            get { return _Person; }
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
           
        }


        public void _ResetPersonInfo() 
        {

            lblPersonID.Text = "[????]";
            lblFullName.Text = "[????]";
            lblNationalityNo.Text = "[????]";
            lblAddress.Text = "[????]";
            lblEmail.Text = "[????]";
            lblGender.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblPhone.Text = "[????]";
            lblCountry.Text = "[????]";
            picPersonImage.Image= Resources.Male_512;


        }
        private void _LoadPersonImage() 
        {

            if (_Person.Gender==0)
            {
                picPersonImage.Image = Resources.Male_512;
            }
            else
            {
                picPersonImage.Image = Resources.Female_512;
            }
            string PersonImage = _Person.ImagePath;
            if (PersonImage!="")
            {
                if (File.Exists(PersonImage))
                {
                    picPersonImage.ImageLocation = PersonImage;
                }
                else
                    MessageBox.Show("Could not find this image: = " + PersonImage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void _FillPersonInfo() 
        {
            llEditPersonInfo.Enabled = true;
            _PersonID = _Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblFullName.Text = _Person.FullName.ToString();
            lblNationalityNo.Text = _Person.NationalNo.ToString();
            lblAddress.Text = _Person.Address.ToString();
            lblEmail.Text = _Person.Email.ToString();
            if (_Person.Gender == 0)
            {
                lblGender.Text = "Male";
            }
            else
            {
                lblGender.Text = "Female";
            }
            lblDateOfBirth.Text = _Person.DateOfBirth.ToString();
            lblPhone.Text = _Person.Phone.ToString();
            lblCountry.Text = _Person.CountryInfo._CountryName;
            _LoadPersonImage();

        }
        public void LoadPersonInfo(int PersonID)
        {
            _Person=clsPeople.Find(PersonID);
            if (_Person==null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();

        }
        public void LoadPersonInfo(string  NationalNo)
        {
            _Person = clsPeople.Find(NationalNo);
            if (_Person == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();

        }
        private void ucShowPersonInfo_Load(object sender, EventArgs e)
        {
           

        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_Person.PersonID);
            frm.ShowDialog();

            
            LoadPersonInfo(_Person.PersonID);
        }
    }
}
