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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnQuanLyKhachHang = new System.Windows.Forms.Button();
            this.btnNapTien = new System.Windows.Forms.Button();
            this.btnLichSuChoi = new System.Windows.Forms.Button();
            this.btnQuanLyGoiHV = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelSidebar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelMain);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelSidebar
            // 
            this.panelSidebar.Controls.Add(this.btnCaiDat);
            this.panelSidebar.Controls.Add(this.btnBaoCao);
            this.panelSidebar.Controls.Add(this.btnQuanLyGoiHV);
            this.panelSidebar.Controls.Add(this.btnLichSuChoi);
            this.panelSidebar.Controls.Add(this.btnNapTien);
            this.panelSidebar.Controls.Add(this.btnQuanLyKhachHang);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 450);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnQuanLyKhachHang
            // 
            this.btnQuanLyKhachHang.Location = new System.Drawing.Point(10, 20);
            this.btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            this.btnQuanLyKhachHang.Size = new System.Drawing.Size(180, 40);
            this.btnQuanLyKhachHang.TabIndex = 0;
            this.btnQuanLyKhachHang.Text = "👥 Quản lý khách hàng";
            this.btnQuanLyKhachHang.UseVisualStyleBackColor = true;
            this.btnQuanLyKhachHang.Click += new System.EventHandler(this.btnQuanLyKhachHang_Click);
            // 
            // btnNapTien
            // 
            this.btnNapTien.Location = new System.Drawing.Point(10, 70);
            this.btnNapTien.Name = "btnNapTien";
            this.btnNapTien.Size = new System.Drawing.Size(180, 40);
            this.btnNapTien.TabIndex = 1;
            this.btnNapTien.Text = "💳 Nạp tiền";
            this.btnNapTien.UseVisualStyleBackColor = true;
            this.btnNapTien.Click += new System.EventHandler(this.btnNapTien_Click);
            // 
            // btnLichSuChoi
            // 
            this.btnLichSuChoi.Location = new System.Drawing.Point(10, 120);
            this.btnLichSuChoi.Name = "btnLichSuChoi";
            this.btnLichSuChoi.Size = new System.Drawing.Size(180, 40);
            this.btnLichSuChoi.TabIndex = 2;
            this.btnLichSuChoi.Text = "⏳ Lịch sử chơi";
            this.btnLichSuChoi.UseVisualStyleBackColor = true;
            this.btnLichSuChoi.Click += new System.EventHandler(this.btnLichSuChoi_Click);
            // 
            // btnQuanLyGoiHV
            // 
            this.btnQuanLyGoiHV.Location = new System.Drawing.Point(10, 170);
            this.btnQuanLyGoiHV.Name = "btnQuanLyGoiHV";
            this.btnQuanLyGoiHV.Size = new System.Drawing.Size(180, 40);
            this.btnQuanLyGoiHV.TabIndex = 3;
            this.btnQuanLyGoiHV.Text = "🎫 Quản lý gói hội viên";
            this.btnQuanLyGoiHV.UseVisualStyleBackColor = true;
            this.btnQuanLyGoiHV.Click += new System.EventHandler(this.btnQuanLyGoiHV_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(10, 220);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(180, 40);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "📊 Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Location = new System.Drawing.Point(10, 270);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(180, 40);
            this.btnCaiDat.TabIndex = 5;
            this.btnCaiDat.Text = "⚙️ Cài đặt";
            this.btnCaiDat.UseVisualStyleBackColor = true;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(596, 450);
            this.panelMain.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormMain";
            this.Text = "Quản lý quán Net";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnQuanLyKhachHang;
        private System.Windows.Forms.Button btnNapTien;
        private System.Windows.Forms.Button btnLichSuChoi;
        private System.Windows.Forms.Button btnQuanLyGoiHV;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.Panel panelMain;
    }
}