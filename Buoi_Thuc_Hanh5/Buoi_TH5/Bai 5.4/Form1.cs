using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // ================== HÌNH VUÔNG ==================
        private void TinhHinhVuong()
        {
            double a = double.Parse(txtNhapCanhVuong.Text);
            double cv = 4 * a;
            double dt = a * a;
            txtCVHinhVuong.Text = cv.ToString();
            txtDTHinhVuong.Text = dt.ToString();
        }

        // ================== HÌNH CHỮ NHẬT ==================
        private void TinhHinhChuNhat()
        {
            double dai = double.Parse(txtNhapChieuDai.Text);
            double rong = double.Parse(txtNhapChieuRong.Text);
            double cv = 2 * (dai + rong);
            double dt = dai * rong;
            txtCVHinhChuNhat.Text = cv.ToString();
            txtDTHinhChuNhat.Text = dt.ToString();
        }

        // ================== HÌNH TRÒN ==================
        private void TinhHinhTron()
        {
            double r = double.Parse(txtNhapBanKinh.Text);
            double cv = 2 * Math.PI * r;
            double dt = Math.PI * r * r;
            txtCVHinhTron.Text = cv.ToString("0.00");
            txtDTHinhTron.Text = dt.ToString("0.00");
        }

        // ================== HÌNH TAM GIÁC ==================
        private void TinhHinhTamGiac()
        {
            double a = double.Parse(txtNhapCanhA.Text);
            double b = double.Parse(txtNhapCanhB.Text);
            double c = double.Parse(txtNhapCanhC.Text);

            // Kiểm tra điều kiện tam giác
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                MessageBox.Show("3 cạnh nhập vào không tạo thành tam giác!", "Lỗi");
                return;
            }

            double cv = a + b + c;
            double p = cv / 2;
            double dt = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            txtCVHinhTamGiac.Text = cv.ToString();
            txtDTHinhTamGiac.Text = dt.ToString("0.00");

            // Xác định loại tam giác
            string loai = "";
            if (a == b && b == c) loai = "Tam giác đều";
            else if (a == b || a == c || b == c) loai = "Tam giác cân";
            else loai = "Tam giác thường";

            if (a * a + b * b == c * c ||
                a * a + c * c == b * b ||
                b * b + c * c == a * a)
                loai += " vuông";

            lblLoaiTamGiac.Text = loai;
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtCVHinhTamGiac_TextChanged(object sender, EventArgs e)
        {

        }
        // ================== NÚT THỰC HIỆN ==================
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rdoVuong.Checked) TinhHinhVuong();
            else if (rdoChuNhat.Checked) TinhHinhChuNhat();
            else if (rdoTron.Checked) TinhHinhTron();
            else if (rdoTamGiac.Checked) TinhHinhTamGiac();
        }

        // ================== NÚT RESET ==================
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNhapCanhVuong.Clear();
            txtNhapChieuDai.Clear();
            txtNhapChieuRong.Clear();
            txtNhapBanKinh.Clear();
            txtNhapCanhA.Clear();
            txtNhapCanhB.Clear();
            txtNhapCanhC.Clear();

            txtCVHinhVuong.Clear(); txtDTHinhVuong.Clear();
            txtCVHinhChuNhat.Clear(); txtDTHinhChuNhat.Clear();
            txtCVHinhTron.Clear(); txtDTHinhTron.Clear();
            txtCVHinhTamGiac.Clear(); txtDTHinhTamGiac.Clear();

            lblLoaiTamGiac.Text = "";
        }
        // ================== NÚT THOÁT ==================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // ================== HIỂN THỊ KHUNG THEO HÌNH ==================
        private void radVuong_CheckedChanged(object sender, EventArgs e)
        {
            groupHinhVuong.Visible = rdoVuong.Checked;
        }

        private void radHCN_CheckedChanged(object sender, EventArgs e)
        {
            groupHinhChuNhat.Visible = rdoChuNhat.Checked;
        }

        private void radTron_CheckedChanged(object sender, EventArgs e)
        {
            groupHinhTron.Visible = rdoTron.Checked;
        }

        private void radTamGiac_CheckedChanged(object sender, EventArgs e)
        {
            groupHinhTamGiac.Visible = rdoTamGiac.Checked;
        }

    }

}
