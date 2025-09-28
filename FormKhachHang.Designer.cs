using System.Drawing;
using System.Windows.Forms;

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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            txtTenKH = new TextBox();
            label2 = new Label();
            txtSoDienThoai = new TextBox();
            label4 = new Label();
            txtSoTienNap = new TextBox();
            label5 = new Label();
            txtSoGioDaChoi = new TextBox();
            label6 = new Label();
            txtNgayDangKy = new TextBox();
            label7 = new Label();
            cmbGoiHoiVien = new ComboBox();
            flowLayoutPanelButtons = new FlowLayoutPanel();
            btnThem = new PastelButton();
            btnSua = new PastelButton();
            btnXoa = new PastelButton();
            flowLayoutPanelSearch = new FlowLayoutPanel();
            label3 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new PastelButton();
            btnLamMoi = new PastelButton();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanelButtons.SuspendLayout();
            flowLayoutPanelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(0, 0);
            dgvKhachHang.Margin = new Padding(10);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.RowTemplate.Height = 32;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(1043, 488);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.SelectionChanged += dgvKhachHang_SelectionChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtTenKH, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(txtSoDienThoai, 3, 0);
            tableLayoutPanel1.Controls.Add(label4, 4, 0);
            tableLayoutPanel1.Controls.Add(txtSoTienNap, 5, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(txtSoGioDaChoi, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 2, 1);
            tableLayoutPanel1.Controls.Add(txtNgayDangKy, 3, 1);
            tableLayoutPanel1.Controls.Add(label7, 4, 1);
            tableLayoutPanel1.Controls.Add(cmbGoiHoiVien, 5, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 500);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10, 5, 10, 5);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(1043, 75);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 10F);
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 0;
            label1.Text = "Tên KH:";
            // 
            // txtTenKH
            // 
            txtTenKH.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTenKH.BackColor = Color.White;
            txtTenKH.Font = new Font("Segoe UI Light", 10F);
            txtTenKH.Location = new Point(115, 8);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(194, 30);
            txtTenKH.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 10F);
            label2.Location = new Point(315, 11);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 2;
            label2.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSoDienThoai.BackColor = Color.White;
            txtSoDienThoai.Font = new Font("Segoe UI Light", 10F);
            txtSoDienThoai.Location = new Point(436, 8);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(174, 30);
            txtSoDienThoai.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 10F);
            label4.Location = new Point(616, 11);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 4;
            label4.Text = "Số tiền nạp:";
            // 
            // txtSoTienNap
            // 
            txtSoTienNap.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSoTienNap.BackColor = Color.White;
            txtSoTienNap.Font = new Font("Segoe UI Light", 10F);
            txtSoTienNap.Location = new Point(721, 8);
            txtSoTienNap.Name = "txtSoTienNap";
            txtSoTienNap.ReadOnly = true;
            txtSoTienNap.Size = new Size(309, 30);
            txtSoTienNap.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 10F);
            label5.Location = new Point(13, 46);
            label5.Name = "label5";
            label5.Size = new Size(96, 23);
            label5.TabIndex = 6;
            label5.Text = "Giờ đã chơi:";
            // 
            // txtSoGioDaChoi
            // 
            txtSoGioDaChoi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSoGioDaChoi.BackColor = Color.White;
            txtSoGioDaChoi.Font = new Font("Segoe UI Light", 10F);
            txtSoGioDaChoi.Location = new Point(115, 43);
            txtSoGioDaChoi.Name = "txtSoGioDaChoi";
            txtSoGioDaChoi.ReadOnly = true;
            txtSoGioDaChoi.Size = new Size(194, 30);
            txtSoGioDaChoi.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Light", 10F);
            label6.Location = new Point(315, 46);
            label6.Name = "label6";
            label6.Size = new Size(115, 23);
            label6.TabIndex = 8;
            label6.Text = "Ngày đăng ký:";
            // 
            // txtNgayDangKy
            // 
            txtNgayDangKy.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNgayDangKy.BackColor = Color.White;
            txtNgayDangKy.Font = new Font("Segoe UI Light", 10F);
            txtNgayDangKy.Location = new Point(436, 43);
            txtNgayDangKy.Name = "txtNgayDangKy";
            txtNgayDangKy.ReadOnly = true;
            txtNgayDangKy.Size = new Size(174, 30);
            txtNgayDangKy.TabIndex = 9;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Light", 10F);
            label7.Location = new Point(616, 46);
            label7.Name = "label7";
            label7.Size = new Size(99, 23);
            label7.TabIndex = 10;
            label7.Text = "Gói hội viên:";
            // 
            // cmbGoiHoiVien
            // 
            cmbGoiHoiVien.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbGoiHoiVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGoiHoiVien.Font = new Font("Segoe UI Light", 10F);
            cmbGoiHoiVien.Location = new Point(721, 43);
            cmbGoiHoiVien.Name = "cmbGoiHoiVien";
            cmbGoiHoiVien.Size = new Size(309, 31);
            cmbGoiHoiVien.TabIndex = 11;
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.Controls.Add(btnThem);
            flowLayoutPanelButtons.Controls.Add(btnSua);
            flowLayoutPanelButtons.Controls.Add(btnXoa);
            flowLayoutPanelButtons.Dock = DockStyle.Bottom;
            flowLayoutPanelButtons.Location = new Point(0, 575);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Padding = new Padding(10, 5, 10, 5);
            flowLayoutPanelButtons.Size = new Size(1043, 88);
            flowLayoutPanelButtons.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(161, 201, 241);
            btnThem.BorderColor = Color.FromArgb(244, 194, 215);
            btnThem.BorderRadius = 12;
            btnThem.BorderThickness = 1;
            btnThem.EnableGradient = true;
            btnThem.EnableShadow = false;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Light", 10F);
            btnThem.ForeColor = Color.Black;
            btnThem.HoverColor = Color.FromArgb(239, 176, 201);
            btnThem.Location = new Point(15, 10);
            btnThem.Margin = new Padding(5);
            btnThem.Name = "btnThem";
            btnThem.NormalColor = Color.FromArgb(161, 201, 241);
            btnThem.Padding = new Padding(8, 4, 8, 4);
            btnThem.PressedColor = Color.FromArgb(185, 214, 243);
            btnThem.Size = new Size(130, 40);
            btnThem.TabIndex = 0;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(161, 201, 241);
            btnSua.BorderColor = Color.FromArgb(244, 194, 215);
            btnSua.BorderRadius = 12;
            btnSua.BorderThickness = 1;
            btnSua.EnableGradient = true;
            btnSua.EnableShadow = true;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Light", 10F);
            btnSua.ForeColor = Color.Black;
            btnSua.HoverColor = Color.FromArgb(239, 176, 201);
            btnSua.Location = new Point(155, 10);
            btnSua.Margin = new Padding(5);
            btnSua.Name = "btnSua";
            btnSua.NormalColor = Color.FromArgb(161, 201, 241);
            btnSua.Padding = new Padding(8, 4, 8, 4);
            btnSua.PressedColor = Color.FromArgb(185, 214, 243);
            btnSua.Size = new Size(130, 40);
            btnSua.TabIndex = 1;
            btnSua.Text = "✏️ Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(161, 201, 241);
            btnXoa.BorderColor = Color.FromArgb(244, 194, 215);
            btnXoa.BorderRadius = 12;
            btnXoa.BorderThickness = 1;
            btnXoa.EnableGradient = true;
            btnXoa.EnableShadow = true;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI Light", 10F);
            btnXoa.ForeColor = Color.Black;
            btnXoa.HoverColor = Color.FromArgb(239, 176, 201);
            btnXoa.Location = new Point(295, 10);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.NormalColor = Color.FromArgb(161, 201, 241);
            btnXoa.Padding = new Padding(8, 4, 8, 4);
            btnXoa.PressedColor = Color.FromArgb(185, 214, 243);
            btnXoa.Size = new Size(130, 40);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // flowLayoutPanelSearch
            // 
            flowLayoutPanelSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanelSearch.Controls.Add(label3);
            flowLayoutPanelSearch.Controls.Add(txtTimKiem);
            flowLayoutPanelSearch.Controls.Add(btnTimKiem);
            flowLayoutPanelSearch.Controls.Add(btnLamMoi);
            flowLayoutPanelSearch.Location = new Point(500, 668);
            flowLayoutPanelSearch.Name = "flowLayoutPanelSearch";
            flowLayoutPanelSearch.Size = new Size(543, 45);
            flowLayoutPanelSearch.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 10F);
            label3.Location = new Point(3, 13);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 0;
            label3.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.BackColor = Color.White;
            txtTimKiem.Font = new Font("Segoe UI Light", 10F);
            txtTimKiem.Location = new Point(90, 10);
            txtTimKiem.Margin = new Padding(5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(220, 30);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(161, 201, 241);
            btnTimKiem.BorderColor = Color.FromArgb(244, 194, 215);
            btnTimKiem.BorderRadius = 12;
            btnTimKiem.BorderThickness = 1;
            btnTimKiem.EnableGradient = true;
            btnTimKiem.EnableShadow = true;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI Light", 10F);
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.HoverColor = Color.FromArgb(239, 176, 201);
            btnTimKiem.Location = new Point(320, 5);
            btnTimKiem.Margin = new Padding(5);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NormalColor = Color.FromArgb(161, 201, 241);
            btnTimKiem.Padding = new Padding(8, 4, 8, 4);
            btnTimKiem.PressedColor = Color.FromArgb(185, 214, 243);
            btnTimKiem.Size = new Size(110, 40);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "🔍 Tìm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(161, 201, 241);
            btnLamMoi.BorderColor = Color.FromArgb(244, 194, 215);
            btnLamMoi.BorderRadius = 12;
            btnLamMoi.BorderThickness = 1;
            btnLamMoi.EnableGradient = true;
            btnLamMoi.EnableShadow = true;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI Light", 10F);
            btnLamMoi.ForeColor = Color.Black;
            btnLamMoi.HoverColor = Color.FromArgb(239, 176, 201);
            btnLamMoi.Location = new Point(5, 55);
            btnLamMoi.Margin = new Padding(5);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.NormalColor = Color.FromArgb(161, 201, 241);
            btnLamMoi.Padding = new Padding(8, 4, 8, 4);
            btnLamMoi.PressedColor = Color.FromArgb(185, 214, 243);
            btnLamMoi.Size = new Size(110, 40);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 663);
            Controls.Add(dgvKhachHang);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanelButtons);
            Controls.Add(flowLayoutPanelSearch);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormKhachHang";
            Text = "Quản lý khách hàng";
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            flowLayoutPanelSearch.ResumeLayout(false);
            flowLayoutPanelSearch.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoTienNap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoGioDaChoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNgayDangKy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGoiHoiVien;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private QuanNetCung.PastelButton btnThem;
        private QuanNetCung.PastelButton btnSua;
        private QuanNetCung.PastelButton btnXoa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private QuanNetCung.PastelButton btnTimKiem;
        private QuanNetCung.PastelButton btnLamMoi;
    }
}