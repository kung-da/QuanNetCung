using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace QuanNetCung
{
	internal static class PastelTheme
	{
		public static readonly Color SidebarBackground = ColorTranslator.FromHtml("#F4C2D7");
		public static readonly Color SidebarHover = ColorTranslator.FromHtml("#A1C9F1");
		public static readonly Color SidebarHighlight = ColorTranslator.FromHtml("#EFB0C9");
		public static readonly Color FormBackground = ColorTranslator.FromHtml("#F1E6D9");
		public static readonly Color LoginBackground = ColorTranslator.FromHtml("#FBDAE9");
		public static readonly Color PrimaryButton = ColorTranslator.FromHtml("#A1C9F1");
		public static readonly Color PrimaryHover = ColorTranslator.FromHtml("#EFB0C9");
		public static readonly Color DataGridHeader = ColorTranslator.FromHtml("#B9D6F3");
		public static readonly Color AltRow = ColorTranslator.FromHtml("#FBDAE9");
		public static readonly Color TextDark = Color.FromArgb(51, 51, 51);

		private static Font _baseFont = new Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
		private static Font _titleFont = new Font("Segoe UI Light", 14F, FontStyle.Regular, GraphicsUnit.Point);

		public static void ApplyMainForm(FormMain form)
		{
			form.BackColor = FormBackground;
			form.Font = _baseFont;
			
			// Đảm bảo sidebar width cố định 250px
			var splitContainer = form.Controls.Find("splitContainer1", true).FirstOrDefault() as SplitContainer;
			if (splitContainer != null)
			{
				splitContainer.SplitterDistance = 250;
				splitContainer.IsSplitterFixed = true;
			}

			var sidebar = form.Controls.Find("panelSidebar", true).FirstOrDefault() as Panel;
			if (sidebar != null)
			{
				sidebar.BackColor = SidebarBackground;
				sidebar.Padding = new Padding(0, 12, 0, 12);
				sidebar.Width = 250; // Đảm bảo width cố định
				
				EnsureAppTitle(sidebar);
				EnsureHighlightPanel(sidebar);
				
				// Refresh tất cả buttons trong sidebar
				foreach (var btn in sidebar.Controls.OfType<Button>())
				{
					StyleSidebarButton(btn, sidebar);
				}
			}
			
			var panelMain = form.Controls.Find("panelMain", true).FirstOrDefault() as Panel;
			if (panelMain != null)
			{
				panelMain.BackColor = FormBackground;
				panelMain.Dock = DockStyle.Fill; // Đảm bảo fill toàn bộ
			}
		}

		private static void EnsureAppTitle(Panel sidebar)
		{
			if (sidebar.Controls.OfType<Label>().Any(l => l.Name == "lblAppTitle")) return;
			var lbl = new Label
			{
				Name = "lblAppTitle",
				Text = "Internet Cafe",
				AutoSize = false,
				Height = 42,
				Dock = DockStyle.Top,
				Font = _titleFont,
				ForeColor = Color.Black,
				TextAlign = ContentAlignment.MiddleCenter,
				BackColor = SidebarBackground
			};
			sidebar.Controls.Add(lbl);
			lbl.BringToFront();
		}

		private static void EnsureHighlightPanel(Panel sidebar)
		{
			if (sidebar.Controls.OfType<Panel>().Any(p => p.Name == "panelActive")) return;
			var p = new Panel
			{
				Name = "panelActive",
				BackColor = SidebarHighlight,
				Width = 4,
				Height = 40,
				Left = 0,
				Top = 0,
				Visible = false
			};
			sidebar.Controls.Add(p);
			p.BringToFront();
		}

		public static void MarkActive(Button btn)
		{
			if (btn?.Parent is not Panel sidebar) return;
			var highlight = sidebar.Controls.Find("panelActive", false).FirstOrDefault();
			if (highlight != null)
			{
				highlight.Visible = true;
				highlight.Top = btn.Top;
			}
			foreach (var b in sidebar.Controls.OfType<Button>())
			{
				b.Tag = null;
				if (b is PastelButton pb)
				{
					// Đặt lại màu bình thường cho PastelButton
					pb.NormalColor = PrimaryButton;
				}
				else
				{
					b.BackColor = SidebarBackground;
				}
			}
			btn.Tag = "active";
			if (btn is PastelButton activePb)
			{
				// Đổi màu active cho PastelButton
				activePb.NormalColor = SidebarHover;
			}
			else
			{
				btn.BackColor = SidebarHover;
			}
		}

		public static void StyleSidebarButton(Button btn, Panel sidebar)
		{
			// Nếu là PastelButton thì để nguyên hiệu ứng như nút đăng nhập
			if (btn is PastelButton pb)
			{
				// Điều chỉnh vị trí và kích thước động theo sidebar
				pb.Width = Math.Max(sidebar.Width - 20, 210); // Min width 210px
				pb.Left = 10;
				pb.Height = 50;
				pb.TextAlign = ContentAlignment.MiddleCenter;
				pb.Padding = new Padding(8, 4, 8, 4);
				// Tắt shadow và border để tránh artifact
				pb.EnableShadow = false;
				pb.BorderThickness = 0;
				
				// Cập nhật Region bo góc
				pb.Invalidate();
				return;
			}

			// Styling cho Button thường
			btn.FlatStyle = FlatStyle.Flat;
			btn.FlatAppearance.BorderSize = 0;
			btn.BackColor = SidebarBackground;
			btn.ForeColor = TextDark;
			btn.Font = _baseFont;
			btn.TextAlign = ContentAlignment.MiddleLeft;
			btn.Padding = new Padding(14, 0, 8, 0);
			btn.Width = sidebar.Width - 10;
			btn.Left = 6;
			if (!_styled.Contains(btn))
			{
				btn.MouseEnter += (s, e) => { if (!ReferenceEquals(btn.Tag, "active")) btn.BackColor = SidebarHover; };
				btn.MouseLeave += (s, e) => { if (!ReferenceEquals(btn.Tag, "active")) btn.BackColor = SidebarBackground; };
				_styled.Add(btn);
			}
		}

		public static void ApplyLoginForm(FormLogin form)
		{
			form.BackColor = LoginBackground;
			form.Font = _baseFont;
			form.StartPosition = FormStartPosition.CenterScreen;
			form.FormBorderStyle = FormBorderStyle.FixedDialog;
			form.MaximizeBox = false;
			form.MinimumSize = new Size(420, 260);
			ApplyFadeIn(form);
			if (!form.Controls.OfType<Label>().Any(l => l.Name == "lblLoginTitle"))
			{
				var lbl = new Label
				{
					Name = "lblLoginTitle",
					Text = "Internet Cafe",
					Font = _titleFont,
					ForeColor = Color.Black,
					AutoSize = false,
					Height = 42,
					Dock = DockStyle.Top,
					TextAlign = ContentAlignment.MiddleCenter,
					BackColor = LoginBackground
				};
				form.Controls.Add(lbl);
				lbl.BringToFront();
			}
			foreach (var tb in form.Controls.OfType<TextBox>()) { StyleTextBox(tb); RoundTextBox(tb, 8); }
			foreach (var cb in form.Controls.OfType<ComboBox>())
			{
				cb.FlatStyle = FlatStyle.Flat;
				cb.BackColor = Color.White;
				cb.ForeColor = TextDark;
				cb.Font = _baseFont;
			}
			var btn = form.Controls.OfType<Button>().FirstOrDefault();
			if (btn != null) StylePrimaryButton(btn);
		}

		public static void StylePrimaryButton(Button btn)
		{
			if (btn is PastelButton) return; // already styled custom control
			btn.FlatStyle = FlatStyle.Flat;
			btn.FlatAppearance.BorderSize = 0;
			btn.BackColor = PrimaryButton;
			btn.ForeColor = Color.Black;
			btn.Font = _baseFont;
			btn.Height = Math.Max(btn.Height, 34);
			btn.Padding = new Padding(8, 4, 8, 4);
			if (!_styled.Contains(btn))
			{
				btn.MouseEnter += (s, e) => btn.BackColor = PrimaryHover;
				btn.MouseLeave += (s, e) => btn.BackColor = PrimaryButton;
				btn.HandleCreated += (s, e) => ApplyRoundedRegion(btn, 12);
				btn.Resize += (s, e) => ApplyRoundedRegion(btn, 12);
				_styled.Add(btn);
			}
		}

		public static void StyleTextBox(TextBox tb)
		{
			tb.BorderStyle = BorderStyle.FixedSingle;
			tb.BackColor = Color.White;
			tb.ForeColor = TextDark;
			tb.Padding = new Padding(2);
			if (!_styled.Contains(tb))
			{
				tb.GotFocus += (s, e) => tb.BackColor = Color.White;
				_styled.Add(tb);
			}
		}

		private static void RoundTextBox(TextBox tb, int radius)
		{
			tb.HandleCreated += (s, e) => ApplyRoundedRegion(tb, radius);
			tb.Resize += (s, e) => ApplyRoundedRegion(tb, radius);
		}

		public static void StyleDataGridView(DataGridView dgv)
		{
			dgv.EnableHeadersVisualStyles = false;
			dgv.BackgroundColor = FormBackground;
			dgv.BorderStyle = BorderStyle.None;
			dgv.ColumnHeadersDefaultCellStyle.BackColor = DataGridHeader;
			dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
			dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			dgv.ColumnHeadersHeight = 36;
			dgv.RowTemplate.Height = 32;
			dgv.DefaultCellStyle.Font = _baseFont;
			dgv.DefaultCellStyle.BackColor = Color.White;
			dgv.DefaultCellStyle.ForeColor = TextDark;
			dgv.DefaultCellStyle.SelectionBackColor = PrimaryButton;
			dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
			dgv.AlternatingRowsDefaultCellStyle.BackColor = AltRow;
			dgv.AlternatingRowsDefaultCellStyle.ForeColor = TextDark;
			dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dgv.GridColor = FormBackground;
			
			// Tối ưu cho sidebar rộng hơn - DataGridView sẽ có nhiều không gian hơn
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv.ScrollBars = ScrollBars.Vertical;
			dgv.AllowUserToResizeColumns = true;
			dgv.AllowUserToResizeRows = false;
			
			DoubleBuffer(dgv);
		}

		public static void HookChildForm(Form form)
		{
			ApplyFontRecursive(form.Controls);
			RefreshAllControls(form);
		}

		public static void RefreshAllControls(Form form)
		{
			// Refresh DataGridView
			foreach (var dgv in form.Controls.OfType<DataGridView>().ToList()) 
			{
				StyleDataGridView(dgv);
				dgv.RowTemplate.Height = 32; // Giữ row height cố định
			}
			foreach (var dgv in GetAllControls(form).OfType<DataGridView>()) 
			{
				StyleDataGridView(dgv);
				dgv.RowTemplate.Height = 32;
			}

			// Refresh buttons với anchor đúng
			foreach (var btn in GetAllControls(form).OfType<Button>())
			{
				if (btn.Parent?.Name == "panelSidebar") continue;
				if (btn is PastelButton pb)
				{
					// PastelButton co giãn theo chiều ngang
					pb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
				}
				else
				{
					StylePrimaryButton(btn);
					btn.Anchor = AnchorStyles.Top | AnchorStyles.Left;
				}
			}

			// Refresh TextBox
			foreach (var tb in GetAllControls(form).OfType<TextBox>()) 
			{ 
				StyleTextBox(tb); 
			}

			// Force refresh toàn bộ form
			form.Refresh();
		}

		private static void ApplyFontRecursive(Control.ControlCollection controls)
		{
			foreach (Control c in controls)
			{
				c.Font = _baseFont;
				if (c.HasChildren) ApplyFontRecursive(c.Controls);
			}
		}

		private static IEnumerable<Control> GetAllControls(Control root)
		{
			foreach (Control c in root.Controls)
			{
				yield return c;
				foreach (var child in GetAllControls(c)) yield return child;
			}
		}

		private static void ApplyRoundedRegion(Control c, int radius)
		{
			var path = new GraphicsPath();
			var rect = c.ClientRectangle;
			if (rect.Width <= 0 || rect.Height <= 0) return;
			int d = radius * 2;
			path.AddArc(rect.X, rect.Y, d, d, 180, 90);
			path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
			path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
			path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
			path.CloseFigure();
			try { c.Region = new Region(path); } catch { }
		}

		private static void DoubleBuffer(DataGridView dgv)
		{
			try
			{
				typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
					?.SetValue(dgv, true, null);
			}
			catch { }
		}

		public static void ApplyFadeIn(Form form)
		{
			// Chỉ fade nếu chưa visible hoặc opacity < 1
			if (!form.Visible || form.Opacity < 1)
			{
				form.Opacity = 0.3; // Bắt đầu từ 30% để mượt hơn
				var timer = new System.Windows.Forms.Timer { Interval = 15 };
				timer.Tick += (s, e) =>
				{
					if (form.IsDisposed) { timer.Stop(); timer.Dispose(); return; }
					form.Opacity += 0.1; // Tăng nhanh hơn
					if (form.Opacity >= 1)
					{
						form.Opacity = 1;
						timer.Stop();
						timer.Dispose();
					}
				};
				timer.Start();
			}
		}

		private static readonly HashSet<Control> _styled = new();
	}
}

