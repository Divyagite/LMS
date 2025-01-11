using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
     class clsRegistration
    {
        SqlConnection con=new SqlConnection("Data Source=LAPTOP-GUA40AIK;Initial Catalog=LibraryManagement;Integrated Security=True");
        public int UserId { get; set; }    
        public int TypeId {  get; set; }
        public string Typename { get; set; }
        public string Genrename { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Cupboardname {  get; set; }
        public string Bookname { get; set; }
        public int Rentprice {  get; set; }
        public int Quantity {  get; set; }
        public int GenreId { get; set; }
        public int CupbId {  get; set; }
        public  int BookId { get; set; }
        public DateTime ReturnDate { get; set; }
        public int Totalamt {  get; set; }
        public string Status {  get; set; }

        public clsRegistration() { }
        public clsRegistration(string genrename)
        {
            Genrename = genrename;
        }
        public clsRegistration(int genreid,string cupboardname)
        {
            GenreId = genreid;
            Cupboardname = cupboardname;
        }
        public clsRegistration( string bookname,int rentprice,int quantity,int cupbid)
        {
            Bookname = bookname;
            Rentprice = rentprice;
            Quantity = quantity;
          
            CupbId = cupbid;
        }
        public clsRegistration(string username,string address,string email,string contact,string gender,string pass,int typeid)
        {           
            UserName = username;
            Address = address;
            Email = email;
            Gender = gender;
            Password = pass;
            Phone = contact;
            TypeId = typeid;
        }
        public clsRegistration(int bookid,int uid,int price,int totalamt,DateTime Returndate,int quantity,string status)
        {
            BookId = bookid;
            UserId = uid;
            Rentprice= price;
            ReturnDate = Returndate;
            Totalamt = totalamt;
            Quantity= quantity;   
            Status = status;
        }    
        public clsRegistration(string useremail,string userpass,int type)
        {
            Email = useremail;
            Password= userpass;
            TypeId = type;
        }
        public clsRegistration(string useremail,int eid)
        {
            Email = useremail;                   
        }
        public void SaveUser()
        { 
            con.Open();
            SqlCommand cmd = new SqlCommand("libraryManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "SaveUser");
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@UserAddress", Address);
            cmd.Parameters.AddWithValue("@UserEmail", Email);
            cmd.Parameters.AddWithValue("@UserContact", Phone);
            cmd.Parameters.AddWithValue("@UserGender", Gender);
            cmd.Parameters.AddWithValue("@UserPass", Password);
            cmd.Parameters.AddWithValue("@Typeid", TypeId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void SaveGenre()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("libraryManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "SaveGenre");
            cmd.Parameters.AddWithValue("@genrename", Genrename);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetUserTypes()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("libraryManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetUserType");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetGenre()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("libraryManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetGenre");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        public void SaveCupboard()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("libraryManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "SaveCupboard");
            cmd.Parameters.AddWithValue("@cupboardname", Cupboardname);
            cmd.Parameters.AddWithValue("@genreid", GenreId);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable GetCupBoardByGenre(int GenreId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("libraryManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetCupBoardByGenre");
            cmd.Parameters.AddWithValue("@genreid",GenreId);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        public void SaveBooks()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("libraryManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "SaveBooks");
            cmd.Parameters.AddWithValue("@Bookname", Bookname);
            cmd.Parameters.AddWithValue("@RentPrice",Rentprice);
            cmd.Parameters.AddWithValue("@QuantityRented", Quantity);
           // cmd.Parameters.AddWithValue("@genreid", GenreId);
            cmd.Parameters.AddWithValue("@cupbid", CupbId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataReader LoginUser(int TypeId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("libraryManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "LoginUser");
            cmd.Parameters.AddWithValue("@Typeid", TypeId);
            cmd.Parameters.AddWithValue("@UserEmail", Email);
            cmd.Parameters.AddWithValue("@UserPass", Password);
            SqlDataReader dr=cmd.ExecuteReader();          
            return dr;
            con.Close();
        }
        public DataTable ShowBookdata(int CupbId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("libraryManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ShowBookData");
            //cmd.Parameters.AddWithValue("@genreid",GenreId);
            cmd.Parameters.AddWithValue("@cupbid",CupbId);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        public SqlDataReader CustData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("libraryManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetCustData");
            cmd.Parameters.AddWithValue("@UserEmail",Email);
            SqlDataReader dr = cmd.ExecuteReader();  
           
            return dr;
        }
        public void SaveRentBooks()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("libraryManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag","SaveRentBooks");
            cmd.Parameters.AddWithValue("@Bookid", BookId);
            //cmd.Parameters.AddWithValue("@genreid", GenreId);
            //cmd.Parameters.AddWithValue("@cupbid", CupbId);
            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@RentPrice", Rentprice);
            cmd.Parameters.AddWithValue("@Totalamt", Totalamt);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString("dd-MM-yyyy"));
            cmd.Parameters.AddWithValue("@ReturnDate",ReturnDate.ToString("dd-MM-yyyy"));
            cmd.Parameters.AddWithValue("@QuantityRented", Quantity);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.ExecuteNonQuery();
            con.Close() ;
        }
    }
}
