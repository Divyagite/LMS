using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagement
{
    class clsadminside
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-GUA40AIK;Initial Catalog=LibraryManagement;Integrated Security=True");
        public string CustName {  get; set; }
        public string Bookname { get; set; }
        public int RentPrice {  get; set; }
        public string ReturnDate {  get; set; }
        public string ActualDate { get; set; }
        public int Penaltydays { get; set; }
        public int Penaltyamt { get; set; }
        public int QuantityReturned {  get; set; }
        public float Totalamt {  get; set; }
        public int RentBookId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public string Status {  get; set; }
      //  public int RentId {  get; set; }
        public clsadminside() { }
        public clsadminside(int bid,int rentbid,string custname,string bname,int price,string returndate,string actualdate,int penaltydays,int penaltyamt,int quantity,int totalamt,string status)
        {
           // UserId = userid;
            BookId = bid;
            CustName = custname;
            Bookname = bname;
            RentPrice = price;
            ReturnDate = returndate;
            ActualDate = actualdate;
            Penaltydays = penaltydays;
            Penaltyamt = penaltyamt;
            QuantityReturned = quantity;
            Totalamt = totalamt;
            RentBookId=rentbid;
            Status = status;
        }       
        public DataTable GetallBookdatagrid()
        {
            con.Open(); 
            SqlCommand cmd = new SqlCommand("libraryManagement",con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ShowallBookdata");                    
            SqlDataAdapter adpt= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetallUnassignedBookdata()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("libraryManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ShowallUnassignedBookData");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetRentOnBookdatagrid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("libraryManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ShowallRentOnBookData");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close() ;
            return dt;
        }
        public void SaveReturnBookData(int uid)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("libraryManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "SaveReturnBooks");
            cmd.Parameters.AddWithValue("@Bookid",BookId);
            cmd.Parameters.AddWithValue("@RentBookId", RentBookId);
            cmd.Parameters.AddWithValue("@UserId", uid);
            cmd.Parameters.AddWithValue("@UserName", CustName);
            cmd.Parameters.AddWithValue("@Bookname", Bookname);
            cmd.Parameters.AddWithValue("@RentPrice", RentPrice);
            cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate);
            cmd.Parameters.AddWithValue("@Date", ActualDate);
            cmd.Parameters.AddWithValue("@PenaltyDays", Penaltydays);
            cmd.Parameters.AddWithValue("@Penaltymt", Penaltyamt);
            cmd.Parameters.AddWithValue("@QuantityReturned", QuantityReturned);
            cmd.Parameters.AddWithValue("@Totalcustamt", Totalamt);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateReturnStatus(int RentBookId ,string status)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("libraryManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "UpdateStatus");
           // cmd.Parameters.AddWithValue("@UserId", customerID);
           // cmd.Parameters.AddWithValue("@Bookid", bookID);
            cmd.Parameters.AddWithValue("@RentBookId",RentBookId);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
