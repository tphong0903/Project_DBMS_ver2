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
    public class DBHoaDon // Declaring the DBHoaDon class
    {
        DAL db = null; // Declaring an instance of the DAL class and initializing it to null
        public DBHoaDon() // Constructor for the DBHoaDon class
        {
            db = new DAL(); // Initializing the db instance with a new instance of the DAL class
        }

        // Method to retrieve bills
        public DataSet LayHoaDon()
        {
            return db.ExecuteQueryDataSet( // Returning the result of the ExecuteQueryDataSet method of the DAL class
                "select * from BILLS_VIEW", CommandType.Text, null); // SQL query to select all data from the BILLS_VIEW view
        }
        public DataSet LayGiamGia(string s)
        {
            return db.ExecuteQueryDataSet( // Returning the result of the ExecuteQueryDataSet method of the DAL class
                "select * from Discounts where DiscountCode = '"+s+"'", CommandType.Text, null); // SQL query to select all data from the BILLS_VIEW view
        }
        // Method to search for bills by ID and date
        public DataSet TimHoaDon(string HD, string date)
        {
            return db.ExecuteQueryDataSet( // Returning the result of the ExecuteQueryDataSet method of the DAL class
                "select * from Find_Order('" + HD + "','" + date + "')", CommandType.Text, null); // SQL query to search for a bill using the Find_Order stored procedure with parameters HD and date
        }

        // Method to retrieve products associated with a bill
        public DataSet SPCuaHoaDon(string HD)
        {
            return db.ExecuteQueryDataSet( // Returning the result of the ExecuteQueryDataSet method of the DAL class
                "select * from ProductOfOrder('" + HD + "')", CommandType.Text, null); // SQL query to select products associated with a bill using the ProductOfOrder stored procedure with parameter HD
        }

        // Method to add a new bill
        public bool ThemHoaDon(ref string err, string order_ID, string sdt, string nv,
             DateTime orderdate, int Total, string magiam)
        {
            return db.MyExecuteNonQuery("spInsertOrder", // Returning the result of the MyExecuteNonQuery method of the DAL class
                CommandType.StoredProcedure, ref err, // Calling the spInsertOrder stored procedure to add a new bill
                new SqlParameter("@Order_ID", order_ID), // Passing the parameters to the stored procedure
                new SqlParameter("@PhoneNumber", sdt),
                new SqlParameter("@EmployeeID", nv),
                new SqlParameter("@OrderDate", orderdate),
                new SqlParameter("@Total", Total),
                new SqlParameter("@DiscountCode", magiam));
        }

        // Method to update a bill
        public bool CapNhatHoaDon(ref string err, string order_ID, string sdt, string nv,
             DateTime orderdate, int Total, string magiam)
        {
            return db.MyExecuteNonQuery("spUpdateOrder", // Returning the result of the MyExecuteNonQuery method of the DAL class
                CommandType.StoredProcedure, ref err, // Calling the spUpdateOrder stored procedure to update a bill
                new SqlParameter("@Order_ID", order_ID), // Passing the parameters to the stored procedure
                new SqlParameter("@PhoneNumber", sdt),
                new SqlParameter("@EmployeeID", nv),
                new SqlParameter("@OrderDate", orderdate),
                new SqlParameter("@Total", Total),
                new SqlParameter("@DiscountCode", magiam));
        }

        // Method to add details of a bill
        public bool ThemChiTietHoaDon(ref string err, string Order_ID, string Product_ID,
            int Quantity)
        {
            return db.MyExecuteNonQuery("spInsertOrderDetail", // Returning the result of the MyExecuteNonQuery method of the DAL class
                CommandType.StoredProcedure, ref err, // Calling the spInsertOrderDetail stored procedure to add details of a bill
                new SqlParameter("@Order_ID", Order_ID), // Passing the parameters to the stored procedure
                new SqlParameter("@Product_ID", Product_ID),
                new SqlParameter("@Quantity", Quantity));
        }
        public bool XoaHoaDon(ref string err, string Order_ID)
        {
            Console.WriteLine(Order_ID);
            return db.MyExecuteNonQuery("spDeleteOrder", // Returning the result of the MyExecuteNonQuery method of the DAL class
                CommandType.StoredProcedure, ref err, // Calling the spInsertOrderDetail stored procedure to add details of a bill
                new SqlParameter("@Order_ID", Order_ID));
        }
    }
}
