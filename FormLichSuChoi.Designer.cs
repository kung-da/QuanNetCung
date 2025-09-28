using System.Drawing;
using System.Windows.Forms;

namespace QuanNetCung
{
    partial class FormLichSuChoi
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
            label1 = new Label();
            cmbKhachHang = new ComboBox();
            btnXemLichSu = new PastelButton();
            dgvLichSu = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Khách hàng:";
            // 
            // cmbKhachHang
            // 
            cmbKhachHang.FormattingEnabled = true;
            cmbKhachHang.Location = new Point(173, 26);
            cmbKhachHang.Margin = new Padding(4, 5, 4, 5);
            cmbKhachHang.Name = "cmbKhachHang";
            cmbKhachHang.Size = new Size(199, 28);
            cmbKhachHang.TabIndex = 1;
            // 
            // btnXemLichSu
            // 
            btnXemLichSu.BackColor = Color.FromArgb(161, 201, 241);
            btnXemLichSu.BorderColor = Color.FromArgb(244, 194, 215);
            btnXemLichSu.BorderRadius = 12;
            btnXemLichSu.BorderThickness = 1;
            btnXemLichSu.EnableGradient = true;
            btnXemLichSu.EnableShadow = true;
            btnXemLichSu.FlatStyle = FlatStyle.Flat;
            btnXemLichSu.Font = new Font("Segoe UI Semibold", 10F);
            btnXemLichSu.ForeColor = Color.Black;
            btnXemLichSu.HoverColor = Color.FromArgb(239, 176, 201);
            btnXemLichSu.Location = new Point(400, 15);
            btnXemLichSu.Margin = new Padding(4, 5, 4, 5);
            btnXemLichSu.Name = "btnXemLichSu";
            btnXemLichSu.NormalColor = Color.FromArgb(161, 201, 241);
            btnXemLichSu.Padding = new Padding(11, 6, 11, 6);
            btnXemLichSu.PressedColor = Color.FromArgb(185, 214, 243);
            btnXemLichSu.Size = new Size(173, 54);
            btnXemLichSu.TabIndex = 2;
            btnXemLichSu.Text = "📊 Xem lịch sử";
            btnXemLichSu.UseVisualStyleBackColor = true;
            btnXemLichSu.Click += btnXemLichSu_Click;
            // 
            // dgvLichSu
            // 
            dgvLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSu.Location = new Point(0, 78);
            dgvLichSu.Margin = new Padding(4, 5, 4, 5);
            dgvLichSu.Name = "dgvLichSu";
            dgvLichSu.RowHeadersVisible = false;
            dgvLichSu.RowHeadersWidth = 51;
            dgvLichSu.Size = new Size(1062, 538);
            dgvLichSu.TabIndex = 3;
            // 
            // FormLichSuChoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 616);
            Controls.Add(dgvLichSu);
            Controls.Add(btnXemLichSu);
            Controls.Add(cmbKhachHang);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormLichSuChoi";
            Text = "Lịch sử chơi";
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private QuanNetCung.PastelButton btnXemLichSu;
        private System.Windows.Forms.DataGridView dgvLichSu;
    }
}