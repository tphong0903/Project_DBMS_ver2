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
    public class DBNhaCungCap
    {
        DAL db = null;
        public DBNhaCungCap()
        {
            db = new DAL();
        }
        // CRUD cho table ThanhPho
        public DataSet LayNhaCungCap()
        {
            return db.ExecuteQueryDataSet(
                "select * from SUPPLIER_VIEW", CommandType.Text, null);
        }
        public DataSet TimNhaCungCap(string ID, string name)
        {
            return db.ExecuteQueryDataSet(
                "select * from Find_Supplier('" + ID + "',N'" + name + "')", CommandType.Text, null);
        }
        public DataSet SPCuaNhaCungCap(string ID)
        {
            return db.ExecuteQueryDataSet(
                "select * from ProductOfSupplier('" + ID + "')", CommandType.Text, null);
        }
        public bool ThemThanhPho(ref string err, string ThanhPho, string TenThanhPho)
        {
            return db.MyExecuteNonQuery("spThemThanhPho",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@ThanhPho", ThanhPho),
                new SqlParameter("@TenThanhPho", TenThanhPho));
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
