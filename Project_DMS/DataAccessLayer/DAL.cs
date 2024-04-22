using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer // Declaring the DataAccessLayer namespace
{
    public class DAL // Declaring the DAL class
    {
        // Connection string to the database
        public static SqlConnectionStringBuilder ConnStrBuilder = new SqlConnectionStringBuilder();
        public static int count = 0;
        // Declaring SqlConnection, SqlCommand, and SqlDataAdapter objects
        public SqlConnection conn = null;
        public SqlCommand comm = null;
        SqlDataAdapter da = null;
          
        // Constructor for the DAL class
        public DAL()
        {
            if(count == 0)
            {
                DAL.ConnStrBuilder.DataSource = "NGOT\\SQLEXPRESS";
                DAL.ConnStrBuilder.InitialCatalog = "QuanLyBanHangTheThao";
                DAL.ConnStrBuilder.IntegratedSecurity = true;
                DAL.ConnStrBuilder.Encrypt = false;
            }
            conn = new SqlConnection(DAL.ConnStrBuilder.ToString());
            comm = conn.CreateCommand();
        }
        // Method to execute a query and return a DataSet
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            // Closing the connection if it's already open
            if (conn.State == ConnectionState.Open)
                conn.Close();

            // Opening the connection
            conn.Open();
            // Setting command text and type
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            
            // Initializing SqlDataAdapter object
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();

            // Filling the DataSet with data from the query result
            da.Fill(ds);
            return ds;
        }

        // Method to execute non-query actions (insert, delete, update, stored procedure) and return success status
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false; // Initializing a flag to false

            // Closing the connection if it's already open
            if (conn.State == ConnectionState.Open)
                conn.Close();

            // Opening the connection
            conn.Open();

            // Clearing parameters and setting command text and type
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;

            // Adding parameters if provided
            if (param != null)
            {
                foreach (SqlParameter p in param)
                {
                    comm.Parameters.Add(p);
                }
            }

            try
            {
                // Executing the non-query command
                comm.ExecuteNonQuery();
                f = true; // Setting the flag to true indicating success
            }
            catch (SqlException ex)
            {
                // Catching any SQL exceptions and storing the error message
                error = ex.Message;
            }
            finally
            {
                // Closing the connection in any case
                conn.Close();
            }
            return f; // Returning the success status
        }
        public object ExecuteScalar(string strSQL, CommandType ct, params SqlParameter[] param)
        {
            // Declaring the result variable
            object result = null;

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                // Opening the connection
                conn.Open();

                // Clearing parameters and setting command text and type
                comm.CommandText = strSQL;
                comm.CommandType = ct;

                // Adding parameters if provided
                if (param != null)
                {
                    foreach (SqlParameter p in param)
                    {
                        comm.Parameters.Add(p);
                    }
                }

                // Executing the command and getting the scalar result
                result = comm.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                // Handling SQL exceptions
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            finally
            {
                // Closing the connection
                conn.Close();
            }

            // Returning the scalar result
            return result;
        }

    }
}