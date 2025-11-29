using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace Bài_7._3
{
    public partial class Form1 : Form
    {
        private string[] danhSachHinh;  // Mảng chứa đường dẫn ảnh
        private int chiSo = 0;          // Chỉ số ảnh hiện tại
        private bool dangChay = false;  // Trạng thái slideshow
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picHinh.SizeMode = PictureBoxSizeMode.Zoom;
            timer1.Interval = 2000; // 2 giây đổi ảnh
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string thuMuc = dlg.SelectedPath;
                    string[] duoi = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
                    danhSachHinh = Directory.GetFiles(thuMuc)
                        .Where(f => duoi.Contains(Path.GetExtension(f).ToLower()))
                        .ToArray();

                    if (danhSachHinh.Length > 0)
                    {
                        chiSo = 0;
                        HienThiHinh(chiSo);
                    }
                    else
                    {
                        MessageBox.Show("Thư mục không có hình!", "Thông báo");
                    }
                }
            }
        }
        private void HienThiHinh(int i)
        {
            try
            {
                picHinh.Image = Image.FromFile(danhSachHinh[i]);
            }
            catch
            {
                picHinh.Image = null;
            }
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {

            if (danhSachHinh == null || danhSachHinh.Length == 0) return;
            chiSo--;
            if (chiSo < 0) chiSo = danhSachHinh.Length - 1;
            HienThiHinh(chiSo);
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (danhSachHinh == null || danhSachHinh.Length == 0) return;
            chiSo++;
            if (chiSo >= danhSachHinh.Length) chiSo = 0;
            HienThiHinh(chiSo);
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (danhSachHinh == null || danhSachHinh.Length == 0)
            {
                MessageBox.Show("Chưa mở danh sách hình!", "Thông báo");
                return;
            }

            dangChay = !dangChay; // Đảo trạng thái

            if (dangChay)
            {
                timer1.Start();
                btnBatDau.Text = "Dừng";
            }
            else
            {
                timer1.Stop();
                btnBatDau.Text = "Bắt đầu";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnSau_Click(sender, e); // Mỗi tick tự bấm “Sau >>”
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
