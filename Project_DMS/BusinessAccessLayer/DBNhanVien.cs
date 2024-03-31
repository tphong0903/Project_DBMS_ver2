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
    public class DBNhanVien
    {
        DAL db = null;
        public DBNhanVien()
        {
            db = new DAL();
        }
        // CRUD cho table ThanhPho
        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet(
                "select * from EMPLOYEES_ACTIVE_VIEW", CommandType.Text, null);
        }
        public DataSet LayALLNhanVien()
        {
            return db.ExecuteQueryDataSet(
                "select * from EMPLOYEES_All_VIEW", CommandType.Text, null);
        }
        public DataSet TimNhanVien(string ID,string  name)
        {
            return db.ExecuteQueryDataSet(
                "select * from Find_Employee(N'"+ID+"',N'"+name+"')", CommandType.Text, null);
        }
        public DataSet TimAllNhanVien(string ID)
        {
            return db.ExecuteQueryDataSet(
                "select * from EMPLOYEES_All_VIEW where EmployeeID like '%'+'"+ID+"'+'%'", CommandType.Text, null);
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
