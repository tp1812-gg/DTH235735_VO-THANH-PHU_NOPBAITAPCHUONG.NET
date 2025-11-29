namespace Bài_4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            double S = 0;
            for (int i = 1; i <= n; i++)
                S += 1.0 / i;
            txtS.Text = S.ToString();
        }
    }
}
