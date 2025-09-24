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