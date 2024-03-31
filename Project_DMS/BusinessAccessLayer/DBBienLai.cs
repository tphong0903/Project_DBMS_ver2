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
    public class DBBienLai
    {
        DAL db = null;
        public DBBienLai()
        {
            db = new DAL();
        }
        // CRUD cho table ThanhPho
        public DataSet LayBienLai()
        {
            return db.ExecuteQueryDataSet(
                "select * from IMPORTS_VIEW", CommandType.Text, null);
        }
        public DataSet TimBienLai(string HD, string date)
        {
            return db.ExecuteQueryDataSet(
                "select * from Find_Import('" + HD + "','" + date + "')", CommandType.Text, null);
        }
        public DataSet SPCuaBienLai(string HD)
        {
            return db.ExecuteQueryDataSet(
                "select * from ProductOfImport('" + HD + "')", CommandType.Text, null);
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
