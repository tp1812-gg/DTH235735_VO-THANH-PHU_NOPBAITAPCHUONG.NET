namespace Bài_3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int Ngay, Thang, Nam;
            if (!int.TryParse(txtNgay.Text, out Ngay) ||
                !int.TryParse(txtThang.Text, out Thang) ||
                !int.TryParse(txtNam.Text, out Nam))
            {
                MessageBox.Show("Vui lòng nhập các giá trị số nguyên hợp lệ cho ngày, tháng và năm.");
                return;
            }
            int[] NgayTrongNam = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            // Kiểm tra năm nhuận
            if ((Nam % 4 == 0 && Nam % 100 != 0) || (Nam % 400 == 0))
            {
                NgayTrongNam[2] = 29; // Năm nhuận, tháng 2 có 29 ngày

            }
            // Kiểm tra tháng hợp lệ
            if (Thang < 1 || Thang > 12)
            {
                MessageBox.Show("Ngày KHÔNG hợp lệ!");
                return;
            }
            // Kiểm tra ngày hợp lệ
            if (Ngay >= 1 && Ngay <= NgayTrongNam[Thang])
            {
                MessageBox.Show("Ngày hợp lệ!");
            }
            else
            {
                MessageBox.Show("Ngày KHÔNG hợp lệ!");
            }


        }
    }
}
