using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbKQ.Items.Add("Trần Duy khánh");
            cbKQ.Items.Add("Đỗ Thanh Vy");
            cbKQ.Items.Add("Trần Thị Huyền Trân");

            // Chọn mặc định mục đầu tiên
            cbKQ.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnChao_Click(object sender, EventArgs e)
        {
            string ten = cbKQ.SelectedItem.ToString();
            MessageBox.Show("Chào " + ten + ". Chúc một ngày vui vẻ.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
