using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyHocSinh;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dtHocSinh, dtQueQuan;
        string sql;
        bool themMoi = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Load dữ liệu học sinh
                sql = @"SELECT mahs, holot, tenhs, phai, ngaysinh, hocsinh.maqq, tenqq 
                        FROM hocsinh 
                        JOIN quequan ON hocsinh.maqq = quequan.maqq";
                da = new SqlDataAdapter(sql, conn);
                dtHocSinh = new DataTable();
                da.Fill(dtHocSinh);
                dgvHocSinh.DataSource = dtHocSinh;

                // Load combobox Quê quán
                da = new SqlDataAdapter("SELECT * FROM quequan", conn);
                dtQueQuan = new DataTable();
                da.Fill(dtQueQuan);
                cboQueQuan.DataSource = dtQueQuan;
                cboQueQuan.DisplayMember = "tenqq";
                cboQueQuan.ValueMember = "maqq";

                // Tắt các nút Lưu / Hủy lúc đầu
                btnLuu.Enabled = btnHuy.Enabled = false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themMoi = true;

            txtMaHS.Clear();
            txtHoLot.Clear();
            txtTen.Clear();
            rdNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
            cboQueQuan.SelectedIndex = 0;
            txtMaHS.Focus();

            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themMoi = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd;

                if (themMoi)
                {
                    cmd = new SqlCommand(
                        "INSERT INTO hocsinh (mahs, holot, tenhs, phai, ngaysinh, maqq) VALUES (@ma,@holot,@ten,@phai,@ngaysinh,@maqq)",
                        conn);
                }
                else
                {
                    cmd = new SqlCommand(
                        "UPDATE hocsinh SET holot=@holot, tenhs=@ten, phai=@phai, ngaysinh=@ngaysinh, maqq=@maqq WHERE mahs=@ma",
                        conn);
                }

                cmd.Parameters.AddWithValue("@ma", txtMaHS.Text.Trim());
                cmd.Parameters.AddWithValue("@holot", txtHoLot.Text.Trim());
                cmd.Parameters.AddWithValue("@ten", txtTen.Text.Trim());
                cmd.Parameters.AddWithValue("@phai", rdNam.Checked ? "Nam" : "Nữ");
                cmd.Parameters.AddWithValue("@ngaysinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@maqq", cboQueQuan.SelectedValue);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo");

                Form1_Load(sender, e);
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnLuu.Enabled = btnHuy.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHS.Text == "") return;

            if (MessageBox.Show("Bạn có muốn xóa học sinh này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM hocsinh WHERE mahs=@ma", conn);
                    cmd.Parameters.AddWithValue("@ma", txtMaHS.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã xóa thành công!", "Thông báo");

                    Form1_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaHS.Text = dgvHocSinh.Rows[e.RowIndex].Cells["mahs"].Value.ToString();
                txtHoLot.Text = dgvHocSinh.Rows[e.RowIndex].Cells["holot"].Value.ToString();
                txtTen.Text = dgvHocSinh.Rows[e.RowIndex].Cells["tenhs"].Value.ToString();
                string phai = dgvHocSinh.Rows[e.RowIndex].Cells["phai"].Value.ToString();
                rdNam.Checked = phai == "Nam";
                rdNu.Checked = phai == "Nữ";
                dtpNgaySinh.Value = DateTime.Parse(dgvHocSinh.Rows[e.RowIndex].Cells["ngaysinh"].Value.ToString());
                cboQueQuan.SelectedValue = dgvHocSinh.Rows[e.RowIndex].Cells["maqq"].Value.ToString();
            }
        }
    }
}
