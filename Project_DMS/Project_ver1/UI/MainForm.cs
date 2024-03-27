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
        HoaDonUI frm4 = new HoaDonUI();
        BienLaiUI frm5 = new BienLaiUI();
        NhaCungCapUI frm6 = new NhaCungCapUI();
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

            frm4.TopLevel = false;
            panel1.Controls.Add(frm4);

            frm5.TopLevel = false;
            panel1.Controls.Add(frm5);

            frm6.TopLevel = false;
            panel1.Controls.Add(frm6);
        }
        void TurnOffAllForm()
        {
            frm1.Hide();
            frm2.Hide();
            frm3.Hide();
            frm4.Hide();
            frm5.Hide();
            frm6.Hide();
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

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            TurnOffAllForm();
            frm4.Show();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            TurnOffAllForm();
            frm6.Show();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            TurnOffAllForm();
            frm5.Show();
        }
    }
}
