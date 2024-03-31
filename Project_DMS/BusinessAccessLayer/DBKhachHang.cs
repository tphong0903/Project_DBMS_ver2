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
    public class DBKhachHang
    {
        DAL db = null;
        public DBKhachHang()
        {
            db = new DAL();
        }
        // CRUD cho table ThanhPho
        public DataSet LayKhachHang()
        {
            return db.ExecuteQueryDataSet(
                "select * from View_Customer", CommandType.Text, null);
        }
        public DataSet TimKhachHang(string Phone, string Name)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM Find_Customer('"+Phone+"',N'"+Name+"')",
                CommandType.Text,null);
        }
        public DataSet SPcuaKhachHang(string Phone)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM ProductOfCustomer('" + Phone + "')",
                CommandType.Text, null);
        }
        public bool XoaThanhPho(ref string err, string ThanhPho)
        {
            return db.MyExecuteNonQuery("spXoaThanhPho",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@ThanhPho", ThanhPho));
        }
        public bool CapNhatThanhPho(ref string err, string ThanhPho, string TenThanhPho)
        {
            return db.MyExecuteNonQuery("spCapNhatThanhPho",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@ThanhPho", ThanhPho),
                new SqlParameter("@TenThanhPho", TenThanhPho));
        }

    }
}
