using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
//
using DataAccessLayer;

namespace BusinessAccessLayer // Declaring the BusinessAccessLayer namespace
{
    public class DBNhaCungCap // Declaring the DBNhaCungCap class
    {
        DAL db = null; // Declaring an instance of the DAL class and initializing it to null

        // Constructor for the DBNhaCungCap class
        public DBNhaCungCap()
        {
            db = new DAL(); // Initializing the db instance with a new instance of the DAL class
        }

        // Method to retrieve suppliers
        public DataSet LayNhaCungCap()
        {
            // Returning the result of the ExecuteQueryDataSet method of the DAL class
            return db.ExecuteQueryDataSet("select * from SUPPLIER_VIEW", CommandType.Text, null);
        }

        // Method to search for suppliers by ID and name
        public DataSet TimNhaCungCap(string ID, string name)
        {
            // Returning the result of the ExecuteQueryDataSet method of the DAL class
            return db.ExecuteQueryDataSet("select * from Find_Supplier('" + ID + "',N'" + name + "')", CommandType.Text, null);
        }

        // Method to retrieve products associated with a supplier
        public DataSet SPCuaNhaCungCap(string ID)
        {
            // Returning the result of the ExecuteQueryDataSet method of the DAL class
            return db.ExecuteQueryDataSet("select * from ProductOfSupplier('" + ID + "')", CommandType.Text, null);
        }

        // Method to add a new supplier
        public bool ThemNhaCungCap(ref string err, string Supplier_ID, string CompanyName,
             string PhoneNumber, string AddressSupplier, string Email)
        {
            // Returning the result of the MyExecuteNonQuery method of the DAL class
            return db.MyExecuteNonQuery("spInsertSupplier", CommandType.StoredProcedure, ref err,
                // Passing the parameters to the stored procedure
                new SqlParameter("@Supplier_ID", Supplier_ID),
                new SqlParameter("@CompanyName", CompanyName),
                new SqlParameter("@PhoneNumber", PhoneNumber),
                new SqlParameter("@AddressSupplier", AddressSupplier),
                new SqlParameter("@Email", Email));
        }

        // Method to update a supplier
        public bool CapNhatNhaCungCap(ref string err, string Supplier_ID, string CompanyName,
            string PhoneNumber, string AddressSupplier, string Email)
        {
            // Returning the result of the MyExecuteNonQuery method of the DAL class
            return db.MyExecuteNonQuery("spUpdateSupplier", CommandType.StoredProcedure, ref err,
                // Passing the parameters to the stored procedure
                new SqlParameter("@Supplier_ID", Supplier_ID),
                new SqlParameter("@CompanyName", CompanyName),
                new SqlParameter("@PhoneNumber", PhoneNumber),
                new SqlParameter("@AddressSupplier", AddressSupplier),
                new SqlParameter("@Email", Email));
        }
    }
}
