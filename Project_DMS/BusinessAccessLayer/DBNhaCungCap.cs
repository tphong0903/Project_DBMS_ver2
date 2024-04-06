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
        public bool ThemNhaCungCap(ref string err, string Supplier_ID, string CompanyName,
             string PhoneNumber, string AddressSupplier, string Email)
        {
            return db.MyExecuteNonQuery("spInsertSupplier",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Supplier_ID", Supplier_ID),
                new SqlParameter("@CompanyName", CompanyName),
                new SqlParameter("@PhoneNumber", PhoneNumber),
                new SqlParameter("@AddressSupplier", AddressSupplier),
                new SqlParameter("@Email", Email));
        }
        public bool CapNhatNhaCungCap(ref string err, string Supplier_ID, string CompanyName,
            string PhoneNumber, string AddressSupplier, string Email)
        {
            return db.MyExecuteNonQuery("spUpdateSupplier",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Supplier_ID", Supplier_ID),
                new SqlParameter("@CompanyName", CompanyName),
                new SqlParameter("@PhoneNumber", PhoneNumber),
                new SqlParameter("@AddressSupplier", AddressSupplier),
                new SqlParameter("@Email", Email));
        }

    }
}
