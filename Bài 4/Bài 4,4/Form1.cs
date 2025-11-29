namespace Bài_4_4
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
            int S = 0;
            for (int i = 1; i <= n + 1; i++)
                S += 2 * i - 1;
            txtS.Text = S.ToString();
        }
    }
}
