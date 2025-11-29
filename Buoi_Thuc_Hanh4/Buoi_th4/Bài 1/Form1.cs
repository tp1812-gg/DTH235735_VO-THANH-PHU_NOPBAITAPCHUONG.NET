using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_1
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhap.Text, out int x))
            {
                numbers.Add(x);
                txtNhap.Clear();
                txtNhap.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            lblKQ.Text = string.Join(" ", numbers);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            lblKQ.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            lblKQ.Text = string.Join(" ", numbers);
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            numbers.Reverse();
            lblKQ.Text = string.Join(" ", numbers);
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            int count = numbers.Count(x => x % 2 == 0);
            MessageBox.Show("Số phần tử chẵn: " + count);
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            int count = numbers.Count(x => x % 2 != 0);
            MessageBox.Show("Số phần tử lẻ: " + count);
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            int count = numbers.Count(x => LaNguyenTo(x));
            MessageBox.Show("Số phần tử nguyên tố: " + count);
        }
        private bool LaNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        private void btnHao_Click(object sender, EventArgs e)
        {

            int count = numbers.Count(x => LaSoHoanHao(x));
            MessageBox.Show("Số phần tử hoàn hảo: " + count);
        }
        private bool LaSoHoanHao(int n)
        {
            if (n <= 1) return false;
            int sum = 0;
            for (int i = 1; i < n; i++)
                if (n % i == 0) sum += i;
            return sum == n;
        }

        private void btnTong_Click(object sender, EventArgs e)
        {

            int sum = numbers.Sum();
            MessageBox.Show("Tổng mảng = " + sum);
        }
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            if (numbers.Count < 2)
            {
                MessageBox.Show("Cần ít nhất 2 phần tử");
                return;
            }
            int a = numbers[0], b = numbers[1];
            int ucln = UCLN(a, b);
            MessageBox.Show($"UCLN({a},{b}) = {ucln}");
        }

        private void btnTrungBinh_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 0)
            {
                MessageBox.Show("Mảng rỗng!");
                return;
            }
            double tb = numbers.Average();
            MessageBox.Show("Trung bình mảng = " + tb);
        }

        private void btnNho_Click(object sender, EventArgs e)
        {

            if (numbers.Count == 0)
            {
                MessageBox.Show("Mảng rỗng!");
                return;
            }
            int min = numbers.Min();
            MessageBox.Show("Số nhỏ nhất = " + min);
        }

        private void btnLon_Click(object sender, EventArgs e)
        {

            if (numbers.Count == 0)
            {
                MessageBox.Show("Mảng rỗng!");
                return;
            }
            int max = numbers.Max();
            MessageBox.Show("Số lớn nhất = " + max);
        }
    }
}
