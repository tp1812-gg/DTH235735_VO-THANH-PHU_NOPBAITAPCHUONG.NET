using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5._5
{
    public partial class Form1 : Form
    {
        int[] arr;
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        // Hiển thị mảng ra Label
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnXuatMang_Click(object sender, EventArgs e)
        {
            arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rd.Next(1, 100);
            txtMang.Text = string.Join(" ", arr);
            txtKetQua.Text = "";
        }

        private void btnTongMang_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int tong = arr.Sum();
            txtKetQua.Text = "Tổng Mảng = " + tong;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int min = arr.Min();
            txtKetQua.Text = "Phần tử nhỏ nhất = " + min;
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++)
                arr[i] += 2;
            txtMang.Text = string.Join(" ", arr);
            txtKetQua.Text = "Mỗi phần tử đã tăng thêm 2";
        }

        private void btnDemLe_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int count = arr.Count(x => x % 2 != 0);
            txtKetQua.Text = "Số phần tử lẻ = " + count;
        }

        private void btnTongLe_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int tong = arr.Where(x => x % 2 != 0).Sum();
            txtKetQua.Text = "Tổng giá trị phần tử lẻ = " + tong;
        }

        private void btnTangDan_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            Array.Sort(arr);
            txtMang.Text = string.Join(" ", arr);
            txtKetQua.Text = "Mảng đã sắp tăng dần";
        }

        private void btnGiamDan_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            Array.Sort(arr);
            Array.Reverse(arr);
            txtMang.Text = string.Join(" ", arr);
            txtKetQua.Text = "Mảng đã sắp giảm dần";
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
