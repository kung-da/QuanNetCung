using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanNetCung
{
    public partial class FormGoiHoiVien : Form
    {
        public FormGoiHoiVien()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM GoiHoiVien";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            if (dt != null)
            {
                dgvGoiHV.DataSource = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenGoi = txtTenGoi.Text.Trim();
            int thoiHan;
            decimal giaGoi;
            string moTa = txtMoTa.Text.Trim();

            if (string.IsNullOrEmpty(tenGoi) || !int.TryParse(txtThoiHan.Text, out thoiHan) || !decimal.TryParse(txtGiaGoi.Text, out giaGoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng!");
                return;
            }

            string query = "INSERT INTO GoiHoiVien (TenGoi, ThoiHan, GiaGoi, MoTa) VALUES (@TenGoi, @ThoiHan, @GiaGoi, @MoTa)";
            SqlParameter[] parameters = {
                new SqlParameter("@TenGoi", tenGoi),
                new SqlParameter("@ThoiHan", thoiHan),
                new SqlParameter("@GiaGoi", giaGoi),
                new SqlParameter("@MoTa", moTa)
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Thêm gói hội viên thành công!");
                LoadData();
                ClearFields();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvGoiHV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn gói hội viên để sửa!");
                return;
            }

            int maGoi = (int)dgvGoiHV.SelectedRows[0].Cells["MaGoi"].Value;
            string tenGoi = txtTenGoi.Text.Trim();
            int thoiHan;
            decimal giaGoi;
            string moTa = txtMoTa.Text.Trim();

            if (string.IsNullOrEmpty(tenGoi) || !int.TryParse(txtThoiHan.Text, out thoiHan) || !decimal.TryParse(txtGiaGoi.Text, out giaGoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng!");
                return;
            }

            string query = "UPDATE GoiHoiVien SET TenGoi = @TenGoi, ThoiHan = @ThoiHan, GiaGoi = @GiaGoi, MoTa = @MoTa WHERE MaGoi = @MaGoi";
            SqlParameter[] parameters = {
                new SqlParameter("@MaGoi", maGoi),
                new SqlParameter("@TenGoi", tenGoi),
                new SqlParameter("@ThoiHan", thoiHan),
                new SqlParameter("@GiaGoi", giaGoi),
                new SqlParameter("@MoTa", moTa)
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Sửa gói hội viên thành công!");
                LoadData();
                ClearFields();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGoiHV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn gói hội viên để xóa!");
                return;
            }

            int maGoi = (int)dgvGoiHV.SelectedRows[0].Cells["MaGoi"].Value;

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa gói hội viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string query = "DELETE FROM GoiHoiVien WHERE MaGoi = @MaGoi";
                SqlParameter[] parameters = { new SqlParameter("@MaGoi", maGoi) };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("Xóa gói hội viên thành công!");
                    LoadData();
                    ClearFields();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearFields();
        }

        private void ClearFields()
        {
            txtTenGoi.Clear();
            txtThoiHan.Clear();
            txtGiaGoi.Clear();
            txtMoTa.Clear();
        }

        private void dgvGoiHV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGoiHV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvGoiHV.SelectedRows[0];
                txtTenGoi.Text = row.Cells["TenGoi"].Value.ToString();
                txtThoiHan.Text = row.Cells["ThoiHan"].Value.ToString();
                txtGiaGoi.Text = row.Cells["GiaGoi"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString() ?? "";
            }
        }
    }
}