using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();           
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtpasslogin.PasswordChar = '*';
            clsRegistration obj1 = new clsRegistration();
            DataTable dt = obj1.GetUserTypes();
            cmbxusertypelogin.DisplayMember = "TypeName";
            cmbxusertypelogin.ValueMember = "Typeid";
            cmbxusertypelogin.DataSource = dt;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int typeId = Convert.ToInt32(cmbxusertypelogin.SelectedValue.ToString());

            clsRegistration obj = new clsRegistration(txtemaillogin.Text, txtpasslogin.Text, typeId);

            SqlDataReader dbr;

            dbr = obj.LoginUser(typeId);

            if (dbr.Read())
            {
                string userType = dbr["Typeid"].ToString();
                if (userType == "1")
                {
                    MessageBox.Show("Login successfull as Admin");
                    frrmAdmin admin = new frrmAdmin();
                    //this.Hide();
                    admin.Show();
                    this.Hide();
                }
                else if (userType == "2")
                {
                    MessageBox.Show("Login successfull as Customer");
                    string email=txtemaillogin.Text;
                    //clsRegistration obj2 = new clsRegistration();
                    //obj2.CustData();
                    frmCustomer cust = new frmCustomer(email);
                    cust.Show();
                    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" Invalid User Type..");

                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password..");
            }
                dbr.Close();
  } } }
        
//try
//{
//    if (!(cmbxusertypelogin.Text == string.Empty))
//    {
//        if (!(cmbxusertypelogin.Text == string.Empty))
//        {

//    catch (Exception ex)
//    {

//        MessageBox.Show("An error occurred: " + ex.Message, "Error");
//    }
//}
//    } 
//}



