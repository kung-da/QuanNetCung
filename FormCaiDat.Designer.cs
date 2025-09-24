namespace QuanNetCung
{
    partial class FormCaiDat
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.btnXemTongTien = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng:";
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(130, 47);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(150, 21);
            this.cmbKhachHang.TabIndex = 1;
            // 
            // btnXemTongTien
            // 
            this.btnXemTongTien.Location = new System.Drawing.Point(130, 90);
            this.btnXemTongTien.Name = "btnXemTongTien";
            this.btnXemTongTien.Size = new System.Drawing.Size(120, 23);
            this.btnXemTongTien.TabIndex = 2;
            this.btnXemTongTien.Text = "Xem tổng tiền";
            this.btnXemTongTien.UseVisualStyleBackColor = true;
            this.btnXemTongTien.Click += new System.EventHandler(this.btnXemTongTien_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(50, 130);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(0, 13);
            this.lblTongTien.TabIndex = 3;
            // 
            // FormCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 181);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnXemTongTien);
            this.Controls.Add(this.cmbKhachHang);
            this.Controls.Add(this.label1);
            this.Name = "FormCaiDat";
            this.Text = "Cài đặt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.Button btnXemTongTien;
        private System.Windows.Forms.Label lblTongTien;
    }
}