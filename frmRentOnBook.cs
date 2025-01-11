using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class frmRentOnBook : Form
    {
        private DataTable rentOnBooksTable;
        public frmRentOnBook()
        {
            InitializeComponent();
           // grdviewrentonBooks.CellClick += grdviewrentonBooks_CellClick;
        }
        private void frmRentOnBook_Load(object sender, EventArgs e)
        {
            clsadminside obj = new clsadminside();
            DataTable dt = new DataTable();
            dt = obj.GetRentOnBookdatagrid();
            
            grdviewrentonBooks.DataSource = dt;
            grdviewrentonBooks.Show();
            
            grdviewrentonBooks.Columns["BookId"].Visible = false;
            grdviewrentonBooks.Columns["UserId"].Visible = false;
            grdviewrentonBooks.Columns["RentBookId"].Visible = false;

            if (!grdviewrentonBooks.Columns.Contains("Return"))
            {
                addColumn();
            }
            UpdateReturnButtonVisibility();
            //  addColumnstatus();
            //  SetDefaultStatus();

            rentOnBooksTable = obj.GetRentOnBookdatagrid();
            grdviewrentonBooks.DataSource = rentOnBooksTable;
            
            grdviewrentonBooks.CellClick -= grdviewrentonBooks_CellClick;
            grdviewrentonBooks.CellClick += grdviewrentonBooks_CellClick;
           // grdviewrentonBooks.CellFormatting += grdviewrentonBooks_CellFormatting;
        }
        public void addColumn()
        {
            DataGridViewButtonColumn btn=new DataGridViewButtonColumn();
            btn.HeaderText = "Return";
            btn.Name = "Return";
            btn.Text="Return";
            btn.UseColumnTextForButtonValue = true;
            grdviewrentonBooks.Columns.Add(btn);
        }
        //public void addColumnstatus()
        //{
        //    if (!grdviewrentonBooks.Columns.Contains("Status"))
        //    {
        //        DataGridViewTextBoxColumn statusColumn = new DataGridViewTextBoxColumn();
        //        statusColumn.HeaderText = "Status";
        //        statusColumn.Name = "Status";
        //        grdviewrentonBooks.Columns.Add(statusColumn);
        //    }
        //}
        //private void SetDefaultStatus()
        //{
        //    foreach (DataGridViewRow row in grdviewrentonBooks.Rows)
        //    {
        //        row.Cells["Status"].Value = "Not Returned";
        //    }
        //}
        private void UpdateReturnButtonVisibility()
        {
            foreach (DataGridViewRow row in grdviewrentonBooks.Rows)
            {
                var statusCell = row.Cells["Status"];
                string status = statusCell?.Value?.ToString() ?? "Not Returned"; 
                DataGridViewCell returnCell = row.Cells["Return"];
                if (status == "Returned")
                {
                    returnCell.Value = null; 
                    returnCell.ReadOnly = true; 
                    returnCell.Style.BackColor = Color.Gray; 

                    returnCell.Style.ForeColor = Color.Transparent; 
                    returnCell.Style.SelectionBackColor = Color.Transparent; 
                }
                else
                {
                    returnCell.Value = "Return"; 
                    returnCell.ReadOnly = false; 
                    returnCell.Style.BackColor = SystemColors.ButtonFace; 
                }
            }
        }
        private void grdviewrentonBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && grdviewrentonBooks.Columns[e.ColumnIndex].Name == "Return")
            {
                string customerName = grdviewrentonBooks.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                string bookName = grdviewrentonBooks.Rows[e.RowIndex].Cells["Bookname"].Value.ToString();
                int rentedPrice = Convert.ToInt32(grdviewrentonBooks.Rows[e.RowIndex].Cells["Price"].Value);
                DateTime returnDate = Convert.ToDateTime(grdviewrentonBooks.Rows[e.RowIndex].Cells["ReturnDate"].Value);
                DateTime today = DateTime.Now;
                int quantity = Convert.ToInt32(grdviewrentonBooks.Rows[e.RowIndex].Cells["Quantity"].Value);
                int bookid = Convert.ToInt32(grdviewrentonBooks.Rows[e.RowIndex].Cells["BookId"].Value);
                int userId = Convert.ToInt32(grdviewrentonBooks.Rows[e.RowIndex].Cells["UserId"].Value);
                int rentbid = Convert.ToInt32(grdviewrentonBooks.Rows[e.RowIndex].Cells["RentBookId"].Value);
                frmReturnBook obj = new frmReturnBook(bookid, userId, rentbid, customerName, bookName, rentedPrice, returnDate, today, quantity);
                //obj.Show();
                obj.ShowDialog();
                if (obj.IsSubmitted)
                {
                    clsadminside obj2 = new clsadminside();
                    DataTable dt = new DataTable();
                    dt = obj2.GetRentOnBookdatagrid();

                    grdviewrentonBooks.DataSource = dt;
                    grdviewrentonBooks.Show();

                    grdviewrentonBooks.Columns["BookId"].Visible = false;
                    grdviewrentonBooks.Columns["UserId"].Visible = false;
                    grdviewrentonBooks.Columns["RentBookId"].Visible = false;

                    if (!grdviewrentonBooks.Columns.Contains("Return"))
                    {
                        addColumn();
                    }
                    UpdateReturnButtonVisibility();
                    //  addColumnstatus();
                    //  SetDefaultStatus();

                    rentOnBooksTable = obj2.GetRentOnBookdatagrid();
                    grdviewrentonBooks.DataSource = rentOnBooksTable;

                    grdviewrentonBooks.CellClick -= grdviewrentonBooks_CellClick;
                    grdviewrentonBooks.CellClick += grdviewrentonBooks_CellClick;
                    // grdviewrentonBooks.CellFormatting += grdviewrentonBooks_CellFormatting;
                    //{
                    //    grdviewrentonBooks.Rows[e.RowIndex].Cells["Status"].Value = "Returned";

                    //    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)grdviewrentonBooks.Rows[e.RowIndex].Cells["Return"];
                    //    buttonCell.FlatStyle = FlatStyle.Popup; 
                    //    buttonCell.Value = "";
                    //    grdviewrentonBooks.Rows[e.RowIndex].Cells["Return"].ReadOnly = true;
                    //    grdviewrentonBooks.Rows[e.RowIndex].Cells["Return"].Style.BackColor = Color.Gray;
                    //}
                    //else
                    //{
                    //    grdviewrentonBooks.Rows[e.RowIndex].Cells["Status"].Value = "Not Returned";

                    //    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)grdviewrentonBooks.Rows[e.RowIndex].Cells["Return"];
                    //    buttonCell.Value = "Return"; 
                    //    grdviewrentonBooks.Rows[e.RowIndex].Cells["Return"].ReadOnly = false;
                    //    grdviewrentonBooks.Rows[e.RowIndex].Cells["Return"].Style.BackColor = SystemColors.ButtonFace; 
                    //}
                }
            }
        }    
        private void grdviewrentonBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {        
        }
        private void txtsearchUser_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void txtsearchbyBook_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void ApplyFilter()
        {
            if (rentOnBooksTable == null) return;
            string usernameFilter = txtsearchUser.Text.Trim();
            string bookNameFilter = txtsearchbyBook.Text.Trim();
            string filter = "";
            if (!string.IsNullOrEmpty(usernameFilter))
            {
                filter += $"Username LIKE '%{usernameFilter}%'";
            }
            if (!string.IsNullOrEmpty(bookNameFilter))
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }
                filter += $"BookName LIKE '%{bookNameFilter}%'";
            }           
            DataView dv = rentOnBooksTable.DefaultView;
            dv.RowFilter = filter;
            grdviewrentonBooks.DataSource = dv;
        }
        private void grdviewrentonBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grdviewrentonBooks.Columns[e.ColumnIndex].Name == "Return") 
            {
                var row = grdviewrentonBooks.Rows[e.RowIndex];
                var statusCell = row.Cells["Status"]; 
               
                if (statusCell.Value != null)
                {
                    string statusValue = statusCell.Value.ToString();

                    if (statusValue == "Not Returned")
                    {
                       
                        e.Value = "Return"; 
                    }
                    else if (statusValue == "Returned")
                    {
                        
                        e.Value = DBNull.Value; 
                    }
                    else
                    {
                        
                        e.Value = DBNull.Value; 
                    }
                }
                else
                {
                    
                    e.Value = DBNull.Value; 
                }
            }
        }
        private void grdviewrentonBooks_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {if (grdviewrentonBooks.IsCurrentCellDirty)
                {
                    grdviewrentonBooks.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
        
        // private void grdviewrentonBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        // {
        //if (grdviewrentonBooks.Columns[e.ColumnIndex].Name == "Return" && e.RowIndex >= 0)
        //{
        //    string status = grdviewrentonBooks.Rows[e.RowIndex].Cells["Status"].Value?.ToString();
        //    if (status == "Returned")
        //    {
        //        grdviewrentonBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Empty; // Remove button text
        //        grdviewrentonBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;     // Disable button
        //    }
        //}
        //  }
    }
}
