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
    public class DBSanPham
    {
        DAL db = null;
        public DBSanPham()
        {
            db = new DAL();
        }
        // CRUD cho table ThanhPho
        public DataSet LayThanhPho()
        {
            return db.ExecuteQueryDataSet(
                "select * from Product", CommandType.Text, null);
        }
        public DataSet LayDanhMuc()
        {
            return db.ExecuteQueryDataSet(
                "select * from Category", CommandType.Text, null);
        }
        public DataSet LayThuongHieu()
        {
            return db.ExecuteQueryDataSet(
                "select * from Brand", CommandType.Text, null);
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
