using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Khi form load -> thêm các ký tự A-Z vào TreeView
        private void Form1_Load(object sender, EventArgs e)
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                treeView1.Nodes.Add(c.ToString());
            }
        }

        // Khi bấm nút "Thêm"
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text.Trim();
            string ten = txtTen.Text.Trim();

            if (string.IsNullOrEmpty(ho) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ và Tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char firstChar = char.ToUpper(ten[0]); // Lấy chữ cái đầu của tên

            // Tìm node tương ứng với chữ cái đầu
            TreeNode node = null;
            foreach (TreeNode n in treeView1.Nodes)
            {
                if (n.Text == firstChar.ToString())
                {
                    node = n;
                    break;
                }
            }

            if (node != null)
            {
                node.Nodes.Add($"{ten}, {ho}");
                node.Expand(); // Mở node ra để hiển thị tên mới thêm
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhóm chữ cái phù hợp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Xóa nội dung nhập
            txtHo.Clear();
            txtTen.Clear();
            txtTen.Focus();
        }

        // Khi bấm "Thoát"
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
