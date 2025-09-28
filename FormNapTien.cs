using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanNetCung
{
    public partial class FormNapTien : Form
    {
        public FormNapTien()
        {
            InitializeComponent();
            LoadKhachHang();
        }

        private void LoadKhachHang()
        {
            string query = "SELECT ID, TenKH FROM KhachHang";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            if (dt != null)
            {
                cmbKhachHang.DataSource = dt;
                cmbKhachHang.DisplayMember = "TenKH";
                cmbKhachHang.ValueMember = "ID";
            }
        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbKhachHang.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = (int)cmbKhachHang.SelectedValue;
                decimal soTien;
                if (!decimal.TryParse(txtSoTien.Text, out soTien) || soTien <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số tiền hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlParameter[] parameters = {
                    new SqlParameter("@ID", id),
                    new SqlParameter("@SoTien", soTien)
                };

                int result = DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_NapTien", parameters);
                
                // Luôn hiển thị thông báo thành công vì stored procedure sẽ thành công nếu không có lỗi
                MessageBox.Show($"Nạp tiền thành công!\nSố tiền: {soTien:N0} VND\nKhách hàng: {cmbKhachHang.Text}", 
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoTien.Clear();
                
                // Refresh lại danh sách khách hàng để cập nhật số dư (nếu cần)
                LoadKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nạp tiền thất bại!\nLỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}