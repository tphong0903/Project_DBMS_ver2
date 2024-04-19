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
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class DBThongKe : DAL
    {
        public DAL db = null;
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;
        
        public int NumCustommers { get;private set; }
        public int NumSuppliers { get;private set; }
        public int NumProduct {  get;private set; }
        public List<KeyValuePair<string,int >> TopProductsList { get; private set; }
        public List<KeyValuePair<string,int>> UnderstocksList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrder { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set;}

        public DBThongKe()
        {
          
            db = new DAL();
        }
        private void GetNumberItems()
        {
            if (db.conn.State == ConnectionState.Closed)
                db.conn.Open(); 

            db.comm.CommandText = "select count(PhoneNumber) from Customers";
            NumCustommers = (int)db.comm.ExecuteScalar();

            db.comm.CommandText = "select count(Supplier_ID) from Suppliers";
            NumSuppliers = (int)db.comm.ExecuteScalar();

            db.comm.CommandText = "select count(Product_ID) from Products";
            NumProduct = (int)db.comm.ExecuteScalar();

            db.comm.CommandText = "select count(Order_ID) from Orders where OrderDate between @fromDate and @todate";
            db.comm.Parameters.Add("@fromDate", System.Data.SqlDbType.Date).Value = startDate;
            db.comm.Parameters.Add("@todate", System.Data.SqlDbType.Date).Value = endDate;
            NumOrder = (int)db.comm.ExecuteScalar();
            db.comm.Parameters.Clear();


            db.conn.Close(); 
        }

        private void GetOrderAnalisys()
        {
            if (db.conn.State == ConnectionState.Closed)
                db.conn.Open();
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;

            db.comm.CommandText = "SELECT * FROM TotalRevenue(@fromDate,@todate)";
            db.comm.Parameters.Add("@fromDate", System.Data.SqlDbType.Date).Value = startDate;
            db.comm.Parameters.Add("@todate", System.Data.SqlDbType.Date).Value = endDate;
            var reader = db.comm.ExecuteReader();
            db.comm.Parameters.Clear();

            var resultTable = new List<KeyValuePair<DateTime, int>>();
            while (reader.Read())
            {
                resultTable.Add(
                    new KeyValuePair<DateTime, int>((DateTime)reader[0], (int)reader[1])
                    );
                TotalRevenue += (int)reader[1];
            }
            reader.Close();

            db.comm.CommandText = @"SELECT * FROM TotalProfit(@fromDate,@todate)";
            db.comm.Parameters.Add("@fromDate", System.Data.SqlDbType.Date).Value = startDate;
            db.comm.Parameters.Add("@todate", System.Data.SqlDbType.Date).Value = endDate;
            var reader1 = db.comm.ExecuteReader();
            db.comm.Parameters.Clear();

            var resultTable1 = new List<KeyValuePair<DateTime, int>>();
            while (reader1.Read())
            { 
                decimal unitProfit = Convert.ToDecimal(reader1[1]);
                TotalProfit += unitProfit;
            }
            reader1.Close();
             //hahahah
            // Gộp ngày
            if (numberDays <= 1)
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
            //Group by Days
            else if (numberDays <= 30)
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
            //Group by Weeks
            else if (numberDays <= 92)
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
            //Group by Months
            else if (numberDays <= (365 * 2))
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
            //Group by Years
            else
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
        private void GetProductAnalisys()
        {
            if (db.conn.State == ConnectionState.Closed)
                db.conn.Open();
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderstocksList = new List<KeyValuePair<string, int>>();

            db.comm.CommandText = @"Select top 5 p.ProductName,sum(od.Quantity) as Q
                    from OrderDetails od 
                    join Products p on p.Product_ID  = od.Product_ID
                    join Orders o on o.Order_ID = od.Order_ID
                    where OrderDate between  @fromDate and @toDate
                    group by p.ProductName
                    Order by Q desc";
            db.comm.Parameters.Add("@fromDate", System.Data.SqlDbType.Date).Value = startDate;
            db.comm.Parameters.Add("@todate", System.Data.SqlDbType.Date).Value = endDate;
            SqlDataReader reader  = db.comm.ExecuteReader();
            db.comm.Parameters.Clear();

            while (reader.Read())
            {
                TopProductsList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
            }
            reader.Close();

            //get understock 
            db.comm.CommandText = @" select ProductName, Quantity
                                            from Products
                                            where Quantity <= 6";

            reader = db.comm.ExecuteReader();
            while (reader.Read())
            {
                UnderstocksList.Add(
                    new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
            }
            reader.Close();
            db.conn.Close();

        }
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;
                GetNumberItems();
                GetProductAnalisys();
                GetOrderAnalisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}
