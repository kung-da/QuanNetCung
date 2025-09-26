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
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGoiHV).BeginInit();
            SuspendLayout();
            // 
            // dgvGoiHV
            // 
            dgvGoiHV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGoiHV.Location = new Point(16, 18);
            dgvGoiHV.Margin = new Padding(4, 5, 4, 5);
            dgvGoiHV.Name = "dgvGoiHV";
            dgvGoiHV.RowHeadersWidth = 51;
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
            txtThoiHan.Size = new Size(132, 27);
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
            btnThem.Location = new Point(27, 491);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 35);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(144, 491);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 35);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(264, 491);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 35);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(384, 491);
            btnLamMoi.Margin = new Padding(4, 5, 4, 5);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 35);
            btnLamMoi.TabIndex = 12;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // FormGoiHoiVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 553);
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
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}