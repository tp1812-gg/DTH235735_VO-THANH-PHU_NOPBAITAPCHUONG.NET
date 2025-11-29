using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter daChucVu, daNhanVien;
        DataSet ds = new DataSet("dsQLNV");
        public Form1()
        {
            InitializeComponent();
        }

        private void dgDSNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgDSNhanVien.CurrentRow != null)
            {
                DataGridViewRow r = dgDSNhanVien.CurrentRow;
                txtMaNV.Text = r.Cells["manv"].Value.ToString();
                txtHoLot.Text = r.Cells["holot"].Value.ToString();
                txtTenNV.Text = r.Cells["tennv"].Value.ToString();
                cboChucVu.Text = r.Cells["tencv"].Value.ToString();
                dtpNgaySinh.Text = r.Cells["ngaysinh"].Value.ToString();

                if (r.Cells["phai"].Value.ToString() == "Nam")
                    radNam.Checked = true;
                else
                    radNu.Checked = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow r = ds.Tables["tblNhanVien"].NewRow();
            r["manv"] = txtMaNV.Text;
            r["holot"] = txtHoLot.Text;
            r["tennv"] = txtTenNV.Text;
            r["phai"] = radNam.Checked ? "Nam" : "Nữ";
            r["ngaysinh"] = dtpNgaySinh.Value;
            r["macv"] = cboChucVu.SelectedValue;
            ds.Tables["tblNhanVien"].Rows.Add(r);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                daNhanVien.Update(ds, "tblNhanVien");
                MessageBox.Show("Đã lưu thay đổi vào cơ sở dữ liệu!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.CurrentRow != null)
            {
                int i = dgDSNhanVien.CurrentRow.Index;
                ds.Tables["tblNhanVien"].Rows[i].Delete();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.CurrentRow != null)
            {
                int i = dgDSNhanVien.CurrentRow.Index;
                DataRow r = ds.Tables["tblNhanVien"].Rows[i];
                r["holot"] = txtHoLot.Text;
                r["tennv"] = txtTenNV.Text;
                r["phai"] = radNam.Checked ? "Nam" : "Nữ";
                r["ngaysinh"] = dtpNgaySinh.Value;
                r["macv"] = cboChucVu.SelectedValue;

            MessageBox.Show("Đã sửa thông tin nhân viên. Nhấn Lưu để cập nhật vào cơ sở dữ liệu.");
            }
            else
            {
                MessageBox.Show("Hãy chọn một nhân viên để sửa!", "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tblNhanVien"].Clear();
            daNhanVien.Fill(ds, "tblNhanVien");
            MessageBox.Show("Đã hủy các thay đổi và tải lại dữ liệu gốc!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            conn = new SqlConnection("Data Source=(local);Initial Catalog=QuanLyNhanVien;Integrated Security=True");

            // ---- Load dữ liệu cho combobox Chức vụ ----
            string queryChucVu = "SELECT * FROM chucvu";
            daChucVu = new SqlDataAdapter(queryChucVu, conn);
            daChucVu.Fill(ds, "tblChucVu");

            cboChucVu.DataSource = ds.Tables["tblChucVu"];
            cboChucVu.DisplayMember = "tencv";
            cboChucVu.ValueMember = "macv";

            // ---- Load dữ liệu cho datagrid Nhân viên ----
            string queryNhanVien = "SELECT manv, holot, tennv, phai, ngaysinh, n.macv, tencv FROM nhanvien n, chucvu c WHERE n.macv = c.macv";
            daNhanVien = new SqlDataAdapter(queryNhanVien, conn);
            daNhanVien.Fill(ds, "tblNhanVien");

            dgDSNhanVien.DataSource = ds.Tables["tblNhanVien"];
            dgDSNhanVien.Columns["manv"].HeaderText = "Mã số";
            dgDSNhanVien.Columns["holot"].HeaderText = "Họ và lót";
            dgDSNhanVien.Columns["tennv"].HeaderText = "Tên";
            dgDSNhanVien.Columns["phai"].HeaderText = "Phái";
            dgDSNhanVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgDSNhanVien.Columns["tencv"].HeaderText = "Chức vụ";
            dgDSNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // ---- Command cho INSERT (Thêm nhân viên) ----
            string sqlInsert = "INSERT INTO nhanvien VALUES (@MaNV, @HoLot, @TenNV, @Phai, @NgaySinh, @MaCV)";
            SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn);
            cmdInsert.Parameters.Add("@MaNV", SqlDbType.NVarChar, 10, "manv");
            cmdInsert.Parameters.Add("@HoLot", SqlDbType.NVarChar, 30, "holot");
            cmdInsert.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "tennv");
            cmdInsert.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
            cmdInsert.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 0, "ngaysinh");
            cmdInsert.Parameters.Add("@MaCV", SqlDbType.NVarChar, 10, "macv");
            daNhanVien.InsertCommand = cmdInsert;

            // ---- Command cho UPDATE ----
            string sqlUpdate = "UPDATE nhanvien SET holot=@HoLot, tennv=@TenNV, phai=@Phai, ngaysinh=@NgaySinh, macv=@MaCV WHERE manv=@MaNV";
            SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
            cmdUpdate.Parameters.Add("@HoLot", SqlDbType.NVarChar, 30, "holot");
            cmdUpdate.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "tennv");
            cmdUpdate.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
            cmdUpdate.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 0, "ngaysinh");
            cmdUpdate.Parameters.Add("@MaCV", SqlDbType.NVarChar, 10, "macv");
            cmdUpdate.Parameters.Add("@MaNV", SqlDbType.NVarChar, 10, "manv");
            daNhanVien.UpdateCommand = cmdUpdate;

            // ---- Command cho DELETE ----
            string sqlDelete = "DELETE FROM nhanvien WHERE manv=@MaNV";
            SqlCommand cmdDelete = new SqlCommand(sqlDelete, conn);
            cmdDelete.Parameters.Add("@MaNV", SqlDbType.NVarChar, 10, "manv");
            daNhanVien.DeleteCommand = cmdDelete;
        }
    }
}
