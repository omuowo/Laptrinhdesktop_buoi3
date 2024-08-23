using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhDesktop_2212482_buoi3
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tenDaNhap = txtTen.Text;
            MessageBox.Show($"xin chào {tenDaNhap}, rất vui được gặp bạn", "Thông điệp chào");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }
    }
}
