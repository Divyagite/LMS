using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagement
{
    public partial class frmCustomer : Form
    {
        int quantity = 1;
        public frmCustomer(string Email)
        {
            InitializeComponent();
            IsMdiContainer = true;
            lblEmail.Text = Email;
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            string email = lblEmail.Text;
            clsRegistration obj = new clsRegistration(email, 0);
            SqlDataReader dr;
            dr = obj.CustData();
            while (dr.Read())
            {
                lblName.Text = dr["UserName"].ToString();
                lblAdd.Text = dr["UserAddress"].ToString();
                lblContactS.Text = dr["UserContact"].ToString();
                lblUid.Text = dr["UserId"].ToString();
            }
            dr.Close();

            clsRegistration obj2 = new clsRegistration();
            DataTable dt = obj2.GetGenre();

            cmbxGenre.DisplayMember = "genrename";
            cmbxGenre.ValueMember = "genreid";
            cmbxGenre.DataSource = dt;
            gridviewbookdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridviewbookdata.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridviewbookdata.AutoResizeColumns();
            gridviewbookdata.AutoResizeRows();

            lstviewcust.View = View.Details;
            lstviewcust.FullRowSelect = true;
            lstviewcust.GridLines = true;
            //lstviewcust.CheckBoxes = true;
            lstviewcust.OwnerDraw = true;


            lstviewcust.Columns.Add("GenreName", 70);
            lstviewcust.Columns.Add("GenreId", 0);
            lstviewcust.Columns.Add("CupboardName", 100);
            lstviewcust.Columns.Add("CustId", 0);
            lstviewcust.Columns.Add("BookId", 0);
            lstviewcust.Columns.Add("BookName", 100);
            lstviewcust.Columns.Add("Price", 50);
            lstviewcust.Columns.Add("Quantity", 80);
            lstviewcust.Columns.Add("Return Date:", 100);
           // lstviewcust.Columns.Add("Select", 100);

            lstviewcust.DrawColumnHeader += lstviewcust_DrawColumnHeader_1;
            lstviewcust.DrawItem += lstviewcust_DrawItem_1;
            lstviewcust.DrawSubItem += lstviewcust_DrawSubItem_1;
            lstviewcust.MouseClick += lstviewcust_MouseClick;

        }
        private void cmbxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            int genreid = Convert.ToInt32(cmbxGenre.SelectedValue);
            clsRegistration obj = new clsRegistration();
            DataTable dt = obj.GetCupBoardByGenre(genreid);

            cmbxcupboard.DisplayMember = "cupboardname";
            cmbxcupboard.ValueMember = "cupbid";
            cmbxcupboard.DataSource = dt;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {

        }
        private void cmbxcupboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cupbid = Convert.ToInt32(cmbxcupboard.SelectedValue);
            clsRegistration obj = new clsRegistration();
            DataTable dt = obj.ShowBookdata(cupbid);
            gridviewbookdata.DataSource = dt;
            gridviewbookdata.Show();
            gridviewbookdata.Columns["BookId"].Visible = false;
        }
        private void gridviewbookdata_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtbxrentprice.Text = gridviewbookdata.Rows[rowIndex].Cells[2].Value.ToString();
            txtquantity.Text = "1";
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridviewbookdata.SelectedRows.Count == 0)
                {
                    throw new Exception("Please select a book from the list before adding to the cart.");
                }
                string bookid = gridviewbookdata.SelectedRows[0].Cells["BookId"].Value.ToString();
                string bookname = gridviewbookdata.SelectedRows[0].Cells["BookName"].Value.ToString();
                string price = txtbxrentprice.Text;
                int currentQuantity = Convert.ToInt32(txtquantity.Text);
                int availableQuantity = Convert.ToInt32(gridviewbookdata.SelectedRows[0].Cells["Quantity"].Value);

                if (availableQuantity == 0)
                {
                    MessageBox.Show($"The book '{bookname}' is out of stock.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if the requested quantity exceeds available stock
                int existingQuantity = 0;

                foreach (ListViewItem item in lstviewcust.Items)
                {
                    if (item.SubItems[4].Text == bookid)
                    {
                        existingQuantity = Convert.ToInt32(item.SubItems[7].Text);
                        break;
                        //int newQuantity = existingQuantity + currentQuantity;
                        //item.SubItems[7].Text = newQuantity.ToString();
                        //item.SubItems[6].Text = (newQuantity * Convert.ToInt32(price)).ToString();
                        //UpdateTotalAmount();
                        //return;
                    }
                }
                if (existingQuantity + currentQuantity > availableQuantity)
                {
                    MessageBox.Show($"Cannot add more than {availableQuantity} units of '{bookname}'.", "Stock Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (ListViewItem item in lstviewcust.Items)
                {
                    if (item.SubItems[4].Text == bookid)
                    {
                        int newQuantity = existingQuantity + currentQuantity;
                        item.SubItems[7].Text = newQuantity.ToString();
                        item.SubItems[6].Text = (newQuantity * Convert.ToInt32(price)).ToString();
                        UpdateTotalAmount();
                        return;
                    }
                }


                ListViewItem newItem = new ListViewItem(cmbxGenre.Text);
                newItem.SubItems.Add(cmbxGenre.SelectedValue.ToString());
                newItem.SubItems.Add(cmbxcupboard.Text);
                newItem.SubItems.Add(cmbxcupboard.SelectedValue.ToString());
                newItem.SubItems.Add(bookid);
                newItem.SubItems.Add(bookname);
                newItem.SubItems.Add(price);
                newItem.SubItems.Add(currentQuantity.ToString());
                newItem.SubItems.Add(dateTimePicker1.Text);

               // newItem.SubItems.Add("");
                lstviewcust.Items.Add(newItem);
              //  lstviewcust.Refresh();
 
                txtquantity.Text = currentQuantity.ToString();
                UpdateTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void UpdateTotalAmount()
            {
                int sum = 0;

             
                foreach (ListViewItem item in lstviewcust.Items)
                {
                    sum += Convert.ToInt32(item.SubItems[6].Text); 
                }

                txtbxtotalamt.Text = sum.ToString();
            }
        private void btnRentBooks_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstviewcust.Items)
            {
                int bookid = Convert.ToInt32(item.SubItems[4].Text);
                //int Genid = Convert.ToInt32(item.SubItems[1].Text);
                //int cupbid = Convert.ToInt32(item.SubItems[3].Text);
                int uid=Convert.ToInt32(lblUid.Text);
                int Price = Convert.ToInt32(item.SubItems[6].Text);
                int totalamt=Convert.ToInt32(txtbxtotalamt.Text);
                DateTime ReturnDate = Convert.ToDateTime(item.SubItems[8].Text);
                int quantity=Convert.ToInt32(item.SubItems[7].Text);
                string username = lblName.Text;
                string status = "Not Returned";
                clsRegistration obj = new clsRegistration(bookid,uid,Price,totalamt,ReturnDate,quantity,status);
                obj.SaveRentBooks();
                MessageBox.Show($"Dear {username}Your Book Renting order has been placed with Total Amount:{totalamt}");

            }  
            lstviewcust.Items.Clear();
        }
        private void lstviewcust_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the clicked item (if any)
            ListViewHitTestInfo hit = lstviewcust.HitTest(e.Location);
            if (hit.Item != null && hit.SubItem != null && hit.Item.SubItems.IndexOf(hit.SubItem) == 9) 
            {
                // Toggle checkbox state
                bool isChecked = hit.Item.Tag != null && (bool)hit.Item.Tag;
                hit.Item.Tag = !isChecked;

                // Redraw the affected item
                lstviewcust.Invalidate(hit.SubItem.Bounds);
            }
            //ListViewHitTestInfo hit = lstviewcust.HitTest(e.Location);
            //if (hit.SubItem != null && hit.Item != null && hit.Item.SubItems.IndexOf(hit.SubItem) == 9) // Column index for "Action"
            //{

            //    lstviewcust.Items.Remove(hit.Item);
            //    UpdateTotalAmount();
            //}
            // Get the clicked item (if any)
            //ListViewItem clickedItem = lstviewcust.GetItemAt(e.X, e.Y);

            //if (clickedItem != null)
            //{
            //    // Toggle the checkbox when clicked on the row
            //    clickedItem.Checked = !clickedItem.Checked;
            //}
        }
        private void btnremovecart_Click(object sender, EventArgs e)
        {
            lstviewcust.Items.RemoveAt(lstviewcust.SelectedIndices[0]);
            UpdateTotalAmount();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstviewcust.Items.Clear();
        }
        private void Lstviewcust_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            //if (e.ColumnIndex == 9) // Column index for the "Action" button column
            //{
            //    Font font=lstviewcust.Font;
            //    // Draw a button-like rectangle
            //    Rectangle buttonBounds = new Rectangle(e.Bounds.Left + 5, e.Bounds.Top + 2, e.Bounds.Width - 10, e.Bounds.Height - 4);
            //    ButtonRenderer.DrawButton(e.Graphics, buttonBounds, "Delete",font, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter, false);
            //}
            //else
            //{
            //    e.DrawDefault = true; // Default rendering for other columns
            //}
        }
        private void lstviewcust_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //if (e.ColumnIndex == gridviewbookdata.Columns["Delete"].Index && e.RowIndex >= 0)
            //{
            //    gridviewcust.Rows.RemoveAt(e.RowIndex); // Remove the selected row
            //    UpdateTotalAmount();
            //}
        }
        private void lstviewcust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == lstviewcust.Columns["Delete"].Index && e.RowIndex >= 0)
            //{
            //    lstviewcust.Rows.RemoveAt(e.RowIndex); // Remove the selected row
            //    UpdateTotalAmount();
            //}
        }
        private void gridviewbookdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (gridviewbookdata.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    gridviewbookdata.CurrentRow.Selected = true;
            //    txtbxrentprice.Text = gridviewbookdata.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();

            //}
            foreach (DataGridViewRow row in gridviewbookdata.Rows)
            {
                if (row.Cells[0].Value.ToString() != null && row.Cells[0].Value.ToString().Trim()!="")
                {

                }
            }
        }

        private void lstviewcust_DrawSubItem_1(object sender, DrawListViewSubItemEventArgs e)
        {
            //MessageBox.Show("Checkbox column being drawn");
            //if (e.ColumnIndex == 9) // Index of the checkbox column
            //{
            //    // Draw checkbox
            //    Rectangle checkboxBounds = new Rectangle(e.Bounds.Left + 10, e.Bounds.Top + 5, 16, 16);
            //    bool isChecked = e.Item.Tag != null && (bool)e.Item.Tag; // Store state in Tag
            //    CheckBoxRenderer.DrawCheckBox(e.Graphics, checkboxBounds.Location,
            //        isChecked ? System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal
            //                  : System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
            //}
            //else
            //{
            //    e.DrawDefault = true; // Default rendering for other columns
            //}
        }
        private void Lstviewcust_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
           
        }

        private void Lstviewcust_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
             //e.DrawDefault = true;
        }

        private void lstviewcust_DrawColumnHeader_1(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lstviewcust_DrawItem_1(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today > dateTimePicker1.Value)
            {
                MessageBox.Show("You Selected date is Invalid !!!", "Invalid Input", MessageBoxButtons.OK,MessageBoxIcon.Error);
                dateTimePicker1.Value= DateTime.Today;
            }
        }
    }
}

//    int Rowindex = e.RowIndex;
//    txtbxrentprice.Text = gridviewbookdata.Rows[Rowindex].Cells[2].Value.ToString();
//    txtquantity.Text = quantity.ToString();

//}

//private void btnAddtoCart_Click(object sender, EventArgs e)
//{
//    string bookid = gridviewbookdata.SelectedRows[0].Cells["BookId"].Value.ToString();
//    string bookname = gridviewbookdata.SelectedRows[0].Cells["BookName"].Value.ToString();
//    string price = txtbxrentprice.Text;



//    foreach (ListViewItem item in lstviewcust.Items)
//    {
//        if (item.SubItems[4].Text == bookid)
//        {
//            quantity = Convert.ToInt32(item.SubItems[7].Text);
//            item.SubItems[7].Text = (++quantity).ToString();
//            item.SubItems[6].Text = (quantity * Convert.ToInt32(price)).ToString();
//            txtquantity.Text = quantity.ToString();
//            UpdateTotalAmount();
//            return;
//        }

//    }


//    ListViewItem lstview2 = new ListViewItem(cmbxGenre.Text);
//        lstview2.SubItems.Add(cmbxGenre.SelectedValue.ToString());
//        lstview2.SubItems.Add(cmbxcupboard.Text);
//        lstview2.SubItems.Add(cmbxcupboard.SelectedValue.ToString());
//        lstview2.SubItems.Add(bookid);
//        lstview2.SubItems.Add(bookname);
//        lstview2.SubItems.Add(price);
//        lstview2.SubItems.Add(quantity.ToString());
//        lstview2.SubItems.Add(dateTimePicker1.Text);
//        lstviewcust.Items.Add(lstview2);

//       // txtquantity.Text = quantity.ToString();
//        UpdateTotalAmount();
//    }
//ImageList image = new ImageList();
//image.ImageSize = new Size(16, 16);

//try
//{

//        image.Images.Add(Image.FromFile("C:\\Users\\LENOVO\\Downloads\\red cross.jpg"));

//}
//catch (Exception ex)
//{
//    MessageBox.Show(ex.Message);
//    return;
//}

//lstviewcust.SmallImageList= image;

//ListViewHitTestInfo hit = lstviewcust.HitTest(e.Location);
//if (hit.SubItem != null && hit.SubItem.Text == "Delete" && hit.Item != null)
//{
//    lstviewcust.Items.Remove(hit.Item);
//    UpdateTotalAmount();
//}


