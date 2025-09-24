using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanNetCung
{
    public partial class FormCaiDat : Form
    {
        public FormCaiDat()
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

        private void btnXemTongTien_Click(object sender, EventArgs e)
        {
            if (cmbKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }

            int id = (int)cmbKhachHang.SelectedValue;
            SqlParameter[] parameters = { new SqlParameter("@IDKhachHang", id) };

            object result = DatabaseHelper.ExecuteScalarFunction("fn_TinhTongTien", parameters);
            if (result != null)
            {
                lblTongTien.Text = "Tổng tiền đã sử dụng: " + result.ToString();
            }
        }
    }
}