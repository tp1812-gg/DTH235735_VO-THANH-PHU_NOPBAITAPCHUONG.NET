using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNhap.Text))
            {
                listBox1.Items.Add(txtNhap.Text);
                txtNhap.Clear();
                txtNhap.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập chuỗi trước khi thêm!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                txtKQ.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa!", "Thông báo");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                txtKQ.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void btnMauChu_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                txtKQ.ForeColor = cd.Color;
            }
        }

        private void btnMauNen_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                txtKQ.BackColor = cd.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtKQ.Font = fd.Font;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
