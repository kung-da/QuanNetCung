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
            if (cmbKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }

            int id = (int)cmbKhachHang.SelectedValue;
            decimal soTien;
            if (!decimal.TryParse(txtSoTien.Text, out soTien) || soTien <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ!");
                return;
            }

            SqlParameter[] parameters = {
                new SqlParameter("@ID", id),
                new SqlParameter("@SoTien", soTien)
            };

            int result = DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_NapTien", parameters);
            if (result > 0)
            {
                MessageBox.Show("Nạp tiền thành công!");
                txtSoTien.Clear();
            }
        }
    }
}