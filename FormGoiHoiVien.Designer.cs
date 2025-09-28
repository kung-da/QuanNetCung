using System.Drawing;
using System.Windows.Forms;

namespace QuanNetCung
{
    partial class FormGoiHoiVien
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
            dgvGoiHV = new DataGridView();
            label1 = new Label();
            txtTenGoi = new TextBox();
            label2 = new Label();
            txtThoiHan = new TextBox();
            label3 = new Label();
            txtGiaGoi = new TextBox();
            label4 = new Label();
            txtMoTa = new TextBox();
            btnThem = new PastelButton();
            btnSua = new PastelButton();
            btnXoa = new PastelButton();
            btnLamMoi = new PastelButton();
            ((System.ComponentModel.ISupportInitialize)dgvGoiHV).BeginInit();
            SuspendLayout();
            // 
            // dgvGoiHV
            // 
            dgvGoiHV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGoiHV.Location = new Point(16, 18);
            dgvGoiHV.Margin = new Padding(4, 5, 4, 5);
            dgvGoiHV.Name = "dgvGoiHV";
            dgvGoiHV.RowHeadersVisible = false;
            dgvGoiHV.RowHeadersWidth = 51;
            dgvGoiHV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGoiHV.Size = new Size(1024, 366);
            dgvGoiHV.TabIndex = 0;
            dgvGoiHV.SelectionChanged += dgvGoiHV_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 399);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên gói:";
            // 
            // txtTenGoi
            // 
            txtTenGoi.Location = new Point(118, 394);
            txtTenGoi.Margin = new Padding(4, 5, 4, 5);
            txtTenGoi.Name = "txtTenGoi";
            txtTenGoi.Size = new Size(199, 27);
            txtTenGoi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 399);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Thời hạn:";
            // 
            // txtThoiHan
            // 
            txtThoiHan.Location = new Point(424, 394);
            txtThoiHan.Margin = new Padding(4, 5, 4, 5);
            txtThoiHan.Name = "txtThoiHan";
            txtThoiHan.Size = new Size(199, 27);
            txtThoiHan.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 445);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 5;
            label3.Text = "Giá gói:";
            // 
            // txtGiaGoi
            // 
            txtGiaGoi.Location = new Point(118, 440);
            txtGiaGoi.Margin = new Padding(4, 5, 4, 5);
            txtGiaGoi.Name = "txtGiaGoi";
            txtGiaGoi.Size = new Size(199, 27);
            txtGiaGoi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 445);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 7;
            label4.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(424, 440);
            txtMoTa.Margin = new Padding(4, 5, 4, 5);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(199, 27);
            txtMoTa.TabIndex = 8;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(161, 201, 241);
            btnThem.BorderColor = Color.FromArgb(244, 194, 215);
            btnThem.BorderRadius = 12;
            btnThem.BorderThickness = 1;
            btnThem.EnableGradient = true;
            btnThem.EnableShadow = true;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Semibold", 10F);
            btnThem.ForeColor = Color.Black;
            btnThem.HoverColor = Color.FromArgb(239, 176, 201);
            btnThem.Location = new Point(27, 485);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.NormalColor = Color.FromArgb(161, 201, 241);
            btnThem.Padding = new Padding(8, 4, 8, 4);
            btnThem.PressedColor = Color.FromArgb(185, 214, 243);
            btnThem.Size = new Size(120, 45);
            btnThem.TabIndex = 9;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = true;
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
            btnSua.Font = new Font("Segoe UI Semibold", 10F);
            btnSua.ForeColor = Color.Black;
            btnSua.HoverColor = Color.FromArgb(239, 176, 201);
            btnSua.Location = new Point(160, 485);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.NormalColor = Color.FromArgb(161, 201, 241);
            btnSua.Padding = new Padding(8, 4, 8, 4);
            btnSua.PressedColor = Color.FromArgb(185, 214, 243);
            btnSua.Size = new Size(120, 45);
            btnSua.TabIndex = 10;
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
            btnXoa.Font = new Font("Segoe UI Semibold", 10F);
            btnXoa.ForeColor = Color.Black;
            btnXoa.HoverColor = Color.FromArgb(239, 176, 201);
            btnXoa.Location = new Point(290, 485);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.NormalColor = Color.FromArgb(161, 201, 241);
            btnXoa.Padding = new Padding(8, 4, 8, 4);
            btnXoa.PressedColor = Color.FromArgb(185, 214, 243);
            btnXoa.Size = new Size(120, 45);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
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
            btnLamMoi.Font = new Font("Segoe UI Semibold", 10F);
            btnLamMoi.ForeColor = Color.Black;
            btnLamMoi.HoverColor = Color.FromArgb(239, 176, 201);
            btnLamMoi.Location = new Point(420, 485);
            btnLamMoi.Margin = new Padding(4, 5, 4, 5);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.NormalColor = Color.FromArgb(161, 201, 241);
            btnLamMoi.Padding = new Padding(8, 4, 8, 4);
            btnLamMoi.PressedColor = Color.FromArgb(185, 214, 243);
            btnLamMoi.Size = new Size(120, 45);
            btnLamMoi.TabIndex = 12;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // FormGoiHoiVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 570);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtMoTa);
            Controls.Add(label4);
            Controls.Add(txtGiaGoi);
            Controls.Add(label3);
            Controls.Add(txtThoiHan);
            Controls.Add(label2);
            Controls.Add(txtTenGoi);
            Controls.Add(label1);
            Controls.Add(dgvGoiHV);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormGoiHoiVien";
            Text = "Quản lý gói hội viên";
            ((System.ComponentModel.ISupportInitialize)dgvGoiHV).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGoiHV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenGoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThoiHan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaGoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMoTa;
        private QuanNetCung.PastelButton btnThem;
        private QuanNetCung.PastelButton btnSua;
        private QuanNetCung.PastelButton btnXoa;
        private QuanNetCung.PastelButton btnLamMoi;
    }
}