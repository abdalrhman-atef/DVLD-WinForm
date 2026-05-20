using DVLD_BusinessLayer;
using DVLD_WinForm.Global_classes;
using DVLD_WinForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Runtime.ConstrainedExecution;


namespace DVLD_WinForm.People
{
    public partial class frmAddUpdatePerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;
        public enum _enMode { AddNew=0,Update=1}
        public enum _enGender { Male = 0, Female = 1 }

        private _enMode _Mode;
        
        public clsPeople _Person;
        private int _PersonID = -1;
        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = _enMode.AddNew;
         
        }
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _Mode = _enMode.Update;
            _PersonID = PersonID;
            _Person= clsPeople.Find(_PersonID);
        }
        private void _FillCountriesInCompoBox() 
        {
        DataTable dtCountries=clsCountries.GetAllCountries();
            foreach (DataRow Row in dtCountries.Rows)
            {
                cbCountries.Items.Add(Row["CountryName"]);
            }


        }
        private void GenderChecked() 
        {

            if (rbMale.Checked)
            {
                picbImagePath.Image = Resources.Male_512;
            }
            else
            {
                picbImagePath.Image = Resources.Female_512;
            }


        }
        private void _ResetDefaultValue() 
        {
            _FillCountriesInCompoBox();

            if (_Mode==_enMode.AddNew)
            {
                lblAddUpdatePerson.Text = "Add New Person";
                _Person = new clsPeople();

            }
            else
            {
                lblAddUpdatePerson.Text = "Update Person";
               

            }
            if (rbMale.Checked)
                picbImagePath.Image = Resources.Male_512;
            else
                picbImagePath.Image = Resources.Female_512;

            llRemove.Visible=(picbImagePath.ImageLocation!=null);
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            cbCountries.SelectedIndex = cbCountries.FindString("Egypt");
            txbFirstName.Text = "";
            txbSecondName.Text = "";
            txbThirdName.Text = "";
            txbLastName.Text = "";
            txbNationalNo.Text = "";
            rbMale.Checked = true;
            txbPhone.Text = "";
            txbEmail.Text = "";
            txbAddress.Text = "";

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void LoadPersonInfo()
        {
            _Person = clsPeople.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblPersonIDCounter.Text = _PersonID.ToString();
            txbFirstName.Text = _Person.FirstName.ToString();
            txbSecondName.Text = _Person.SecondName.ToString();
            txbThirdName.Text = _Person.ThirdName.ToString();
            txbLastName.Text = _Person.LastName.ToString();
            txbNationalNo.Text = _Person.NationalNo.ToString();
            txbPhone.Text = _Person.Phone.ToString();
            txbAddress.Text = _Person.Address.ToString();
            txbEmail.Text = _Person.Email.ToString();
            cbCountries.SelectedIndex = cbCountries.FindString(_Person.CountryInfo._CountryName);
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            if (_Person.Gender == 0)
            {
               
                rbMale.Checked = true;
                rbFemale.Checked = false;
            }
            else
            {
                
                rbFemale.Checked = true;
                rbMale.Checked = false;


            }
            if (_Person.ImagePath != "")
            {
                picbImagePath.ImageLocation = _Person.ImagePath;
            }

            llRemove.Visible = (_Person.ImagePath != "");

        }
        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
            if (_Mode==_enMode.Update)
            {
                LoadPersonInfo();
            }
        }
        private void picbImagePath_Click(object sender, EventArgs e)
        {
           
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            GenderChecked();
        }
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            GenderChecked();
        }
        private bool HandlePersonImage()
        {
            if (_Person.ImagePath != "" && picbImagePath.ImageLocation == null)
            {
                try
                {
                    File.Delete(_Person.ImagePath);
                }
                catch (IOException)
                {
                    // We could not delete the file.
                    //log it later   
                }

            }
            if (_Person.ImagePath != picbImagePath.ImageLocation)
            {

                if (_Person.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (picbImagePath.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = picbImagePath.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        picbImagePath.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }

            return true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (!HandlePersonImage())
            {
                return;

            }
            int NationalityCountryID = clsCountries.FindCountry(cbCountries.Text)._CountryID;
            _Person.FirstName = txbFirstName.Text.Trim();
            _Person.SecondName = txbSecondName.Text.Trim();
            _Person.ThirdName = txbThirdName.Text.Trim();
            _Person.LastName = txbLastName.Text.Trim();
            _Person.NationalityCountryID = NationalityCountryID;
            _Person.NationalNo = txbNationalNo.Text.Trim();
            _Person.Address = txbAddress.Text.Trim();
            _Person.Email= txbEmail.Text.Trim();
            _Person.Phone = txbPhone.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            if (rbMale.Checked)
            {
                _Person.Gender = (short)_enGender.Male;
            }
            else
            {
                _Person.Gender = (short)_enGender.Female;
            }
            if (picbImagePath.ImageLocation != null)
                _Person.ImagePath = picbImagePath.ImageLocation;
            else

                _Person.ImagePath = "";
            if (_Person.Save())
            {
                _Mode = _enMode.Update;
                lblAddUpdatePerson.Text = "Update Person";
                lblPersonIDCounter.Text =_Person.PersonID.ToString();
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Person.PersonID);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (txbEmail.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidation.ValidateEmail(txbEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txbEmail, null);
            }
            ;

        }
        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txbNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbNationalNo, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txbNationalNo, null);
            }

            //Make sure the national number is not used by another person
            if (txbNationalNo.Text.Trim() != _Person.NationalNo && clsPeople.IsPersonExist(txbNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbNationalNo, "National Number is used for another person!");

            }
            else
            {
                errorProvider1.SetError(txbNationalNo, null);
            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                picbImagePath.ImageLocation=(selectedFilePath);
                llRemove.Visible = true;
                // ...
            }
        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            picbImagePath.ImageLocation = null;



            if (rbMale.Checked)
                picbImagePath.Image = Resources.Male_512;
            else
                picbImagePath.Image = Resources.Female_512;

            llRemove.Visible = false;
        }

        private void txbFirstName_Validating(object sender, CancelEventArgs e)
        {

        }

      
       
    }
}
