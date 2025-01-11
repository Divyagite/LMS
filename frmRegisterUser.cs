using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement
{
    public partial class frmRegisterUser : Form
    {
        public string gender;
        public frmRegisterUser()
        {
            InitializeComponent();
        }
        private void btnregister_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }
            if (rdbtnmale.Checked)
                {
                    gender = "Male";
                }
                else if (rsbtnfemale.Checked)
                {
                    gender = "Female";
                }
                int type = Convert.ToInt32(cmbxusertype.SelectedValue);
                clsRegistration obj = new clsRegistration(txtbxname.Text, txtAddress.Text, txtbxemail.Text, txtbxcontact.Text, gender, txtpass.Text, type);
                obj.SaveUser();
                MessageBox.Show("User Registered successfully..");
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();              
            }

        private bool ValidateInputs()
        {
            //email
            if (!Regex.IsMatch(txtbxemail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error");
                txtbxemail.Focus();
                txtbxemail.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txtbxemail.BackColor = SystemColors.Window;
            }
            //contact           
            if (!Regex.IsMatch(txtbxcontact.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter a valid 10-digit contact number.", "Validation Error");
                txtbxcontact.Focus();
                return false;
            }
            //pass
            if (txtpass.Text.Length < 8 ||
                !txtpass.Text.Any(char.IsUpper) ||
                !txtpass.Text.Any(char.IsLower) ||
                !txtpass.Text.Any(char.IsDigit) ||
                !txtpass.Text.Any(ch => "!@#$%^&*".Contains(ch)))
            {
                MessageBox.Show("Password must be at least 8 characters long and include an uppercase letter, a lowercase letter, a digit, and a special character.", "Validation Error");
                txtpass.Focus();
                return false;
            }
            return true; 
        }

        private void cmbxusertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void frmRegisterUser_Load(object sender, EventArgs e)
        {
            clsRegistration obj = new clsRegistration();
            DataTable dt = obj.GetUserTypes();

            cmbxusertype.DisplayMember = "TypeName";
            cmbxusertype.ValueMember = "Typeid";
            cmbxusertype.DataSource = dt;
            txtbxcontact.MaxLength = 10;           
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbxname.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtbxemail.Text = string.Empty;
            txtbxcontact.Text = string.Empty;
            txtpass.Text = string.Empty;
            cmbxusertype.SelectedItem = null; 
            rsbtnfemale.Checked = false;
            rdbtnmale.Checked = false;
        }

        private void txtbxcontact_KeyPress(object sender, KeyPressEventArgs e)
        {          
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}