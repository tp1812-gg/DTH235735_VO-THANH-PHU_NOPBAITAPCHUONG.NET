using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if ((this.txtTen.Text == "") || (this.txtMatKhau.Text == ""))
                MessageBox.Show("Vui lòng nhập tên người dùng hoặc mật khẩu");
            else
            {
                if ((this.txtTen.Text == "nguyenvanhung") && (this.txtMatKhau.Text == "abc12345"))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên và mật khẩu không đúng, hãy nhập lại", "Thông báo");
                    this.txtTen.Clear();
                    this.txtMatKhau.Clear(); this.txtTen.Focus();
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận thoát",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Kết thúc toàn bộ chương trình
            }
            else
            {
                // Nếu chọn No thì không làm gì, người dùng vẫn ở lại Form đăng nhập
                // Bạn có thể thêm code đặt focus lại vào một control nếu muốn, ví dụ:
                txtTen.Focus();
            }
        }
    }
}
