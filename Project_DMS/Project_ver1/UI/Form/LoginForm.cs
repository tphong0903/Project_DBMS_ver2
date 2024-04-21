using System.Windows.Forms;
using System;
using BusinessAccessLayer;
using System.Data;
using DataAccessLayer;

namespace Project_ver1
{
    public partial class LoginForm : Form
    {
        DBTaiKhoan dbnv = null;
        public LoginForm()
        {
            InitializeComponent();
            dbnv = new DBTaiKhoan();
        }



        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

            bool isAuthenticated = dbnv.CheckLogin(textBox1.Text, textBox2.Text);
            if (isAuthenticated)
            {
                DAL.ConnStrBuilder.IntegratedSecurity = false;
                DAL.ConnStrBuilder.UserID = textBox1.Text; 
                DAL.ConnStrBuilder.Password = textBox2.Text;
                DAL.count = 1;
                this.Hide();
                MainForm form2 = new MainForm(textBox1.Text);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar != '\0')
                textBox2.PasswordChar = '\0';
            else
                textBox2.PasswordChar = '*';
        }
    }
}