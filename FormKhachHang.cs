using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanNetCung
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
            LoadData();
            LoadGoiHoiVien();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM KhachHang";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            if (dt != null)
            {
                dgvKhachHang.DataSource = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text.Trim();
            string soDT = txtSoDienThoai.Text.Trim();

            if (string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(soDT))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            SqlParameter[] parameters = {
                new SqlParameter("@TenKH", tenKH),
                new SqlParameter("@SoDienThoai", soDT)
            };

            int result = DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_ThemKhachHang", parameters);
            if (result > 0)
            {
                MessageBox.Show("Thêm khách hàng thành công!");
                LoadData();
                ClearFields();
            }
        }

        private void LoadGoiHoiVien()
        {
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery("SELECT MaGoi, TenGoi FROM GoiHoiVien");
                if (dt != null)
                {
                    // Thêm dòng 'Không' (NULL)
                    DataRow r = dt.NewRow();
                    r["MaGoi"] = DBNull.Value;
                    r["TenGoi"] = "Không";
                    dt.Rows.InsertAt(r, 0);
                    cmbGoiHoiVien.DisplayMember = "TenGoi";
                    cmbGoiHoiVien.ValueMember = "MaGoi";
                    cmbGoiHoiVien.DataSource = dt;
                }
            }
            catch { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa!");
                return;
            }

            int id = (int)dgvKhachHang.SelectedRows[0].Cells["ID"].Value;
            string tenKH = txtTenKH.Text.Trim();
            string soDT = txtSoDienThoai.Text.Trim();
            object maGoiValue = cmbGoiHoiVien.SelectedValue;
            object maGoiDb = maGoiValue == null || maGoiValue == DBNull.Value ? (object)DBNull.Value : maGoiValue;

            if (string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(soDT))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Chỉ cập nhật các trường cho phép sửa: Tên, SĐT, MaGoiHV
            string query = "UPDATE KhachHang SET TenKH = @TenKH, SoDienThoai = @SoDienThoai, MaGoiHV = @MaGoiHV WHERE ID = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", id),
                new SqlParameter("@TenKH", tenKH),
                new SqlParameter("@SoDienThoai", soDT),
                new SqlParameter("@MaGoiHV", maGoiDb)
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Sửa khách hàng thành công!");
                LoadData();
                ClearFields();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa!");
                return;
            }

            int id = (int)dgvKhachHang.SelectedRows[0].Cells["ID"].Value;

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string query = "DELETE FROM KhachHang WHERE ID = @ID";
                SqlParameter[] parameters = { new SqlParameter("@ID", id) };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("Xóa khách hàng thành công!");
                    LoadData();
                    ClearFields();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            SqlParameter[] parameters = { new SqlParameter("@Keyword", keyword) };

            DataTable dt = DatabaseHelper.ExecuteStoredProcedure("sp_TimKiemKhachHang", parameters);
            if (dt != null)
            {
                dgvKhachHang.DataSource = dt;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearFields();
        }

        private void ClearFields()
        {
            txtTenKH.Clear();
            txtSoDienThoai.Clear();
            txtTimKiem.Clear();
            txtSoTienNap.Clear();
            txtSoGioDaChoi.Clear();
            txtNgayDangKy.Clear();
            if (cmbGoiHoiVien.DataSource != null) cmbGoiHoiVien.SelectedIndex = 0;
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvKhachHang.SelectedRows[0];
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtSoTienNap.Text = row.Cells["SoTienNap"].Value.ToString();
                txtSoGioDaChoi.Text = row.Cells["SoGioDaChoi"].Value.ToString();
                txtNgayDangKy.Text = Convert.ToDateTime(row.Cells["NgayDangKy"].Value).ToString("dd/MM/yyyy HH:mm");
                // MaGoiHV có thể null
                var maGoi = row.Cells["MaGoiHV"].Value;
                if (maGoi == null || maGoi == DBNull.Value)
                {
                    cmbGoiHoiVien.SelectedIndex = 0; // Không
                }
                else
                {
                    int mg = Convert.ToInt32(maGoi);
                    for (int i = 0; i < cmbGoiHoiVien.Items.Count; i++)
                    {
                        var drv = cmbGoiHoiVien.Items[i] as DataRowView;
                        if (drv != null && drv["MaGoi"] != DBNull.Value && Convert.ToInt32(drv["MaGoi"]) == mg)
                        {
                            cmbGoiHoiVien.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }
    }
}