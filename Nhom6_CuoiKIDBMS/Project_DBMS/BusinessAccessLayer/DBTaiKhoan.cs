using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class DBTaiKhoan
    {
        public static string ConnStr = "";
        DBNhanVien dbnv = null;
        public DBTaiKhoan() 
        {
            dbnv = new DBNhanVien();
        }
        public bool CheckLogin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return false;

            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds = dbnv.TimAllNhanVien(username);
            dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                string dbPassword = dt.Rows[0].Field<string>(8); // Assuming the password field name is "Password"
                int active = Int32.Parse(dt.Rows[0].Field<string>(7)); // Assuming the active field name is "Active"
                ConnStr = dbnv.LayConStr(username, password);
                return active == 1 && password == dbPassword;
            }
            return false;
        }
      
    }
}
