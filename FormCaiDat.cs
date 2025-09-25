using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanNetCung
{
    public partial class FormCaiDat : Form
    {
        public FormCaiDat()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var login = new FormLogin
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            login.Show();

            // Đóng tất cả form khác (kể cả FormMain, FormCaiDat)
            foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
            {
                if (!(f is FormLogin))
                    f.Close();
            }
        }
    }
}