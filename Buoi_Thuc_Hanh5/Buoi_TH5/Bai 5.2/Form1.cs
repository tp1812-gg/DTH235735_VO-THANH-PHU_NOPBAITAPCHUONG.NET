using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool KiemTraHoanHao(int n)
        {
            if (n < 2) return false;
            int tong = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    tong += i;
            }
            return tong == n;
        }


        private void txtKT_TextChanged(object sender, EventArgs e)
        {
            if (txtNhap.Text == "") return;

            int n;
            if (!int.TryParse(txtNhap.Text, out n))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Thông báo");
                txtNhap.Clear();
                txtNhap.Focus();
                return;
            }

            // Kiểm tra số hoàn hảo
            if (KiemTraHoanHao(n))
                txtKT.Text = n + " là số hoàn hảo";
            else
                txtKT.Text = n + " không phải là số hoàn hảo";

            // Tìm các số hoàn hảo nhỏ hơn n
            StringBuilder s = new StringBuilder();
            for (int i = 2; i < n; i++)
            {
                if (KiemTraHoanHao(i))
                    s.Append(i + " ");
            }
            txtTim.Text = s.ToString();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtKT.Clear();
            txtTim.Clear();
            txtNhap.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
