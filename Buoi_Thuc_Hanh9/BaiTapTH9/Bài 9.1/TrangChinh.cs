using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_9._1
{
    public partial class TrangChinh : Form
    {
        public TrangChinh()
        {
            InitializeComponent();
        }

        private void TrangChinh_Load(object sender, EventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            KiemTraSoHoanHao f2 = new KiemTraSoHoanHao();
            f2.ShowDialog();
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            TaoMang f3 = new TaoMang();
            f3.ShowDialog();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtN.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuKiemTra_Click(object sender, EventArgs e)
        {
            btnKiemTra.PerformClick();
        }

        private void mnuTaoMang_Click(object sender, EventArgs e)
        {
            btnTaoMang.PerformClick();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            btnThoat.PerformClick();
        }
    }
}
