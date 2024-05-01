using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
//
using DataAccessLayer;
using Microsoft.SqlServer.Server;
using System.Net;
using System.Xml.Linq;

namespace BusinessAccessLayer // Declaring the BusinessAccessLayer namespace
{
    public class DBNhanVien // Declaring the DBNhanVien class
    {
        DAL db = null; // Declaring an instance of the DAL class and initializing it to null

        // Constructor for the DBNhanVien class
        public DBNhanVien()
        {
            db = new DAL(); // Initializing the db instance with a new instance of the DAL class
        }

        // Method to retrieve active employees
        public DataSet LayNhanVien()
        {
            // Returning the result of the ExecuteQueryDataSet method of the DAL class
            return db.ExecuteQueryDataSet("select * from EMPLOYEES_ACTIVE_VIEW", CommandType.Text, null);
        }

        // Method to retrieve all employees
        public DataSet LayALLNhanVien()
        {
            // Returning the result of the ExecuteQueryDataSet method of the DAL class
            return db.ExecuteQueryDataSet("select * from EMPLOYEES_All_VIEW", CommandType.Text, null);
        }

        // Method to search for employees by ID and name
        public DataSet TimNhanVien(string ID, string name)
        {
            // Returning the result of the ExecuteQueryDataSet method of the DAL class
            return db.ExecuteQueryDataSet("select * from Find_Employee(N'" + ID + "',N'" + name + "')", CommandType.Text, null);
        }

        // Method to search for all employees by ID
        public DataSet TimAllNhanVien(string ID)
        {
            // Returning the result of the ExecuteQueryDataSet method of the DAL class
            return db.ExecuteQueryDataSet("select * from EMPLOYEES_All_VIEW where EmployeeID like '%'+'" + ID + "'+'%'", CommandType.Text, null);
        }

        // Method to add a new employee
        public bool ThemNhanVien(ref string err, string id, string name, DateTime birthday, string gender, string address, string sdt, string role, int active, string password)
        {
            // Returning the result of the MyExecuteNonQuery method of the DAL class
            return db.MyExecuteNonQuery("spInsertEmployee", CommandType.StoredProcedure, ref err,
                // Passing the parameters to the stored procedure
                new SqlParameter("@EmployeeID", id),
                new SqlParameter("@NameEmployee", name),
                new SqlParameter("@Birthday", birthday),
                new SqlParameter("@Gender", gender),
                new SqlParameter("@AddressEmployee", address),
                new SqlParameter("@PhoneNumber", sdt),
                new SqlParameter("@RoleEmployee", role),
                new SqlParameter("@Active", active),
                new SqlParameter("@PassWordAccount", password)
                );
        }

        // Method to update an employee
        public bool CapNhatNhanVien(ref string err, string id, string name, DateTime birthday, string gender, string address, string sdt, string role, int active, string password)
        {
            // Returning the result of the MyExecuteNonQuery method of the DAL class
            return db.MyExecuteNonQuery("spUpdateEmployee", CommandType.StoredProcedure, ref err,
                // Passing the parameters to the stored procedure
                new SqlParameter("@EmployeeID", id),
                new SqlParameter("@NameEmployee", name),
                new SqlParameter("@Birthday", birthday),
                new SqlParameter("@Gender", gender),
                new SqlParameter("@AddressEmployee", address),
                new SqlParameter("@PhoneNumber", sdt),
                new SqlParameter("@RoleEmployee", role),
                new SqlParameter("@Active", active),
                new SqlParameter("@PassWordAccount", password)
                );
        }

        // Method to delete an employee
        public bool XoaNhanVien(ref string err, string id)
        {
            // Returning the result of the MyExecuteNonQuery method of the DAL class
            return db.MyExecuteNonQuery("spDeleteEmployee", CommandType.StoredProcedure, ref err,
                // Passing the parameter to the stored procedure
                new SqlParameter("@EmployeeID", id)
                );
        }
        public string LayConStr(string id, string pass)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds = db.ExecuteQueryDataSet("Select * from dbo.LoginCSDL('" + id + "','" + pass + "')", CommandType.Text, null);
            dt = ds.Tables[0];
            return dt.Rows[0].Field<string>(0);
        }
    }
}
