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
        public bool ThemBienLai(ref string err, string Import_ID, string Supplier_ID,
             DateTime ImportDay, int Total)
        {
            return db.MyExecuteNonQuery("spInsertImport",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Import_ID", Import_ID),
                new SqlParameter("@Supplier_ID", Supplier_ID),
                new SqlParameter("@ImportDay", ImportDay),
                new SqlParameter("@Total", Total));
        }
        public bool CapNhatBienLai(ref string err, string Import_ID, string Supplier_ID,
            DateTime ImportDay, int Total)
        {
            return db.MyExecuteNonQuery("spInsertImport",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Import_ID", Import_ID),
                new SqlParameter("@Supplier_ID", Supplier_ID),
                new SqlParameter("@ImportDay", ImportDay),
                new SqlParameter("@Total", Total));
        }
        public bool ThemChiTietBienLai(ref string err, string Import_ID, string Product_ID,
            int Quantity, int Unitcost)
        {
            return db.MyExecuteNonQuery("spInsertImportDetail",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Import_ID", Import_ID),
                new SqlParameter("@Product_ID", Product_ID),
                new SqlParameter("@Quantity", Quantity),
                new SqlParameter("@Unitcost", Unitcost));
        }

    }
}
