namespace QuanNetCung
{
    partial class FormKhachHang
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
            dgvKhachHang = new DataGridView();
            label1 = new Label();
            txtTenKH = new TextBox();
            label2 = new Label();
            txtSoDienThoai = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label3 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            label4 = new Label();
            txtSoTienNap = new TextBox();
            label5 = new Label();
            txtSoGioDaChoi = new TextBox();
            label6 = new Label();
            txtNgayDangKy = new TextBox();
            label7 = new Label();
            cmbGoiHoiVien = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(16, 18);
            dgvKhachHang.Margin = new Padding(4, 5, 4, 5);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(1014, 462);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.SelectionChanged += dgvKhachHang_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 508);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên KH:";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(107, 503);
            txtTenKH.Margin = new Padding(4, 5, 4, 5);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(199, 27);
            txtTenKH.TabIndex = 2;
            txtTenKH.BackColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 508);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 3;
            label2.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(440, 503);
            txtSoDienThoai.Margin = new Padding(4, 5, 4, 5);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(159, 27);
            txtSoDienThoai.TabIndex = 4;
            txtSoDienThoai.BackColor = System.Drawing.Color.White;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(16, 554);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 35);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(133, 554);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 35);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(253, 554);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 35);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 615);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 8;
            label3.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(107, 611);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(199, 27);
            txtTimKiem.TabIndex = 9;
            txtTimKiem.BackColor = System.Drawing.Color.White;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(333, 608);
            btnTimKiem.Margin = new Padding(4, 5, 4, 5);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 35);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(453, 608);
            btnLamMoi.Margin = new Padding(4, 5, 4, 5);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 35);
            btnLamMoi.TabIndex = 11;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;

            // label4 SoTienNap
            label4.AutoSize = true;
            label4.Location = new Point(625, 508);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.Text = "Số tiền nạp:";

            // txtSoTienNap (readonly)
            txtSoTienNap.Location = new Point(715, 503);
            txtSoTienNap.Name = "txtSoTienNap";
            txtSoTienNap.ReadOnly = true;
            txtSoTienNap.Size = new Size(110, 27);
            txtSoTienNap.BackColor = System.Drawing.Color.White;

            // label5 SoGioDaChoi
            label5.AutoSize = true;
            label5.Location = new Point(840, 508);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.Text = "Giờ đã chơi:";

            // txtSoGioDaChoi (readonly)
            txtSoGioDaChoi.Location = new Point(940, 503);
            txtSoGioDaChoi.Name = "txtSoGioDaChoi";
            txtSoGioDaChoi.ReadOnly = true;
            txtSoGioDaChoi.Size = new Size(90, 27);
            txtSoGioDaChoi.BackColor = System.Drawing.Color.White;

            // label6 NgayDangKy
            label6.AutoSize = true;
            label6.Location = new Point(570, 561);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.Text = "Ngày đăng ký:";

            // txtNgayDangKy (readonly)
            txtNgayDangKy.Location = new Point(670, 556);
            txtNgayDangKy.Name = "txtNgayDangKy";
            txtNgayDangKy.ReadOnly = true;
            txtNgayDangKy.Size = new Size(155, 27);
            txtNgayDangKy.BackColor = System.Drawing.Color.White;

            // label7 Gói hội viên
            label7.AutoSize = true;
            label7.Location = new Point(840, 561);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.Text = "Gói hội viên:";

            // cmbGoiHoiVien
            cmbGoiHoiVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGoiHoiVien.Location = new Point(930, 556);
            cmbGoiHoiVien.Name = "cmbGoiHoiVien";
            cmbGoiHoiVien.Size = new Size(100, 28);
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 663);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label3);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSoDienThoai);
            Controls.Add(label2);
            Controls.Add(txtTenKH);
            Controls.Add(label1);
            Controls.Add(dgvKhachHang);
            Controls.Add(label4);
            Controls.Add(txtSoTienNap);
            Controls.Add(label5);
            Controls.Add(txtSoGioDaChoi);
            Controls.Add(label6);
            Controls.Add(txtNgayDangKy);
            Controls.Add(label7);
            Controls.Add(cmbGoiHoiVien);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormKhachHang";
            Text = "Quản lý khách hàng";
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoTienNap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoGioDaChoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNgayDangKy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGoiHoiVien;
    }
}