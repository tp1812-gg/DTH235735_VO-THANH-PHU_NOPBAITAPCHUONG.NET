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
    public partial class HinhTron : Form
    {
        public double bankinh;
        public HinhTron()
        {
            InitializeComponent();
        }

        private void HinhTron_Load(object sender, EventArgs e)
        {
            txtDienTich.Text = TinhDienTich().ToString("0.##");
            txtChuVi.Text = TinhChuVi().ToString("0.##");
        }
        private double TinhDienTich()
        {
            return Math.PI * bankinh * bankinh;
        }

        private double TinhChuVi()
        {
            return 2 * Math.PI * bankinh;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
