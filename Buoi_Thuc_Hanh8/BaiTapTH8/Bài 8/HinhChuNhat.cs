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
    public partial class HinhChuNhat : Form
    {
        public double dai, rong;
        public HinhChuNhat()
        {
            InitializeComponent();
        }

        private void HinhChuNhat_Load(object sender, EventArgs e)
        {
            txtDienTich.Text = TinhDienTich().ToString();
            txtChuVi.Text = TinhChuVi().ToString();
        }
        private double TinhDienTich()
        {
            return dai * rong;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double TinhChuVi()
        {
            return 2 * (dai + rong);
        }

    }
}
