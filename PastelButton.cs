using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QuanNetCung
{
    internal class PastelButton : Button
    {
        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public Color NormalColor { get; set; } = PastelTheme.PrimaryButton;

        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public Color HoverColor { get; set; } = PastelTheme.PrimaryHover;

        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public Color PressedColor { get; set; } = ColorTranslator.FromHtml("#B9D6F3");

        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public Color BorderColor { get; set; } = PastelTheme.SidebarBackground;

        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public int BorderRadius { get; set; } = 12;

        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public int BorderThickness { get; set; } = 1;

        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public bool EnableShadow { get; set; } = true;

        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public bool EnableGradient { get; set; } = true;

        private bool _hover;
        private bool _pressed;

        public PastelButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = NormalColor;
            ForeColor = Color.Black;
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Padding = new Padding(8, 4, 8, 4);
            Height = 40;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            Cursor = Cursors.Hand;
        }

        protected override void OnResize(EventArgs e)
        {
            // Cập nhật Region bo góc khi resize để tránh mảng đen
            if (BorderRadius > 0 && Width > 0 && Height > 0)
            {
                try
                {
                    using var path = RoundedRect(new Rectangle(0, 0, Width, Height), BorderRadius);
                    Region = new System.Drawing.Region(path);
                }
                catch
                {
                    // Nếu lỗi thì đặt về null để tránh crash
                    Region = null;
                }
            }
            base.OnResize(e);
        }

        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hover = false; _pressed = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs mevent) { if (mevent.Button == MouseButtons.Left) { _pressed = true; Invalidate(); } base.OnMouseDown(mevent); }
        protected override void OnMouseUp(MouseEventArgs mevent) { if (_pressed) { _pressed = false; Invalidate(); } base.OnMouseUp(mevent); }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            // Vẽ nền parent để loại bỏ artifact tam giác ở góc
            if (Parent != null)
            {
                using var parentBrush = new SolidBrush(Parent.BackColor);
                pevent.Graphics.FillRectangle(parentBrush, ClientRectangle);
            }
            
            var rect = ClientRectangle; rect.Inflate(-1, -1);
            using var path = RoundedRect(rect, BorderRadius);
            Color baseColor = NormalColor;
            if (_pressed) baseColor = PressedColor; else if (_hover) baseColor = HoverColor;

            // Bỏ shadow để tránh vết đen
            if (EnableGradient)
            {
                Color lighter = ControlPaint.Light(baseColor, 0.25f);
                using var lg = new LinearGradientBrush(rect, lighter, baseColor, LinearGradientMode.Vertical);
                pevent.Graphics.FillPath(lg, path);
            }
            else
            {
                using var sb = new SolidBrush(baseColor);
                pevent.Graphics.FillPath(sb, path);
            }
            // Bỏ border để tránh vết đen
            TextRenderer.DrawText(pevent.Graphics, Text, Font, rect, ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }

        private static System.Drawing.Drawing2D.GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2; var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
