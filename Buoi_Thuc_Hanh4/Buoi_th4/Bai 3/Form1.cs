using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3
{
    public partial class Form1 : Form
    {
        int[] a;   // mảng chứa số
        int n;     // số phần tử
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void TaoMang(int n)
        {
            a = new int[n];
            Random rd = new Random();

            for (int i = 0; i < n; i++)
            {
                a[i] = rd.Next(-10, 101); // số ngẫu nhiên từ -10 đến 100
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Hãy nhập số phần tử mảng", "Thông báo");
                txtNhap.Focus();
                return;
            }

            n = Convert.ToInt32(txtNhap.Text);
            if (n <= 0)
            {
                MessageBox.Show("Bạn vừa nhập n = " + n + ". Số phần tử mảng phải > 0", "Thông báo");
                txtNhap.Focus();
                return;
            }

            // Tạo mảng
            TaoMang(n);

            // Hiển thị mảng ra MessageBox
            string kq = "Mảng vừa tạo: ";
            foreach (int x in a)
                kq += x + " ";
            MessageBox.Show(kq, "Thông báo");

            // Bật 2 nút còn lại
            btnSum.Enabled = true;
            btnMax.Enabled = true;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            // Tìm số lớn nhất
            int max = a[0];
            foreach (int x in a)
                if (x > max) max = x;

            // Mở Form2 để hiển thị
            Form2 f2 = new Form2(max);
            f2.ShowDialog();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (int x in a)
                tong += x;

            MessageBox.Show("Tổng các phần tử mảng là: " + tong, "Kết quả");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
