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
    public partial class KiemTraSoHoanHao : Form
    {
        private int N; // Biến nhận giá trị từ Form1

        public KiemTraSoHoanHao(int n)
        {
            InitializeComponent();
            N = n;
        }

        private void KiemTraSoHoanHao_Load(object sender, EventArgs e)
        {
            // Khi form mở, kiểm tra xem N có phải là số hoàn hảo không
            if (LaSoHoanHao(N))
                lblKQ.Text = $"{N} là số hoàn hảo";
            else
                lblKQ.Text = $"{N} không phải là số hoàn hảo";
        }
        private bool LaSoHoanHao(int n)
        {
            int tong = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    tong += i;
            }
            return tong == n;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Kiểm Tra số Hoàn Hảo
        }
    }
}
