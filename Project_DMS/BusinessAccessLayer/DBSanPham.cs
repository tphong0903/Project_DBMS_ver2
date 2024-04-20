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
namespace BusinessAccessLayer // Declaring the BusinessAccessLayer namespace
{
    public class DBSanPham // Declaring the DBSanPham class
    {
        DAL db = null; // Declaring an instance of the DAL class and initializing it to null

        // Constructor for the DBSanPham class
        public DBSanPham()
        {
            db = new DAL(); // Initializing the db instance with a new instance of the DAL class

        }

        // Method to retrieve products for general view
        public DataSet LaySanPham()
        {
            // Returning the result of the ExecuteQueryDataSet method of the DAL class
            return db.ExecuteQueryDataSet("select Product_ID, ProductName, UnitPrice, Quantity from View_Product", CommandType.Text, null);
        }

        // Method to retrieve products for receipt form
        public DataSet LaySanPhamChoFormBienLai()
        {
            // Returning the result of the ExecuteQueryDataSet method of the DAL class
            return db.ExecuteQueryDataSet("select Product_ID, ProductName from View_Product", CommandType.Text, null);
        }

        // Method to update image of a product
        public bool SuaHinhAnh(string nameImg, int ma, string err)
        {
            // Returning the result of the MyExecuteNonQuery method of the DAL class
            return db.MyExecuteNonQuery($"UPDATE PictureProduct SET Pic_Name = '{nameImg}' WHERE Pic_ID = {ma}", CommandType.Text, ref err, null);
        }

        // Method to add image for a product
        public bool ThemHinhAnh(string nameImg, string err)
        {
            // Returning the result of the MyExecuteNonQuery method of the DAL class
            return db.MyExecuteNonQuery($"INSERT INTO PictureProduct(Pic_Name) VALUES ('{nameImg}')", CommandType.Text, ref err, null);
        }

        // Method to retrieve categories
        public DataSet LayDanhMuc()
        {
            // Returning the result of the ExecuteQueryDataSet method of the DAL class
            return db.ExecuteQueryDataSet("select * from Categories", CommandType.Text, null);
        }

        // Method to retrieve brands
        public DataSet LayThuongHieu()
        {
            // Returning the result of the ExecuteQueryDataSet method of the DAL class
            return db.ExecuteQueryDataSet("select * from Brands", CommandType.Text, null);
        }

        // Method to search for products by name, category, and brand
        public DataSet TimSanPham(string a, string b, string c)
        {
            // Returning the result of the ExecuteQueryDataSet method of the DAL class
            return db.ExecuteQueryDataSet("SELECT * FROM Find_Product(N'" + a + "',N'" + b + "',N'" + c + "')", CommandType.Text, null);
        }

        // Method to retrieve product details by ID
        public DataSet ChiTietSanPham(string a)
        {
            // Returning the result of the ExecuteQueryDataSet method of the DAL class
            return db.ExecuteQueryDataSet("SELECT * FROM View_Product where Product_ID = N'" + a + "'", CommandType.Text, null);
        }

        // Method to update product details
        public bool CapNhatSanPham(ref string err, string ma, string ten, int gia, string th, string dm, int sl, int idImg)
        {
            // Returning the result of the MyExecuteNonQuery method of the DAL class
            return db.MyExecuteNonQuery("spUpdateProduct", CommandType.StoredProcedure, ref err,
                // Passing the parameters to the stored procedure
                new SqlParameter("@Product_ID", ma),
                new SqlParameter("@ProductName", ten),
                new SqlParameter("@UnitPrice", gia),
                new SqlParameter("@Quantity", sl),
                new SqlParameter("@BrandName", th),
                new SqlParameter("@CategoryName", dm),
                new SqlParameter("@Pic_ID", idImg)
            );
        }

        // Method to add a new product
        public bool TaoSanPham(ref string err, string ma, string ten, int gia, string th, string dm, int sl, string Img)
        {
            // Returning the result of the MyExecuteNonQuery method of the DAL class
            return db.MyExecuteNonQuery("spInsertProduct", CommandType.StoredProcedure, ref err,
                // Passing the parameters to the stored procedure
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
