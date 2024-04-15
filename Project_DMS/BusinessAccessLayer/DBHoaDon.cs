using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
//
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class DBHoaDon
    {
        DAL db = null;
        public DBHoaDon()
        {
            db = new DAL();
        }
        // CRUD cho table ThanhPho
        public DataSet LayHoaDon()
        {
            return db.ExecuteQueryDataSet(
                "select * from BILLS_VIEW", CommandType.Text, null);
        }
        public DataSet TimHoaDon(string HD,string date)
        {
            return db.ExecuteQueryDataSet(
                "select * from Find_Order('"+HD+"','"+date+"')", CommandType.Text, null);
        }
        public DataSet SPCuaHoaDon(string HD )
        {
            return db.ExecuteQueryDataSet(
                "select * from ProductOfOrder('" + HD + "')", CommandType.Text, null);
        }
        public bool ThemHoaDon(ref string err, string order_ID, string sdt,string nv,
             DateTime orderdate, int Total,string magiam)
        {
            return db.MyExecuteNonQuery("spInsertOrder",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Order_ID", order_ID),
                new SqlParameter("@PhoneNumber", sdt),
                new SqlParameter("@EmployeeID", nv),
                new SqlParameter("@OrderDate", orderdate),
                new SqlParameter("@Total", Total),
                new SqlParameter("@DiscountCode", magiam));
        }
        public bool CapNhatHoaDon(ref string err, string order_ID, string sdt, string nv,
             DateTime orderdate, int Total, string magiam)
        {
            return db.MyExecuteNonQuery("spUpdateOrder",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Order_ID", order_ID),
                new SqlParameter("@PhoneNumber", sdt),
                new SqlParameter("@EmployeeID", nv),
                new SqlParameter("@OrderDate", orderdate),
                new SqlParameter("@Total", Total),
                new SqlParameter("@DiscountCode", magiam));
        }
        public bool ThemChiTietHoaDon(ref string err, string Order_ID, string Product_ID,
            int Quantity)
        {
            return db.MyExecuteNonQuery("spInsertOrderDetail",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Order_ID", Order_ID),
                new SqlParameter("@Product_ID", Product_ID),
                new SqlParameter("@Quantity", Quantity));
        }
    }
}
