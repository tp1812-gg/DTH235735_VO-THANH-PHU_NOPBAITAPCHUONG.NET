namespace Bài_2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int A = int.Parse(txtA.Text);
            int B = int.Parse(txtB.Text);
            int tong = A + B;
            txtKetQua.Text = tong.ToString();
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int A = int.Parse(txtA.Text);
            int B = int.Parse(txtB.Text);
            int hieu = A - B;
            txtKetQua.Text = hieu.ToString();
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            int A = int.Parse(txtA.Text);
            int B = int.Parse(txtB.Text);
            int tich = A * B;
            txtKetQua.Text = tich.ToString();
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            int A = int.Parse(txtA.Text);
            int B = int.Parse(txtB.Text);
            if(B==0)
             {
                MessageBox.Show("Không thể chia cho 0!");
            }
            else
            {
                double thuong = (double)A / B;
                txtKetQua.Text = thuong.ToString();
            }
        }
    }
}
