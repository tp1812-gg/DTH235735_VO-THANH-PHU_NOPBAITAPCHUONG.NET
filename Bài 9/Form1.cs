using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
            string ngaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            string diaChi = txtDiaChi.Text;
            string dienThoai = txtSDT.Text;
            string email = txtEmail.Text;
            string tinhTrang = rdoHoc.Checked ? "Đang đi học" : "Đang đi làm";

            string thongTin = $"Họ tên: {hoTen}\n" +
                              $"Giới tính: {gioiTinh}\n" +
                              $"Ngày sinh: {ngaySinh}\n" +
                              $"Địa chỉ: {diaChi}\n" +
                              $"Điện thoại: {dienThoai}\n" +
                              $"Email: {email}\n" +
                              $"Tình trạng: {tinhTrang}";

            MessageBox.Show(thongTin, "Thông tin cá nhân", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
