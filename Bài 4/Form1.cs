using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            if (this.txtHoTen.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên", "Thông báo"); this.txtHoTen.Focus();
            }
            else
            {
                string hoten = this.txtHoTen.Text;
                if (this.rdoThuong.Checked == true)

                {
                    this.txtKetQua.Text = hoten.ToLower();

                }
                if (this.rdoHoa.Checked == true)
                {
                    this.txtKetQua.Text = hoten.ToUpper();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
        
            txtHoTen.Clear();
            txtKetQua.Clear();
            rdoThuong.Checked = false;
            rdoHoa.Checked = false;
            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?",
                                                  "Xác nhận thoát",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
