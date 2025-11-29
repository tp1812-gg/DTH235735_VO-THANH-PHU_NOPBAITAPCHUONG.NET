using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2
{
    public partial class Form1 : Form
    {
        int[] arr; // mảng lưu trữ các số nguyên
        public Form1()
        {
            InitializeComponent();
            btnIn.Enabled = false;
            btnMax.Enabled = false;// nút In Mảng bị disable ban đầu
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            // kiểm tra nhập
            if (string.IsNullOrWhiteSpace(txtNhap.Text))
            {
                MessageBox.Show("Hãy nhập số phần tử mảng", "Thông báo");
                return;
            }

            int n;
            if (!int.TryParse(txtNhap.Text, out n))
            {
                MessageBox.Show("Giá trị nhập không hợp lệ!", "Thông báo");
                return;
            }

            if (n <= 0)
            {
                MessageBox.Show("Số phần tử phải > 0", "Thông báo");
                return;
            }

            // tạo mảng ngẫu nhiên từ -10 đến 100
            Random rnd = new Random();
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-10, 101);
            }

            // hiển thị ra label
            txtKQ.Text = string.Join(" ", arr);

            // bật nút In mảng và max
            btnIn.Enabled = true;
            btnMax.Enabled = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (arr != null)
            {
                MessageBox.Show("Các phần tử của mảng:\n" + string.Join(" ", arr), "Kết quả");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (arr != null && arr.Length > 0)
            {
                int maxValue = arr.Max();
                MessageBox.Show("Phần tử lớn nhất trong mảng là: " + maxValue, "Kết quả");
            }
        }
    }
}
