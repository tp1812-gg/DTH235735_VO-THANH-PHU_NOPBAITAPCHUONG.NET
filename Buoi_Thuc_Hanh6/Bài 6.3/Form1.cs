using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_6._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Cấu hình ListView
            lvSinhVien.View = View.Details;
            lvSinhVien.FullRowSelect = true;

            lvSinhVien.Columns.Add("Mã SV", 100);
            lvSinhVien.Columns.Add("Họ tên", 150);
            lvSinhVien.Columns.Add("Địa chỉ", 150);
            lvSinhVien.Columns.Add("Ngày sinh", 100);
            lvSinhVien.Columns.Add("Lớp", 80);

            // Thêm lớp mẫu
            cboLop.Items.AddRange(new string[] { "Lớp A", "Lớp B", "Lớp C", "Lớp D" });
            cboLop.SelectedIndex = 0;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "" || txtHoTen.Text.Trim() == "" || txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông báo");
                return;
            }

            // Thêm dòng mới vào ListView
            ListViewItem item = new ListViewItem(txtMaSV.Text);
            item.SubItems.Add(txtHoTen.Text);
            item.SubItems.Add(txtDiaChi.Text);
            item.SubItems.Add(dtpNgaySinh.Value.ToShortDateString());
            item.SubItems.Add(cboLop.Text);

            lvSinhVien.Items.Add(item);

            // Xóa trắng ô nhập
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtMaSV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa!", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
