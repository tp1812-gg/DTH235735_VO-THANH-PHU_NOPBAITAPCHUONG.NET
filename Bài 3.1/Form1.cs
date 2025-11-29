namespace Bài_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double x, f;

            // Thử chuyển đổi giá trị x từ TextBox
            if (!double.TryParse(txtX.Text, out x))
            {
                MessageBox.Show("Vui lòng nhập một số thực hợp lệ cho x.");
                return;
            }

            // Tính giá trị hàm số f(x) theo từng khoảng
            if (x >= 2)
            {
                f = -8 * Math.Pow(x, 3) - 12 * x - 1;
            }
            else if (x > 1 && x < 2)
            {
                f = Math.Pow(x, 2) - 6 * x - 19;
            }
            else // x <= 1
            {
                f = 7 * x;
            }

            // Hiển thị kết quả ra TextBox f
            txtF.Text = f.ToString();
        }
    }
}
