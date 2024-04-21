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
    public class DBBienLai // Declaring the DBBienLai class
    {
        DAL db = null; // Declaring an instance of the DAL class and initializing it to null
        public DBBienLai() // Constructor for the DBBienLai class
        {
            db = new DAL(); // Initializing the db instance with a new instance of the DAL class
        }

        // Method to retrieve receipts
        public DataSet LayBienLai()
        {
            return db.ExecuteQueryDataSet( // Returning the result of the ExecuteQueryDataSet method of the DAL class
                "select * from IMPORTS_VIEW", CommandType.Text, null); // SQL query to select all data from the IMPORTS_VIEW view
        }

        // Method to search for receipts by ID and date
        public DataSet TimBienLai(string HD, string date)
        {
            return db.ExecuteQueryDataSet( // Returning the result of the ExecuteQueryDataSet method of the DAL class
                "select * from Find_Import('" + HD + "','" + date + "')", CommandType.Text, null); // SQL query to search for a receipt using the Find_Import stored procedure with parameters HD and date
        }

        // Method to retrieve products associated with a receipt
        public DataSet SPCuaBienLai(string HD)
        {
            return db.ExecuteQueryDataSet( // Returning the result of the ExecuteQueryDataSet method of the DAL class
                "select * from ProductOfImport('" + HD + "')", CommandType.Text, null); // SQL query to select products associated with a receipt using the ProductOfImport stored procedure with parameter HD
        }

        // Method to add a new receipt
        public bool ThemBienLai(ref string err, string Import_ID, string Supplier_ID,
             DateTime ImportDay, int Total)
        {
            return db.MyExecuteNonQuery("spInsertImport", // Returning the result of the MyExecuteNonQuery method of the DAL class
                CommandType.StoredProcedure, ref err, // Calling the spInsertImport stored procedure to add a new receipt
                new SqlParameter("@Import_ID", Import_ID), // Passing the parameters to the stored procedure
                new SqlParameter("@Supplier_ID", Supplier_ID),
                new SqlParameter("@ImportDay", ImportDay),
                new SqlParameter("@Total", Total));
        }

        // Method to update a receipt
        public bool CapNhatBienLai(ref string err, string Import_ID, string Supplier_ID,
            DateTime ImportDay, int Total)
        {
            return db.MyExecuteNonQuery("spInsertImport", // Returning the result of the MyExecuteNonQuery method of the DAL class
                CommandType.StoredProcedure, ref err, // Calling the spInsertImport stored procedure to update a receipt
                new SqlParameter("@Import_ID", Import_ID), // Passing the parameters to the stored procedure
                new SqlParameter("@Supplier_ID", Supplier_ID),
                new SqlParameter("@ImportDay", ImportDay),
                new SqlParameter("@Total", Total));
        }

        // Method to add details of a receipt
        public bool ThemChiTietBienLai(ref string err, string Import_ID, string Product_ID,
            int Quantity, int Unitcost)
        {
            return db.MyExecuteNonQuery("spInsertImportDetail", // Returning the result of the MyExecuteNonQuery method of the DAL class
                CommandType.StoredProcedure, ref err, // Calling the spInsertImportDetail stored procedure to add details of a receipt
                new SqlParameter("@Import_ID", Import_ID), // Passing the parameters to the stored procedure
                new SqlParameter("@Product_ID", Product_ID),
                new SqlParameter("@Quantity", Quantity),
                new SqlParameter("@Unitcost", Unitcost));
        }
        public bool XoaBienLai(ref string err, string Import_ID)
        {
            return db.MyExecuteNonQuery("spDeleteImport", // Returning the result of the MyExecuteNonQuery method of the DAL class
                CommandType.StoredProcedure, ref err, // Calling the spInsertImport stored procedure to update a receipt
                new SqlParameter("@Import_ID", Import_ID));
        }
    }
}
