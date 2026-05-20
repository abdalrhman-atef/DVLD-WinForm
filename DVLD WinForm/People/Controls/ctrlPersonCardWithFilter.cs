using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_WinForm.People.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action <int> handler = OnPersonSelected;
            if (handler!=null)
            {
                handler(PersonID); 
            }


        }

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get { return _ShowAddPerson; } 
            set
                {
                _ShowAddPerson = value;
                 btnAdd.Visible = _ShowAddPerson;
                }
        }

        private bool _FilterEnabled = true;
     
        public bool FilterEnabled 
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled= value;
                gbFilter.Enabled = _FilterEnabled;
               
            }
        
        }
      


        private int _PersonID = -1;

        public int PersonID 
        {
        
            get{ return ctrlPersonCard1.PersonID; }
        
        }

        string _NationalNo = "";
        public clsPeople SelectedPersonInfo 
        {
            get {return ctrlPersonCard1.SelectedPerson; }
        
        
        }

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        private void FindPerson() 
        {
            switch (cbFilterBy.Text) 
            {
                case "Person ID":
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(txbFilter.Text));
                    break;
                case "National No":
                    ctrlPersonCard1.LoadPersonInfo(txbFilter.Text);
                    break;
                default:
                    break;


            }
            if (OnPersonSelected!= null&& FilterEnabled)
            {
                OnPersonSelected(ctrlPersonCard1.PersonID);
            }




        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txbFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbFilter.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbFilter, "This field is required!");
            }
            else
                errorProvider1.SetError(txbFilter, null);

        }

        private void txbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                btnFind.PerformClick();
            }

            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FindPerson();
        }
        
        private void DataBackEvent(object sender, int PersonID) 
        {
            cbFilterBy.SelectedIndex = 1;
            txbFilter.Text= PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);



        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAdd = new frmAddUpdatePerson();
            frmAdd.DataBack += DataBackEvent;
            frmAdd.ShowDialog();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbFilter.Text = "";
            txbFilter.Focus();
        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {
          
        }
        public void LoadPersonInfo(int PersonID)
        {

            cbFilterBy.SelectedIndex = 1;
            txbFilter.Text = PersonID.ToString();
            FindPerson();

        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txbFilter.Focus();
        }

        public void FilterFocus()
        {
            txbFilter.Focus();
        }

    }
}
