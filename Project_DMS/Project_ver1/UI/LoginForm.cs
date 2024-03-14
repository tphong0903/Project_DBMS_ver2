using System.Windows.Forms;
using System;

namespace Project_ver1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("phongga088") && textBox2.Text.Equals("123"))
            {
                this.Hide();
                MainForm form2 = new MainForm();
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