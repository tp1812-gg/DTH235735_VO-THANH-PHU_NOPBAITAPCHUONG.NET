namespace Bài_2._7
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
            txtKetQua.Text = btnTong.Text + " = " + tong.ToString();
        }
    }
}
