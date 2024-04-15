using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
//
using DataAccessLayer;
using Microsoft.SqlServer.Server;
using System.Net;
using System.Xml.Linq;

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
        public bool ThemNhanVien(ref string err, string id, string name,DateTime birthday, string gender, string address,string sdt,string role,int active, string password )
        {
            return db.MyExecuteNonQuery("spInsertEmployee",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@EmployeeID", id),
                new SqlParameter("@NameEmployee", name),
                new SqlParameter("@Birthday", birthday),
                new SqlParameter("@Gender", gender),
                new SqlParameter("@AddressEmployee", address),
                new SqlParameter("@PhoneNumber", sdt),
                new SqlParameter("@RoleEmployee", role),
                new SqlParameter("@Active", active),
                new SqlParameter("@PassWordAccount", password)
                );
        }
        public bool CapNhatNhanVien(ref string err, string id, string name, DateTime birthday, string gender, string address, string sdt, string role, int active, string password)
        {
            return db.MyExecuteNonQuery("spUpdateEmployee",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@EmployeeID", id),
                new SqlParameter("@NameEmployee", name),
                new SqlParameter("@Birthday", birthday),
                new SqlParameter("@Gender", gender),
                new SqlParameter("@AddressEmployee", address),
                new SqlParameter("@PhoneNumber", sdt),
                new SqlParameter("@RoleEmployee", role),
                new SqlParameter("@Active", active),
                new SqlParameter("@PassWordAccount", password)
                );
        }

    }
}
