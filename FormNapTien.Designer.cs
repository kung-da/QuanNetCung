using System.Drawing;
using System.Windows.Forms;

namespace QuanNetCung
{
    partial class FormNapTien
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
            label2 = new Label();
            txtSoTien = new TextBox();
            btnNapTien = new PastelButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Khách hàng:";
            // 
            // cmbKhachHang
            // 
            cmbKhachHang.FormattingEnabled = true;
            cmbKhachHang.Location = new Point(173, 72);
            cmbKhachHang.Margin = new Padding(4, 5, 4, 5);
            cmbKhachHang.Name = "cmbKhachHang";
            cmbKhachHang.Size = new Size(312, 28);
            cmbKhachHang.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 138);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "Số tiền:";
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(173, 134);
            txtSoTien.Margin = new Padding(4, 5, 4, 5);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(312, 27);
            txtSoTien.TabIndex = 3;
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
            btnNapTien.Location = new Point(193, 200);
            btnNapTien.Margin = new Padding(4, 5, 4, 5);
            btnNapTien.Name = "btnNapTien";
            btnNapTien.NormalColor = Color.FromArgb(161, 201, 241);
            btnNapTien.Padding = new Padding(11, 6, 11, 6);
            btnNapTien.PressedColor = Color.FromArgb(185, 214, 243);
            btnNapTien.Size = new Size(273, 63);
            btnNapTien.TabIndex = 4;
            btnNapTien.Text = "💰 Nạp tiền";
            btnNapTien.UseVisualStyleBackColor = true;
            btnNapTien.Click += btnNapTien_Click;
            // 
            // FormNapTien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 448);
            Controls.Add(btnNapTien);
            Controls.Add(txtSoTien);
            Controls.Add(label2);
            Controls.Add(cmbKhachHang);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormNapTien";
            Text = "Nạp tiền";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoTien;
        private QuanNetCung.PastelButton btnNapTien;
    }
}