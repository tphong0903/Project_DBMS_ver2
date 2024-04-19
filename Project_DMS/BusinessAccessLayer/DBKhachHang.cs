using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
//
using DataAccessLayer; // Importing the namespace for DataAccessLayer

namespace BusinessAccessLayer
{
    public class DBKhachHang
    {
        DAL db = null; // Declaring an instance of the DAL class
        public DBKhachHang()
        {
            db = new DAL(); // Initializing the instance of the DAL class
        }

        // Method to retrieve all customers
        public DataSet LayKhachHang()
        {
            return db.ExecuteQueryDataSet(
                "select * from View_Customer", CommandType.Text, null); // Executing a SQL query to select all customers
        }

        // Method to search for customers by phone number and name
        public DataSet TimKhachHang(string Phone, string Name)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM Find_Customer('" + Phone + "',N'" + Name + "')",
                CommandType.Text, null); // Executing a SQL query to search for customers based on phone number and name
        }

        // Method to retrieve products purchased by a customer
        public DataSet SPcuaKhachHang(string Phone)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM ProductOfCustomer('" + Phone + "')",
                CommandType.Text, null); // Executing a SQL query to retrieve products purchased by a customer
        }

        // Method to delete a customer
        public bool XoaKhachHang(ref string err, string sdt)
        {
            return db.MyExecuteNonQuery("spDeleteCustomer",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@PhoneNumber", sdt)); // Calling a stored procedure to delete a customer
        }

        // Method to insert a new customer
        public bool ThemKhachHang(ref string err, string sdt, string name, DateTime birthday, string gender, int point)
        {
            return db.MyExecuteNonQuery("spInsertCustomer",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@PhoneNumber", sdt),
                new SqlParameter("@NameCustomer", name),
                new SqlParameter("@Birthday", birthday),
                new SqlParameter("@Gender", gender),
                new SqlParameter("@Point", point)
                ); // Calling a stored procedure to insert a new customer
        }
        public bool CapNhatKhachHang(ref string err, string sdt, string name, DateTime birthday, string gender, int point) // Method to update customer information
        {
            return db.MyExecuteNonQuery("spUpdateCustomer", // Returning the result of the MyExecuteNonQuery method of the DAL class
                CommandType.StoredProcedure, ref err, // Calling the spUpdateCustomer stored procedure to update customer information
                new SqlParameter("@PhoneNumber", sdt), // Passing the parameters to the stored procedure
                new SqlParameter("@NameCustomer", name),
                new SqlParameter("@Birthday", birthday),
                new SqlParameter("@Gender", gender),
                new SqlParameter("@Point", point)
                );
        }
    }
}