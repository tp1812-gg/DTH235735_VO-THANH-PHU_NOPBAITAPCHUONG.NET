using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Thiết lập ListView
            lvSinhVien.View = View.Details;
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;

            lvSinhVien.Columns.Add("Mã SV", 100);
            lvSinhVien.Columns.Add("Họ và tên", 150);
            lvSinhVien.Columns.Add("Ngày sinh", 100);
            lvSinhVien.Columns.Add("Phái", 80);
            lvSinhVien.Columns.Add("Điện thoại", 120);
            lvSinhVien.Columns.Add("Quê quán", 120);

            cboQueQuan.Items.AddRange(new string[]
            {
                "An Giang", "Cần Thơ", "Tiền Giang", "Hậu Giang", "Vĩnh Long"
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Lỗi");
                return;
            }

            string gt = radNam.Checked ? "Nam" : "Nữ";

            ListViewItem item = new ListViewItem(txtMaSV.Text);
            item.SubItems.Add(txtHoTen.Text);
            item.SubItems.Add(dtpNgaySinh.Value.ToShortDateString());
            item.SubItems.Add(gt);
            item.SubItems.Add(txtDienThoai.Text);
            item.SubItems.Add(cboQueQuan.Text);

            lvSinhVien.Items.Add(item);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }

            ListViewItem item = lvSinhVien.SelectedItems[0];
            item.SubItems[0].Text = txtMaSV.Text;
            item.SubItems[1].Text = txtHoTen.Text;
            item.SubItems[2].Text = dtpNgaySinh.Value.ToShortDateString();
            item.SubItems[3].Text = radNam.Checked ? "Nam" : "Nữ";
            item.SubItems[4].Text = txtDienThoai.Text;
            item.SubItems[5].Text = cboQueQuan.Text;

            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvSinhVien.SelectedItems[0];
                txtMaSV.Text = item.SubItems[0].Text;
                txtHoTen.Text = item.SubItems[1].Text;
                dtpNgaySinh.Text = item.SubItems[2].Text;
                if (item.SubItems[3].Text == "Nam") radNam.Checked = true; else radNu.Checked = true;
                txtDienThoai.Text = item.SubItems[4].Text;
                cboQueQuan.Text = item.SubItems[5].Text;
            }
        }
    }
}
