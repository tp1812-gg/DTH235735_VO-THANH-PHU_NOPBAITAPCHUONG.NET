namespace Bài_2._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            int A = int.Parse(txtA.Text);
            int B = int.Parse(txtB.Text);
            int chuVi = (A + B) * 2;
            txtKetQua.Text = "Chu vi = " + chuVi.ToString();
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            int A = int.Parse(txtA.Text);
            int B = int.Parse(txtB.Text);
            int dienTich = A * B;
            txtKetQua.Text = "Diện tích = " + dienTich.ToString();
        }

        private void btnDuongCheo_Click(object sender, EventArgs e)
        {
            int A = int.Parse(txtA.Text);
            int B = int.Parse(txtB.Text);
            double duongcheo = Math.Sqrt(A * A + B * B);
            txtKetQua.Text = duongcheo.ToString("0,##");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
