using Project_ver1.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ver1
{
    public partial class MainForm : Form
    {
        SanPhamUi frm1 = new SanPhamUi();
        KhachHangUI frm2 = new KhachHangUI();
        NhanVienUI frm3 = new NhanVienUI();
        public MainForm()
        {
            InitializeComponent();
            addForm();
            frm1.Show();
            this.Closed += new EventHandler(MainForm_Closed);

        }
        private void MainForm_Closed(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TurnOffAllForm();
            frm2.Show();
        }
        void addForm()
        {
           
            frm1.TopLevel = false;
            panel1.Controls.Add(frm1);
          
            frm2.TopLevel = false;
            panel1.Controls.Add(frm2);

            frm3.TopLevel = false;
            panel1.Controls.Add(frm3);
        }
        void TurnOffAllForm()
        {
            frm1.Hide();
            frm2.Hide();
            frm3.Hide();
        }



        private void gunaButton1_Click(object sender, EventArgs e)
        {
            TurnOffAllForm();
            frm1.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            TurnOffAllForm();
            frm2.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            TurnOffAllForm();
            frm3.Show();
        }
    }
}
