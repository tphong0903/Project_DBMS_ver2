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
        DAL db = null;
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;
        
        public int NumCustommers { get;private set; }
        public int NumSuppliers { get;private set; }
        public int NumProduct {  get;private set; }
        public List<KeyValuePair<string,int >> TopProductList { get; private set; }
        public List<KeyValuePair<string,int>> UnderstockList { get; private set; }
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
            DataTable dt = new DataTable();

            DataSet a = db.ExecuteQueryDataSet(
                "select count(PhoneNumber) from Customers", CommandType.Text, null);
            dt.Clear();
            dt = a.Tables[0];
            NumCustommers = dt.Rows[0].Field<int>(0);

            a = db.ExecuteQueryDataSet(
                "select count(Supplier_ID) from Suppliers", CommandType.Text, null);
            dt.Clear();
            dt = a.Tables[0];
            NumSuppliers = dt.Rows[0].Field<int>(0);


            a = db.ExecuteQueryDataSet(
                "select count(Product_ID) from Products", CommandType.Text, null);
            dt.Clear();
            dt = a.Tables[0];
            NumProduct = dt.Rows[0].Field<int>(0);


            //DateTime a = DateTime.Parse(Ngay.Text);
            //if (a.Month < 10)
            //    date = a.Year + "-0" + a.Month + "-" + a.Day;
            //else
            //    date = a.Year + "-" + a.Month + "-" + a.Day;


            a = db.ExecuteQueryDataSet(
               "select count(Product_ID) from Orders where OrderDate between @fromDate and @todate", CommandType.Text,
                new SqlParameter("@fromDate", startDate),
                new SqlParameter("@toDate", endDate));
            dt.Clear();
            dt = a.Tables[0];
            NumOrder = dt.Rows[0].Field<int>(0);
          
                

        }
        private void GetOrderAnaliys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;

            var reader = db.ExecuteReader(
                "select OrderDate, SUM(Total) From Orders where OrderDate between @fromDate and @toDate group by OrderDate",
                CommandType.Text,
                new SqlParameter("@fromDate", startDate),
                new SqlParameter("@toDate", endDate));
            var resultTable = new List<KeyValuePair<DateTime, decimal>>();
            while (reader.Read())
            {
                resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1]));
                TotalRevenue= (decimal)reader[0];
            }
            TotalProfit = TotalProfit * 0.2m;
            reader.Close();

            // Gộp ngày
            if(numberDays<=30)
            {
                foreach (var item in resultTable)
                {
                    GrossRevenueList.Add(new RevenueByDate()
                    {
                        Date = item.Key.ToString("dd MMM"),
                        TotalAmount=item.Value
                    }) ;
                    
                }
            }
            // gop theo tuan
            else if(numberDays<= 92)
            {
                GrossRevenueList = (from orderList in resultTable 
                                    group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                        orderList.Key,CalendarWeekRule.FirstDay,DayOfWeek.Monday )
                                    into order
                                        select new RevenueByDate
                                        {
                                            Date = "Week "+ order.Key.ToString(),
                                            TotalAmount = order.Sum(amount => amount.Value)
                                        }).ToList();
                foreach (var item in resultTable)
                {
                    GrossRevenueList.Add(new RevenueByDate()
                    {
                        Date = item.Key.ToString("dd MMM"),
                        TotalAmount = item.Value
                    });

                }
            }
            else if( numberDays<=(365*2))
            {
                bool isYear = numberDays <=365 ? true : false;
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("MMM YYYY")
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = isYear ? order.Key.Substring(0,order.Key.IndexOf(" ")): order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();

            }
            else
            {
               
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("YYYY")
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();

            }
        }
        private void GetProductAnalisys()
        {
            TopProductList = new List<KeyValuePair<string, int>>();
            UnderstockList = new List<KeyValuePair<string, int>>();
            
            var reader  = db.ExecuteReader(
                @"  Select top 5 p.ProductName,sum(od.Quantity) as Q
                    from OrderDetails od 
                    join Products p on p.Product_ID  = od.Product_ID
                    join Orders o on o.Order_ID = od.Order_ID
                    where OrderDate between  @fromDate and @toDate
                    group by p.ProductName
                    Order by Q desc", CommandType.Text, 
                new SqlParameter("@fromDate",startDate),
                new SqlParameter("@toDate", endDate));
            while(reader.Read())
            {
                TopProductList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
            }
            reader.Close();

            //get understock 
             reader = db.ExecuteReader(
                @"  select p.ProductName, Quantity
                    from Products p
                    where Quantity <=5 ", CommandType.Text,null);
            while (reader.Read())
            {
                UnderstockList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
            }
            reader.Close();

        }
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year,endDate.Month,endDate.Day,endDate.Hour,endDate.Minute,59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetProductAnalisys();
                GetOrderAnaliys();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
