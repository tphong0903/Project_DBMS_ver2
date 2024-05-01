using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessAccessLayer
{
    // Defining a struct to represent revenue by date
    public struct RevenueByDate
    {
        public string Date { get; set; } // Date property
        public decimal TotalAmount { get; set; } // TotalAmount property
    }

    // Defining the DBThongKe class inheriting from the DAL class
    public class DBThongKe : DAL
    {
        // Declaring instance variables
        public DAL db = null;
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        // Declaring properties
        public int NumCustommers { get; private set; }
        public int NumSuppliers { get; private set; }
        public int NumProduct { get; private set; }
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> UnderstocksList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrder { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }

        // Constructor for the DBThongKe class
        public DBThongKe()
        {
            db = new DAL(); // Initializing the db instance with a new instance of the DAL class

        }

        // Method to get the number of customers, suppliers, and products
        private void GetNumberItems()
        {
            // Opening the database connection if it's closed
            if (db.conn.State == ConnectionState.Closed)
                db.conn.Open();

            // Retrieving the number of customers
            db.comm.CommandText = "select count(PhoneNumber) from Customers";
            NumCustommers = (int)db.comm.ExecuteScalar();

            // Retrieving the number of suppliers
            db.comm.CommandText = "select count(Supplier_ID) from Suppliers";
            NumSuppliers = (int)db.comm.ExecuteScalar();

            // Retrieving the number of products
            db.comm.CommandText = "select count(Product_ID) from Products";
            NumProduct = (int)db.comm.ExecuteScalar();

            // Retrieving the number of orders within a specific date range
            db.comm.CommandText = "select count(Order_ID) from Orders where OrderDate between @fromDate and @todate";
            db.comm.Parameters.Add("@fromDate", System.Data.SqlDbType.Date).Value = startDate;
            db.comm.Parameters.Add("@todate", System.Data.SqlDbType.Date).Value = endDate;
            NumOrder = (int)db.comm.ExecuteScalar();
            db.comm.Parameters.Clear();

            // Closing the database connection
            db.conn.Close();
        }

        // Method to perform analysis on orders
        private void GetOrderAnalisys()
        {
            // Opening the database connection if it's closed
            if (db.conn.State == ConnectionState.Closed)
                db.conn.Open();

            GrossRevenueList = new List<RevenueByDate>(); // Initializing the list of gross revenue

            // Initializing total profit and total revenue
            TotalProfit = 0;
            TotalRevenue = 0;

            // Retrieving total revenue by date
            db.comm.CommandText = "SELECT * FROM TotalRevenue(@fromDate,@todate)";
            db.comm.Parameters.Add("@fromDate", System.Data.SqlDbType.Date).Value = startDate;
            db.comm.Parameters.Add("@todate", System.Data.SqlDbType.Date).Value = endDate;
            var reader = db.comm.ExecuteReader();
            db.comm.Parameters.Clear();

            var resultTable = new List<KeyValuePair<DateTime, int>>(); // Initializing a list to hold results
            while (reader.Read())
            {
                resultTable.Add(new KeyValuePair<DateTime, int>((DateTime)reader[0], (int)reader[1])); // Adding results to the list
                TotalRevenue += (int)reader[1]; // Calculating total revenue
            }
            reader.Close();

            // Retrieving total profit by date
            db.comm.CommandText = @"SELECT * FROM TotalProfit(@fromDate,@todate)";
            db.comm.Parameters.Add("@fromDate", System.Data.SqlDbType.Date).Value = startDate;
            db.comm.Parameters.Add("@todate", System.Data.SqlDbType.Date).Value = endDate;
            var reader1 = db.comm.ExecuteReader();
            db.comm.Parameters.Clear();

            while (reader1.Read())
            {
                decimal unitProfit = Convert.ToDecimal(reader1[1]);
                TotalProfit += unitProfit; // Calculating total profit
            }
            reader1.Close();

            // Grouping revenue by date
            if (numberDays <= 1) // Group by hour
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("hh tt")
                                    into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }
            else if (numberDays <= 30) // Group by day
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("dd MMM")
                                    into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }
            else if (numberDays <= 92) // Group by week
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                        orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                    into order
                                    select new RevenueByDate
                                    {
                                        Date = "Week " + order.Key.ToString(),
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }
            else if (numberDays <= (365 * 2)) // Group by month
            {
                bool isYear = numberDays <= 365 ? true : false;
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("MMM yyyy")
                                    into order
                                    select new RevenueByDate
                                    {
                                        Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }
            else // Group by year
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("yyyy")
                                    into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }
            db.conn.Close();
        }
        // Method to perform analysis on products
        private void GetProductAnalisys()
        {
            // Opening the database connection if it's closed
            if (db.conn.State == ConnectionState.Closed)
                db.conn.Open();

            TopProductsList = new List<KeyValuePair<string, int>>(); // Initializing the list of top products
            UnderstocksList = new List<KeyValuePair<string, int>>(); // Initializing the list of understocked products

            // Retrieving top 5 products by sales
            db.comm.CommandText = @"SELECT * FROM Top5Product(@fromDate,@todate)";
            db.comm.Parameters.Add("@fromDate", System.Data.SqlDbType.Date).Value = startDate;
            db.comm.Parameters.Add("@todate", System.Data.SqlDbType.Date).Value = endDate;
            SqlDataReader reader = db.comm.ExecuteReader();
            db.comm.Parameters.Clear();

            while (reader.Read())
            {
                TopProductsList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1])); // Adding top products to the list
            }
            reader.Close();

            // Retrieving understocked products
            db.comm.CommandText = @" select ProductName, Quantity
                                            from Products
                                            where Quantity <= 6";

            reader = db.comm.ExecuteReader();
            while (reader.Read())
            {
                UnderstocksList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1])); // Adding understocked products to the list
            }
            reader.Close();

            db.conn.Close(); // Closing the database connection
        }

        // Method to load data for analysis within a specified date range
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            // Setting the end date to the last second of the day
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);

            // Checking if the start date or end date has changed
            if (startDate != this.startDate || endDate != this.endDate)
            {
                // Updating instance variables
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                // Performing data analysis
                GetNumberItems();
                GetProductAnalisys();
                GetOrderAnalisys();

                // Logging the refresh status
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                // Logging that data is not refreshed
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}
