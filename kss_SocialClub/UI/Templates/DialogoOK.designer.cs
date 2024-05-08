namespace kss_A_Ganador.Forms.Plantillas
{
	partial class DialogoOK
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
            this.panelTitulo = new DevComponents.DotNetBar.PanelEx();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnEsc = new DevComponents.DotNetBar.ButtonX();
            this.pickssLogo = new System.Windows.Forms.PictureBox();
            this.panelBottom = new DevComponents.DotNetBar.PanelEx();
            this.lcBottom = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.laypicKssLogo = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layPanelBottom = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layBtnEsc = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickssLogo)).BeginInit();
            this.lcBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelTitulo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelTitulo.Controls.Add(this.btnClose);
            this.panelTitulo.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitulo.Location = new System.Drawing.Point(4, 4);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Padding = new System.Windows.Forms.Padding(5);
            this.panelTitulo.Size = new System.Drawing.Size(461, 25);
            this.panelTitulo.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelTitulo.Style.BackColor1.Color = System.Drawing.Color.LightGray;
            this.panelTitulo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelTitulo.Style.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitulo.Style.ForeColor.Color = System.Drawing.Color.Black;
            this.panelTitulo.Style.GradientAngle = 90;
            this.panelTitulo.TabIndex = 0;
            this.panelTitulo.Text = "{0}";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FocusCuesEnabled = false;
            this.btnClose.Location = new System.Drawing.Point(432, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.MaximumSize = new System.Drawing.Size(24, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5);
            this.btnClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnClose.ShowSubItems = false;
            this.btnClose.Size = new System.Drawing.Size(24, 15);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.Symbol = "";
            this.btnClose.SymbolColor = System.Drawing.Color.Black;
            this.btnClose.SymbolSize = 12F;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEsc
            // 
            this.btnEsc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEsc.BackColor = System.Drawing.Color.Gray;
            this.btnEsc.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnEsc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEsc.Location = new System.Drawing.Point(390, 4);
            this.btnEsc.Margin = new System.Windows.Forms.Padding(0);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(67, 40);
            this.btnEsc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEsc.Symbol = "";
            this.btnEsc.TabIndex = 2;
            this.btnEsc.Text = "<b>ESC</b> Cerrar";
            this.btnEsc.TextColor = System.Drawing.Color.Black;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // pickssLogo
            // 
            this.pickssLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickssLogo.Image = global::kss_SocialClub.Properties.Resources.logo_gris_06;
            this.pickssLogo.Location = new System.Drawing.Point(4, 4);
            this.pickssLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pickssLogo.Name = "pickssLogo";
            this.pickssLogo.Size = new System.Drawing.Size(56, 40);
            this.pickssLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pickssLogo.TabIndex = 0;
            this.pickssLogo.TabStop = false;
            // 
            // panelBottom
            // 
            this.panelBottom.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBottom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelBottom.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelBottom.Location = new System.Drawing.Point(68, 4);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(3);
            this.panelBottom.Size = new System.Drawing.Size(314, 40);
            this.panelBottom.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBottom.Style.BackColor1.Color = System.Drawing.Color.LightGray;
            this.panelBottom.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelBottom.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBottom.Style.GradientAngle = 90;
            this.panelBottom.TabIndex = 1;
            // 
            // lcBottom
            // 
            this.lcBottom.BackColor = System.Drawing.Color.White;
            this.lcBottom.Controls.Add(this.pickssLogo);
            this.lcBottom.Controls.Add(this.btnEsc);
            this.lcBottom.Controls.Add(this.panelBottom);
            this.lcBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lcBottom.ForeColor = System.Drawing.Color.Black;
            this.lcBottom.Location = new System.Drawing.Point(4, 199);
            this.lcBottom.Margin = new System.Windows.Forms.Padding(0);
            this.lcBottom.MaximumSize = new System.Drawing.Size(0, 47);
            this.lcBottom.MinimumSize = new System.Drawing.Size(461, 47);
            this.lcBottom.Name = "lcBottom";
            // 
            // 
            // 
            this.lcBottom.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.laypicKssLogo,
            this.layPanelBottom,
            this.layBtnEsc});
            this.lcBottom.Size = new System.Drawing.Size(461, 47);
            this.lcBottom.TabIndex = 25;
            // 
            // laypicKssLogo
            // 
            this.laypicKssLogo.Control = this.pickssLogo;
            this.laypicKssLogo.Height = 44;
            this.laypicKssLogo.MinSize = new System.Drawing.Size(64, 18);
            this.laypicKssLogo.Name = "laypicKssLogo";
            this.laypicKssLogo.Width = 10;
            this.laypicKssLogo.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layPanelBottom
            // 
            this.layPanelBottom.Control = this.panelBottom;
            this.layPanelBottom.Height = 48;
            this.layPanelBottom.MinSize = new System.Drawing.Size(32, 20);
            this.layPanelBottom.Name = "layPanelBottom";
            this.layPanelBottom.Width = 70;
            this.layPanelBottom.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layBtnEsc
            // 
            this.layBtnEsc.Control = this.btnEsc;
            this.layBtnEsc.Height = 46;
            this.layBtnEsc.MinSize = new System.Drawing.Size(32, 20);
            this.layBtnEsc.Name = "layBtnEsc";
            this.layBtnEsc.Width = 20;
            this.layBtnEsc.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // DialogoOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 250);
            this.ControlBox = false;
            this.Controls.Add(this.lcBottom);
            this.Controls.Add(this.panelTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(469, 250);
            this.Name = "DialogoOK";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Dialogo_Guardar_Datos1";
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pickssLogo)).EndInit();
            this.lcBottom.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		internal DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnEsc;
        internal DevComponents.DotNetBar.PanelEx panelTitulo;
        private System.Windows.Forms.PictureBox pickssLogo;
        private DevComponents.DotNetBar.Layout.LayoutControl lcBottom;
        private DevComponents.DotNetBar.Layout.LayoutControlItem laypicKssLogo;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layBtnEsc;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layPanelBottom;
        internal DevComponents.DotNetBar.PanelEx panelBottom;
    }
}