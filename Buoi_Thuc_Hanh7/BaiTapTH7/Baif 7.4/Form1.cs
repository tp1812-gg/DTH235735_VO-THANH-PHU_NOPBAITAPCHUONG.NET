using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baif_7._4
{
    public partial class Form1 : Form
    {
        List<Label> dsGhe = new List<Label>();
        List<int> dsChon = new List<int>(); // danh sách ghế đang chọn
        bool[] daBan = new bool[31];        // mảng đánh dấu ghế đã bán
        const int giaVe = 100000;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tiêu đề
            lblTieuDe.Text = "Chọn vị trí ghế";
            lblTieuDe.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

            // Tạo 30 ghế tự động
            TaoGhe();
        }
        private void TaoGhe()
        {
            int x = 50, y = 60, so = 1;
            for (int i = 1; i <= 30; i++)
            {
                Label lbl = new Label();
                lbl.Name = "lbl" + i;
                lbl.Text = i.ToString();
                lbl.Size = new Size(40, 40);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.BackColor = Color.White;
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.Font = new Font("Arial", 10, FontStyle.Bold);

                lbl.Left = x;
                lbl.Top = y;

                lbl.Click += Ghe_Click;

                dsGhe.Add(lbl);
                this.Controls.Add(lbl);

                x += 45;
                if (i % 6 == 0) // xuống dòng sau mỗi 6 ghế
                {
                    x = 50;
                    y += 45;
                }
            }
        }
        private void Ghe_Click(object sender, EventArgs e)
        {
            Label ghe = sender as Label;
            int soGhe = int.Parse(ghe.Text);

            // Nếu ghế đã bán -> thông báo
            if (daBan[soGhe])
            {
                MessageBox.Show($"Ghế {soGhe} đã bán!", "Thông báo");
                return;
            }

            // Nếu ghế đang chọn (xanh) -> bỏ chọn (trắng)
            if (ghe.BackColor == Color.Blue)
            {
                ghe.BackColor = Color.White;
                dsChon.Remove(soGhe);
            }
            else // Nếu ghế chưa chọn -> chọn (xanh)
            {
                ghe.BackColor = Color.Blue;
                dsChon.Add(soGhe);
            }

            CapNhatTien();
        }
        private void CapNhatTien()
        {
            int tong = dsChon.Count * giaVe;
            lblThanhTien.Text = $"Thành tiền: {tong:N0} VNĐ";
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            // Đổi các ghế đang chọn sang vàng (đã bán)
            foreach (int so in dsChon)
            {
                dsGhe[so - 1].BackColor = Color.Yellow;
                daBan[so] = true;
            }

            dsChon.Clear();
            CapNhatTien();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Đổi ghế đang chọn (xanh) sang trắng
            foreach (int so in dsChon)
            {
                dsGhe[so - 1].BackColor = Color.White;
            }

            dsChon.Clear();
            CapNhatTien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
