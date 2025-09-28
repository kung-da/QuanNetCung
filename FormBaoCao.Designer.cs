namespace QuanNetCung
{
    partial class FormBaoCao
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvTongTien = new DataGridView();
            tabPage2 = new TabPage();
            dgvHoiVien = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTongTien).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoiVien).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 615);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvTongTien);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(792, 582);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tổng tiền khách hàng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTongTien
            // 
            dgvTongTien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTongTien.Dock = DockStyle.Fill;
            dgvTongTien.Location = new Point(4, 5);
            dgvTongTien.Margin = new Padding(4, 5, 4, 5);
            dgvTongTien.Name = "dgvTongTien";
            dgvTongTien.RowHeadersVisible = false;
            dgvTongTien.RowHeadersWidth = 51;
            dgvTongTien.Size = new Size(784, 572);
            dgvTongTien.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvHoiVien);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(792, 582);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Danh sách hội viên";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvHoiVien
            // 
            dgvHoiVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoiVien.Dock = DockStyle.Fill;
            dgvHoiVien.Location = new Point(4, 5);
            dgvHoiVien.Margin = new Padding(4, 5, 4, 5);
            dgvHoiVien.Name = "dgvHoiVien";
            dgvHoiVien.RowHeadersVisible = false;
            dgvHoiVien.RowHeadersWidth = 51;
            dgvHoiVien.Size = new Size(784, 572);
            dgvHoiVien.TabIndex = 0;
            // 
            // FormBaoCao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 615);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormBaoCao";
            Text = "Báo cáo";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTongTien).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoiVien).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvTongTien;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvHoiVien;
    }
}