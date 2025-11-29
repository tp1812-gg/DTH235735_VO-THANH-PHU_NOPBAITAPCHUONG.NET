namespace Bài_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            int Thang;
            //Kiểm tra nhập liệu
            if (!int.TryParse(txtThang.Text, out Thang) || Thang < 1 || Thang > 12)
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ từ 1 đến 12 cho tháng.");
                return;
            }
            string mua = "";
            if(Thang >=1 && Thang <=3)
            {
                mua = "Mùa Xuân";
            }
            else if(Thang >=4 && Thang <=6)
            {
                mua = "Mùa Hạ";
            }
            else if(Thang >=7 && Thang <=9)
            {
                mua = "Mùa Thu";
            }
            else
            {
                mua = "Mùa Đông";
            }
            MessageBox.Show(mua);
        }
    }
}
