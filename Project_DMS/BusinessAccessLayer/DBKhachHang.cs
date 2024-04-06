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


        public bool XoaKhachHang(ref string err, string sdt)
        {
            return db.MyExecuteNonQuery("spDeleteCustomer",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@PhoneNumber", sdt));
        }
        public bool ThemKhachHang(ref string err, string sdt ,string name, DateTime birthday, string gender, int point)
        {
            return db.MyExecuteNonQuery("spInsertCustomer",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@PhoneNumber", sdt),
                new SqlParameter("@NameCustomer", name),
                new SqlParameter("@Birthday", birthday),
                new SqlParameter("@Gender", gender),
                new SqlParameter("@Point", point)
                );
        }
        public bool CapNhatKhachHang(ref string err, string sdt ,string name, DateTime birthday, string gender, int point)
        {
            return db.MyExecuteNonQuery("spUpdateCustomer",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@PhoneNumber", sdt),
                new SqlParameter("@NameCustomer", name),
                new SqlParameter("@Birthday", birthday),
                new SqlParameter("@Gender", gender),
                new SqlParameter("@Point", point)
                );
        }

    }
}
