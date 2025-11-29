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
    public partial class HinhVuong : Form
    {
        public double canh;
        public HinhVuong()
        {
            InitializeComponent();
        }

        private void HinhVuong_Load(object sender, EventArgs e)
        {
            txtDienTich.Text = TinhDienTich().ToString();
            txtChuVi.Text = TinhChuVi().ToString();
        }
        private double TinhDienTich()
        {
            return canh * canh;
        }

        private double TinhChuVi()
        {
            return 4 * canh;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
