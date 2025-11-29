using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5._3
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private int UCLN(int a, int b)
        {
            a = Math.Abs(a); b = Math.Abs(b);
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        // Hàm hiển thị kết quả
        private void HienThiKetQua(int tu, int mau)
        {
            if (mau == 0)
            {
                MessageBox.Show("Mẫu số không được bằng 0!", "Lỗi");
                return;
            }
            int ucln = UCLN(tu, mau);
            tu /= ucln;
            mau /= ucln;

            txtKQT.Text = tu.ToString();
            txtKQM.Text = mau.ToString();
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txtT1.Text);
            int mau1 = int.Parse(txtM1.Text);
            int tu2 = int.Parse(txtT2.Text);
            int mau2 = int.Parse(txtM2.Text);

            int tuKQ = tu1 * mau2 + tu2 * mau1;
            int mauKQ = mau1 * mau2;
            HienThiKetQua(tuKQ, mauKQ);
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txtT1.Text);
            int mau1 = int.Parse(txtM1.Text);
            int tu2 = int.Parse(txtT2.Text);
            int mau2 = int.Parse(txtM2.Text);

            int tuKQ = tu1 * mau2 - tu2 * mau1;
            int mauKQ = mau1 * mau2;
            HienThiKetQua(tuKQ, mauKQ);
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txtT1.Text);
            int mau1 = int.Parse(txtM1.Text);
            int tu2 = int.Parse(txtT2.Text);
            int mau2 = int.Parse(txtM2.Text);

            int tuKQ = tu1 * tu2;
            int mauKQ = mau1 * mau2;
            HienThiKetQua(tuKQ, mauKQ);
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txtT1.Text);
            int mau1 = int.Parse(txtM1.Text);
            int tu2 = int.Parse(txtT2.Text);
            int mau2 = int.Parse(txtM2.Text);

            if (tu2 == 0)
            {
                MessageBox.Show("Không thể chia cho 0!", "Lỗi");
                return;
            }

            int tuKQ = tu1 * mau2;
            int mauKQ = mau1 * tu2;
            HienThiKetQua(tuKQ, mauKQ);
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtT1.Clear();
            txtM1.Clear();
            txtT2.Clear();
            txtM2.Clear();
            txtKQT.Clear();
            txtKQM.Clear();
            txtT1.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
