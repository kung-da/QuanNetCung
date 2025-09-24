using System;
using System.Data;
using System.Windows.Forms;

namespace QuanNetCung
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
            LoadTongTien();
            LoadHoiVien();
        }

        private void LoadTongTien()
        {
            string query = "SELECT * FROM v_TongTienKhachHang";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            if (dt != null)
            {
                dgvTongTien.DataSource = dt;
            }
        }

        private void LoadHoiVien()
        {
            string query = "SELECT * FROM v_DanhSachHoiVien";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            if (dt != null)
            {
                dgvHoiVien.DataSource = dt;
            }
        }
    }
}