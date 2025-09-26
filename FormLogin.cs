using System;
using System.Windows.Forms;

namespace QuanNetCung
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            PastelTheme.ApplyLoginForm(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var selected = cmbUser.SelectedItem;
            string? username = selected != null ? selected.ToString() : null;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ user và mật khẩu!");
                return;
            }

            // Thiết lập user trong DatabaseHelper
            DatabaseHelper.SetUser(username, password);

            // Kiểm tra kết nối bằng cách thử query đơn giản
            var dt = DatabaseHelper.ExecuteQuery("SELECT 1");
            if (dt != null)
            {
                // Đăng nhập thành công -> phát hiện vai trò
                DatabaseHelper.DetectRole();
                FormMain mainForm = new FormMain();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Kiểm tra user và mật khẩu.");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            cmbUser.Items.Add("adminnet");
            cmbUser.Items.Add("nhanvien");
            cmbUser.Items.Add("hoivien");
        }
    }
}