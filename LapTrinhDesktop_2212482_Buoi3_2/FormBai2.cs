using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhDesktop_2212482_Buoi3_2
{
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
        }

        private void FormBai2_Load(object sender, EventArgs e)
        {

        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            var item = listBox2.SelectedItem;
            listBox2.Items.Remove(item);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien = 0;
            foreach (string hang  in listBox2.Items)
            {
                switch (hang)
                {
                    case "Chuột":
                        soTien += 100000;
                        break;
                    case "Bàn phím":
                        soTien += 150000;
                        break;
                    case "Máy in":
                        soTien += 2000000;
                        break;
                    case "USB KingMax":
                        soTien += 200000;
                        break;
                }
            }
            lblTongTien.Text = soTien.ToString() + " Đồng";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
