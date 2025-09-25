using System;
using System.Windows.Forms;

namespace QuanNetCung
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private bool IsFormAllowed(Form f)
        {
            var role = DatabaseHelper.CurrentRole;
            if (role == DatabaseHelper.UserRole.Admin) return true; // Admin full quyền
            if (role == DatabaseHelper.UserRole.NhanVien)
            {
                // Nhân viên không được vào FormBaoCao
                if (f is FormBaoCao) return false;
            }
            else if (role == DatabaseHelper.UserRole.HoiVien)
            {
                // Hội viên chỉ được phép xem Lịch Sử Chơi + Cài Đặt
                if (f is FormLichSuChoi) return true;
                if (f is FormCaiDat) return true;
                return false;
            }
            return true; // Mặc định cho phép
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            OpenForm(new FormKhachHang());
        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            OpenForm(new FormNapTien());
        }

        private void btnLichSuChoi_Click(object sender, EventArgs e)
        {
            OpenForm(new FormLichSuChoi());
        }

        private void btnQuanLyGoiHV_Click(object sender, EventArgs e)
        {
            OpenForm(new FormGoiHoiVien());
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBaoCao());
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            OpenForm(new FormCaiDat());
        }

        private void OpenForm(Form form)
        {
            if (!IsFormAllowed(form))
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này.", "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                form.Dispose();
                return;
            }
            // Đóng form hiện tại trong panelMain
            foreach (Control ctrl in panelMain.Controls)
            {
                ctrl.Dispose();
            }
            panelMain.Controls.Clear();

            // Mở form mới
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            form.Show();
        }
    }
}