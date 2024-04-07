using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
//
using DataAccessLayer;
using System.Xml.Linq;

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
        public DataSet LaySanPham()
        {
            return db.ExecuteQueryDataSet(
                "select Product_ID, ProductName,UnitPrice,Quantity  from View_Product", CommandType.Text, null);
        }
        public DataSet LaySanPhamChoFormBienLai()
        {
            return db.ExecuteQueryDataSet(
                "select Product_ID, ProductName from View_Product", CommandType.Text, null);
        }
        public bool SuaHinhAnh(string nameImg, int ma, string err)
        {
            return db.MyExecuteNonQuery($"UPDATE PictureProduct SET Pic_Name = '{nameImg}' WHERE Pic_ID = {ma}", CommandType.Text, ref err, null);

        }

        public bool ThemHinhAnh(string nameImg, string err)
        {
            return db.MyExecuteNonQuery($"INSERT INTO PictureProduct(Pic_Name) VALUES ('{nameImg}')", CommandType.Text, ref err, null);
        }

        public DataSet LayDanhMuc()
        {
            return db.ExecuteQueryDataSet(
                "select * from Categories", CommandType.Text, null);
        }
        public DataSet LayThuongHieu()
        {
            return db.ExecuteQueryDataSet(
                "select * from Brands", CommandType.Text, null);
        }

        public DataSet TimSanPham(string a, string b, string c)
        {
            return db.ExecuteQueryDataSet(
                "SELECT * FROM Find_Product(N'" + a + "',N'" + b + "',N'" + c + "')",
                CommandType.Text, null);
        }
        public DataSet ChiTietSanPham(string a)
        {
            return db.ExecuteQueryDataSet(
                "SELECT * FROM View_Product where Product_ID = N'" + a + "'",
                CommandType.Text, null);
        }
        public bool XoaThanhPho(ref string err, string ThanhPho)
        {
            return db.MyExecuteNonQuery("spXoaThanhPho",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@ThanhPho", ThanhPho));
        }
        public bool CapNhatSanPham(ref string err, string ma, string ten, int gia, string th, string dm, int sl, int idImg)
        {
            return db.MyExecuteNonQuery("spUpdateProduct",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Product_ID", ma),
                new SqlParameter("@ProductName", ten),
                new SqlParameter("@UnitPrice", gia),
                new SqlParameter("@Quantity", sl),
                new SqlParameter("@BrandName", th),
                new SqlParameter("@CategoryName", dm),
                new SqlParameter("@Pic_ID", idImg)
                );
        }
        public bool TaoSanPham(ref string err, string ma, string ten, int gia, string th, string dm, int sl, string Img)
        {
            Console.WriteLine(ma);
            Console.WriteLine(ten);
            Console.WriteLine(gia);
            Console.WriteLine(th);
            Console.WriteLine(dm);
            Console.WriteLine(sl);
            Console.WriteLine(Img);

            return db.MyExecuteNonQuery("spInsertProduct",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Product_ID", ma),
                new SqlParameter("@ProductName", ten),
                new SqlParameter("@UnitPrice", gia),
                new SqlParameter("@Quantity", sl),
                new SqlParameter("@BrandName", th),
                new SqlParameter("@CategoryName", dm),
                new SqlParameter("@Pic_Name", Img)
                );
        }

    }
}
