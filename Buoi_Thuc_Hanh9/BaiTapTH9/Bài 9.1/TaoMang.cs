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
    public partial class TaoMang : Form
    {
        private int N; // Nhận từ Form1
        private int[] a; // Mảng số nguyên
        public TaoMang(int n)
        {
            InitializeComponent();
            N = n;
        }
        private void TaoMang_Load(object sender, EventArgs e)
        {
            Random rd = new Random();
            a = new int[N];
            string daySo = "";
            string soChan = "";

            // Tạo mảng ngẫu nhiên trong khoảng [N, N+12]
            for (int i = 0; i < N; i++)
            {
                a[i] = rd.Next(N, N + 13);
                daySo += a[i] + " ";

                if (a[i] % 2 == 0)
                    soChan += a[i] + " ";
            }

            txtMang.Text = daySo.Trim();
            txtChan.Text = soChan.Trim();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
