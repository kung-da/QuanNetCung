namespace QuanNetCung
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            panelSidebar = new Panel();
            btnCaiDat = new PastelButton();
            btnBaoCao = new PastelButton();
            btnQuanLyGoiHV = new PastelButton();
            btnLichSuChoi = new PastelButton();
            btnNapTien = new PastelButton();
            btnQuanLyKhachHang = new PastelButton();
            panelMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 5, 4, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panelSidebar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelMain);
            splitContainer1.Size = new Size(1328, 692);
            splitContainer1.SplitterDistance = 415;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // panelSidebar
            // 
            panelSidebar.Controls.Add(btnCaiDat);
            panelSidebar.Controls.Add(btnBaoCao);
            panelSidebar.Controls.Add(btnQuanLyGoiHV);
            panelSidebar.Controls.Add(btnLichSuChoi);
            panelSidebar.Controls.Add(btnNapTien);
            panelSidebar.Controls.Add(btnQuanLyKhachHang);
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(4, 5, 4, 5);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(339, 692);
            panelSidebar.TabIndex = 0;
            // 
            // btnCaiDat
            // 
            btnCaiDat.BackColor = Color.FromArgb(161, 201, 241);
            btnCaiDat.BorderColor = Color.FromArgb(244, 194, 215);
            btnCaiDat.BorderRadius = 12;
            btnCaiDat.BorderThickness = 1;
            btnCaiDat.EnableGradient = true;
            btnCaiDat.EnableShadow = true;
            btnCaiDat.FlatStyle = FlatStyle.Flat;
            btnCaiDat.Font = new Font("Segoe UI Semibold", 10F);
            btnCaiDat.ForeColor = Color.Black;
            btnCaiDat.HoverColor = Color.FromArgb(239, 176, 201);
            btnCaiDat.Location = new Point(13, 569);
            btnCaiDat.Margin = new Padding(4, 5, 4, 5);
            btnCaiDat.Name = "btnCaiDat";
            btnCaiDat.NormalColor = Color.FromArgb(161, 201, 241);
            btnCaiDat.Padding = new Padding(11, 6, 11, 6);
            btnCaiDat.PressedColor = Color.FromArgb(185, 214, 243);
            btnCaiDat.Size = new Size(307, 77);
            btnCaiDat.TabIndex = 5;
            btnCaiDat.Text = "⚙️ Cài đặt";
            btnCaiDat.UseVisualStyleBackColor = true;
            btnCaiDat.Click += btnCaiDat_Click;
            // 
            // btnBaoCao
            // 
            btnBaoCao.BackColor = Color.FromArgb(161, 201, 241);
            btnBaoCao.BorderColor = Color.FromArgb(244, 194, 215);
            btnBaoCao.BorderRadius = 12;
            btnBaoCao.BorderThickness = 1;
            btnBaoCao.EnableGradient = true;
            btnBaoCao.EnableShadow = true;
            btnBaoCao.FlatStyle = FlatStyle.Flat;
            btnBaoCao.Font = new Font("Segoe UI Semibold", 10F);
            btnBaoCao.ForeColor = Color.Black;
            btnBaoCao.HoverColor = Color.FromArgb(239, 176, 201);
            btnBaoCao.Location = new Point(13, 477);
            btnBaoCao.Margin = new Padding(4, 5, 4, 5);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.NormalColor = Color.FromArgb(161, 201, 241);
            btnBaoCao.Padding = new Padding(11, 6, 11, 6);
            btnBaoCao.PressedColor = Color.FromArgb(185, 214, 243);
            btnBaoCao.Size = new Size(307, 77);
            btnBaoCao.TabIndex = 4;
            btnBaoCao.Text = "📊 Báo cáo";
            btnBaoCao.UseVisualStyleBackColor = true;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // btnQuanLyGoiHV
            // 
            btnQuanLyGoiHV.BackColor = Color.FromArgb(161, 201, 241);
            btnQuanLyGoiHV.BorderColor = Color.FromArgb(244, 194, 215);
            btnQuanLyGoiHV.BorderRadius = 12;
            btnQuanLyGoiHV.BorderThickness = 1;
            btnQuanLyGoiHV.EnableGradient = true;
            btnQuanLyGoiHV.EnableShadow = true;
            btnQuanLyGoiHV.FlatStyle = FlatStyle.Flat;
            btnQuanLyGoiHV.Font = new Font("Segoe UI Semibold", 10F);
            btnQuanLyGoiHV.ForeColor = Color.Black;
            btnQuanLyGoiHV.HoverColor = Color.FromArgb(239, 176, 201);
            btnQuanLyGoiHV.Location = new Point(13, 385);
            btnQuanLyGoiHV.Margin = new Padding(4, 5, 4, 5);
            btnQuanLyGoiHV.Name = "btnQuanLyGoiHV";
            btnQuanLyGoiHV.NormalColor = Color.FromArgb(161, 201, 241);
            btnQuanLyGoiHV.Padding = new Padding(11, 6, 11, 6);
            btnQuanLyGoiHV.PressedColor = Color.FromArgb(185, 214, 243);
            btnQuanLyGoiHV.Size = new Size(307, 77);
            btnQuanLyGoiHV.TabIndex = 3;
            btnQuanLyGoiHV.Text = "🎫 Quản lý gói hội viên";
            btnQuanLyGoiHV.UseVisualStyleBackColor = true;
            btnQuanLyGoiHV.Click += btnQuanLyGoiHV_Click;
            // 
            // btnLichSuChoi
            // 
            btnLichSuChoi.BackColor = Color.FromArgb(161, 201, 241);
            btnLichSuChoi.BorderColor = Color.FromArgb(244, 194, 215);
            btnLichSuChoi.BorderRadius = 12;
            btnLichSuChoi.BorderThickness = 1;
            btnLichSuChoi.EnableGradient = true;
            btnLichSuChoi.EnableShadow = true;
            btnLichSuChoi.FlatStyle = FlatStyle.Flat;
            btnLichSuChoi.Font = new Font("Segoe UI Semibold", 10F);
            btnLichSuChoi.ForeColor = Color.Black;
            btnLichSuChoi.HoverColor = Color.FromArgb(239, 176, 201);
            btnLichSuChoi.Location = new Point(13, 292);
            btnLichSuChoi.Margin = new Padding(4, 5, 4, 5);
            btnLichSuChoi.Name = "btnLichSuChoi";
            btnLichSuChoi.NormalColor = Color.FromArgb(161, 201, 241);
            btnLichSuChoi.Padding = new Padding(11, 6, 11, 6);
            btnLichSuChoi.PressedColor = Color.FromArgb(185, 214, 243);
            btnLichSuChoi.Size = new Size(307, 77);
            btnLichSuChoi.TabIndex = 2;
            btnLichSuChoi.Text = "⏳ Lịch sử chơi";
            btnLichSuChoi.UseVisualStyleBackColor = true;
            btnLichSuChoi.Click += btnLichSuChoi_Click;
            // 
            // btnNapTien
            // 
            btnNapTien.BackColor = Color.FromArgb(161, 201, 241);
            btnNapTien.BorderColor = Color.FromArgb(244, 194, 215);
            btnNapTien.BorderRadius = 12;
            btnNapTien.BorderThickness = 1;
            btnNapTien.EnableGradient = true;
            btnNapTien.EnableShadow = true;
            btnNapTien.FlatStyle = FlatStyle.Flat;
            btnNapTien.Font = new Font("Segoe UI Semibold", 10F);
            btnNapTien.ForeColor = Color.Black;
            btnNapTien.HoverColor = Color.FromArgb(239, 176, 201);
            btnNapTien.Location = new Point(13, 200);
            btnNapTien.Margin = new Padding(4, 5, 4, 5);
            btnNapTien.Name = "btnNapTien";
            btnNapTien.NormalColor = Color.FromArgb(161, 201, 241);
            btnNapTien.Padding = new Padding(11, 6, 11, 6);
            btnNapTien.PressedColor = Color.FromArgb(185, 214, 243);
            btnNapTien.Size = new Size(307, 77);
            btnNapTien.TabIndex = 1;
            btnNapTien.Text = "💳 Nạp tiền";
            btnNapTien.UseVisualStyleBackColor = true;
            btnNapTien.Click += btnNapTien_Click;
            // 
            // btnQuanLyKhachHang
            // 
            btnQuanLyKhachHang.BackColor = Color.FromArgb(161, 201, 241);
            btnQuanLyKhachHang.BorderColor = Color.FromArgb(244, 194, 215);
            btnQuanLyKhachHang.BorderRadius = 12;
            btnQuanLyKhachHang.BorderThickness = 1;
            btnQuanLyKhachHang.EnableGradient = true;
            btnQuanLyKhachHang.EnableShadow = true;
            btnQuanLyKhachHang.FlatStyle = FlatStyle.Flat;
            btnQuanLyKhachHang.Font = new Font("Segoe UI Semibold", 10F);
            btnQuanLyKhachHang.ForeColor = Color.Black;
            btnQuanLyKhachHang.HoverColor = Color.FromArgb(239, 176, 201);
            btnQuanLyKhachHang.Location = new Point(13, 108);
            btnQuanLyKhachHang.Margin = new Padding(4, 5, 4, 5);
            btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            btnQuanLyKhachHang.NormalColor = Color.FromArgb(161, 201, 241);
            btnQuanLyKhachHang.Padding = new Padding(11, 6, 11, 6);
            btnQuanLyKhachHang.PressedColor = Color.FromArgb(185, 214, 243);
            btnQuanLyKhachHang.Size = new Size(307, 77);
            btnQuanLyKhachHang.TabIndex = 0;
            btnQuanLyKhachHang.Text = "👥 Quản lý khách hàng";
            btnQuanLyKhachHang.UseVisualStyleBackColor = true;
            btnQuanLyKhachHang.Click += btnQuanLyKhachHang_Click;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(-73, 0);
            panelMain.Margin = new Padding(4, 5, 4, 5);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(860, 692);
            panelMain.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 692);
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMain";
            Text = "Quản lý quán Net";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelSidebar;
    private QuanNetCung.PastelButton btnQuanLyKhachHang;
    private QuanNetCung.PastelButton btnNapTien;
    private QuanNetCung.PastelButton btnLichSuChoi;
    private QuanNetCung.PastelButton btnQuanLyGoiHV;
    private QuanNetCung.PastelButton btnBaoCao;
    private QuanNetCung.PastelButton btnCaiDat;
        private System.Windows.Forms.Panel panelMain;
    }
}