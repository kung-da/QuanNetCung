using System;
using System.Windows.Forms;

namespace QuanNetCung
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            PastelTheme.ApplyMainForm(this);
            
            // Đăng ký sự kiện resize để refresh layout
            this.Resize += FormMain_Resize;
            this.SizeChanged += FormMain_SizeChanged;
        }

        private void FormMain_Resize(object? sender, EventArgs e)
        {
            RefreshLayout();
        }

        private void FormMain_SizeChanged(object? sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                // Hiệu ứng fade-in khi restore/maximize
                PastelTheme.ApplyFadeIn(this);
                RefreshLayout();
            }
        }

        private void RefreshLayout()
        {
            // Áp dụng lại theme để đồng bộ màu pastel
            PastelTheme.ApplyMainForm(this);
            
            // Refresh tất cả child forms
            foreach (Control ctrl in panelMain.Controls)
            {
                if (ctrl is Form childForm)
                {
                    PastelTheme.RefreshAllControls(childForm);
                }
            }
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
            if (sender is Button b1) PastelTheme.MarkActive(b1);
            OpenForm(new FormKhachHang());
        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            if (sender is Button b2) PastelTheme.MarkActive(b2);
            OpenForm(new FormNapTien());
        }

        private void btnLichSuChoi_Click(object sender, EventArgs e)
        {
            if (sender is Button b3) PastelTheme.MarkActive(b3);
            OpenForm(new FormLichSuChoi());
        }

        private void btnQuanLyGoiHV_Click(object sender, EventArgs e)
        {
            if (sender is Button b4) PastelTheme.MarkActive(b4);
            OpenForm(new FormGoiHoiVien());
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (sender is Button b5) PastelTheme.MarkActive(b5);
            OpenForm(new FormBaoCao());
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            if (sender is Button b6) PastelTheme.MarkActive(b6);
            OpenForm(new FormCaiDat());
        }

        private void OpenForm(Form form)
        {
            if (!IsFormAllowed(form))
            {
                string formName = form.GetType().Name switch
                {
                    "FormKhachHang" => "Quản lý khách hàng",
                    "FormNapTien" => "Nạp tiền",
                    "FormLichSuChoi" => "Lịch sử chơi", 
                    "FormGoiHoiVien" => "Quản lý gói hội viên",
                    "FormBaoCao" => "Báo cáo",
                    "FormCaiDat" => "Cài đặt",
                    _ => "Chức năng này"
                };
                
                DatabaseHelper.ShowPermissionDenied("Truy cập chức năng", formName);
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
            PastelTheme.HookChildForm(form);
        }
    }
}