using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtHoTen.Text.Trim();

            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu", "Thông báo");
                txtHoTen.Focus();
                return;
            }

            if (radLopA.Checked)
            {
                lstLopA.Items.Add(ten);
            }
            else if (radLopB.Checked)
            {
                lstLopB.Items.Add(ten);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp để thêm sinh viên!", "Thông báo");
                return;
            }

            txtHoTen.Clear();
            txtHoTen.Focus();
        }

        private void btnSangB_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItem != null)
            {
                lstLopB.Items.Add(lstLopA.SelectedItem);
                lstLopA.Items.Remove(lstLopA.SelectedItem);
            }
        }

        private void btnSangA_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItem != null)
            {
                lstLopA.Items.Add(lstLopB.SelectedItem);
                lstLopB.Items.Remove(lstLopB.SelectedItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAllSangB_Click(object sender, EventArgs e)
        {
            foreach (var item in lstLopA.Items)
            {
                lstLopB.Items.Add(item);
            }
            lstLopA.Items.Clear();
        }

        private void btnAllSangA_Click(object sender, EventArgs e)
        {
            foreach (var item in lstLopB.Items)
            {
                lstLopA.Items.Add(item);
            }
            lstLopB.Items.Clear();
        }

        private void btnTongSV_Click(object sender, EventArgs e)
        {
            int tong = lstLopA.Items.Count + lstLopB.Items.Count;
            MessageBox.Show("Tổng số sinh viên là: " + tong, "Kết quả");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
