using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class frmReturnBook : Form
    {
        public bool IsSubmitted { get; private set; } = false;
        private int _basePrice;
        public frmReturnBook(int bid,int cid,int rentbid,string custname, string bname, int rprice, DateTime returndate,DateTime today,int quantity)
        {
            InitializeComponent();
            lblBookid.Text = bid.ToString();
            lblcname.Text = custname;
            lbluserid.Text = cid.ToString();
            lblbname.Text = bname;
            lblrentid.Text = rentbid.ToString();
            lblprice.Text = rprice.ToString();
            lblrdate.Text = returndate.ToString("dd/MM/yyyy");
            lbltodaydate2.Text = today.ToString("dd/MM/yyyy");
            lblquantity.Text = quantity.ToString();
            
            int daysBetween = (today - returndate).Days;
            if (daysBetween < 0)
            {
                daysBetween = 0;
            }
            //lblpenaltydays.Text = $"{daysBetween};
            lblpenaltydays.Text = daysBetween.ToString();

            _basePrice = rprice;

            txtPenaltyAmount.TextChanged += txtPenaltyAmount_TextChanged;
        }    
        private void frmReturnBook_Load(object sender, EventArgs e)
        {
        }
        private void txtPenaltyAmount_TextChanged(object sender, EventArgs e)
        {
           int penaltyAmount = 0;
            int rentp = Convert.ToInt32(lblprice.Text);
            if (!string.IsNullOrWhiteSpace(txtPenaltyAmount.Text))
            {
               int.TryParse(txtPenaltyAmount.Text,out penaltyAmount);
               // Convert.ToInt32(txtPenaltyAmount.Text, out penaltyAmount);
            }
            int totalAmount = rentp + penaltyAmount;
            txttotalamt.Text = totalAmount.ToString();
        }        
        private void btnReturn_Click(object sender, EventArgs e)
        {
            int bookid=Convert.ToInt32(lblBookid.Text);
            string CustName=lblcname.Text;
            string bname=lblbname.Text;
            int rentprice=Convert.ToInt32(lblprice.Text);
            string returndate=lblrdate.Text;
            string today=lbltodaydate2.Text;
            int penaltyday=Convert.ToInt32(lblpenaltydays.Text);
            int penaltyamt=Convert.ToInt32(txtPenaltyAmount.Text);
            int quantity=Convert.ToInt32(lblquantity.Text);
           //int totalamt=;
           //int totalamt= Convert.ToInt32(totalamt.Text);
           int totalamt=Convert.ToInt32(txttotalamt.Text);
            int userid=Convert.ToInt32(lbluserid.Text);
            string status = "Returned";
            int rentbid=Convert.ToInt32(lblrentid.Text);
            clsadminside obj= new clsadminside(bookid,rentbid,CustName,bname,rentprice,returndate,today,penaltyday,penaltyamt,quantity,totalamt,status);
            obj.SaveReturnBookData(userid);
            obj.UpdateReturnStatus(rentbid,status);
            MessageBox.Show("Returned Book Data Added Successfully...");
            IsSubmitted = true;
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPenaltyAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
