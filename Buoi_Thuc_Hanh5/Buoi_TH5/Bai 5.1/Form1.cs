using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool KiemTraSNT(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }
        private void txtNhap_TextChanged(object sender, EventArgs e)
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

            // Kiểm tra số nguyên tố
            if (KiemTraSNT(n))
                txtKT.Text = n + " là số nguyên tố";
            else
                txtKT.Text = n + " không phải là số nguyên tố";

            // Tìm các số nguyên tố nhỏ hơn n
            StringBuilder s = new StringBuilder();
            for (int i = 2; i < n; i++)
            {
                if (KiemTraSNT(i))
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
