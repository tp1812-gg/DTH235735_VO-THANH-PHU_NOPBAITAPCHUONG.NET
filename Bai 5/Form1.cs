using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5
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
        private int TimUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        // Hàm tìm BCNN
        private int TimBCNN(int a, int b)
        {
            return (a * b) / TimUCLN(a, b);
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a, b;

            if (!int.TryParse(txtN.Text, out a) || !int.TryParse(txtM.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }

            txtKetQua.Clear();

            if (rdoUCLN.Checked)
            {
                txtKetQua.AppendText($"UCLN({a}, {b}) = {TimUCLN(a, b)}\r\n");
            }

            if (rdoBCLN.Checked)
            {
                txtKetQua.AppendText($"BCNN({a}, {b}) = {TimBCNN(a, b)}\r\n");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtM.Clear();
            txtKetQua.Clear();
            rdoUCLN.Checked = false;
            rdoBCLN.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
