namespace Bài_3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a, b, c;

            // Kiểm tra dữ liệu nhập vào
            if (!double.TryParse(txtA.Text, out a) ||
                !double.TryParse(txtB.Text, out b) ||
                !double.TryParse(txtC.Text, out c))
            {
                MessageBox.Show("Vui lòng nhập đúng các hệ số a, b, c.");
                return;
            }

            // Nếu a = 0 thì là phương trình bậc nhất
            if (a == 0)
            {
                if (b == 0)
                {
                    txtKetQua.Text = (c == 0) ? "Phương trình vô số nghiệm." : "Phương trình vô nghiệm.";
                }
                else
                {
                    double x = -c / b;
                    txtKetQua.Text = $"Phương trình bậc nhất: x = {x}";
                }
                return;
            }

            // Tính delta
            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                txtKetQua.Text = "Phương trình vô nghiệm.";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                txtKetQua.Text = $"Phương trình có nghiệm kép: x = {x}";
            }
            else
            {
                double sqrtDelta = Math.Sqrt(delta);
                double x1 = (-b + sqrtDelta) / (2 * a);
                double x2 = (-b - sqrtDelta) / (2 * a);
                txtKetQua.Text = $"PT có 2 nghiệm: x1 = {x1}; x2 = {x2}";
            }
        }

    }
}
