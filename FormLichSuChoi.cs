using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanNetCung
{
    public partial class FormLichSuChoi : Form
    {
        public FormLichSuChoi()
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

        private void btnXemLichSu_Click(object sender, EventArgs e)
        {
            if (cmbKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }

            int id = (int)cmbKhachHang.SelectedValue;
            SqlParameter[] parameters = { new SqlParameter("@ID", id) };

            DataTable dt = DatabaseHelper.ExecuteStoredProcedure("sp_XemLichSuChoi", parameters);
            if (dt != null)
            {
                dgvLichSu.DataSource = dt;
            }
        }
    }
}