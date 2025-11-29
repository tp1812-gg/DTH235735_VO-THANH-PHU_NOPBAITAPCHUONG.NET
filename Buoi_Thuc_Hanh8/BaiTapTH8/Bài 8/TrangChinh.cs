using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Mặc định chỉ cho nhập cạnh hình vuông
            txtCanh.Enabled = true;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtBankinh.Enabled = false;
            rb1.Checked = true;
        }

        // Chọn hình vuông
        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            txtCanh.Clear();
            txtDai.Clear();
            txtRong.Clear();
            txtBankinh.Clear();

            txtCanh.Enabled = true;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtBankinh.Enabled = false;

            txtCanh.Focus();
        }

        // Chọn hình chữ nhật
        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            txtCanh.Clear();
            txtDai.Clear();
            txtRong.Clear();
            txtBankinh.Clear();

            txtCanh.Enabled = false;
            txtDai.Enabled = true;
            txtRong.Enabled = true;
            txtBankinh.Enabled = false;

            txtDai.Focus();
        }

        // Chọn hình tròn
        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            txtCanh.Clear();
            txtDai.Clear();
            txtRong.Clear();
            txtBankinh.Clear();

            txtCanh.Enabled = false;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtBankinh.Enabled = true;

            txtBankinh.Focus();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            // Hình vuông
            if (rb1.Checked == true)
            {
                if (txtCanh.Text == "")
                {
                    MessageBox.Show("Hãy nhập vào cạnh!", "Thông báo");
                    txtCanh.Focus();
                }
                else
                {
                    HinhVuong f2 = new HinhVuong();
                    f2.canh = double.Parse(txtCanh.Text);
                    f2.ShowDialog();
                }
            }

            // Hình chữ nhật
            if (rb2.Checked == true)
            {
                if (txtDai.Text == "" || txtRong.Text == "")
                {
                    MessageBox.Show("Hãy nhập vào chiều dài và chiều rộng!", "Thông báo");
                    txtDai.Focus();
                }
                else
                {
                    HinhChuNhat f3 = new HinhChuNhat();
                    f3.dai = double.Parse(txtDai.Text);
                    f3.rong = double.Parse(txtRong.Text);
                    f3.ShowDialog();
                }
            }

            // Hình tròn
            if (rb3.Checked == true)
            {
                if (txtBankinh.Text == "")
                {
                    MessageBox.Show("Hãy nhập vào bán kính!", "Thông báo");
                    txtBankinh.Focus();
                }
                else
                {
                    HinhTron f4 = new HinhTron();
                    f4.bankinh = double.Parse(txtBankinh.Text);
                    f4.ShowDialog();
                }
            }
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
