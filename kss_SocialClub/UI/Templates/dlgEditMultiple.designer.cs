namespace kss_A_Ganador.Forms.Plantillas
{
	partial class dlgEditMultiple<TEntity>
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.panelBottom = new DevComponents.DotNetBar.PanelEx();
            this.bnDatosPPAL = new DevComponents.DotNetBar.Controls.BindingNavigatorEx(this.components);
            this.btnDatosPPAL_Add = new DevComponents.DotNetBar.ButtonItem();
            this.lblDatosPPAL_Count = new DevComponents.DotNetBar.LabelItem();
            this.btnDatosPPAL_Del = new DevComponents.DotNetBar.ButtonItem();
            this.btnDatosPPAL_First = new DevComponents.DotNetBar.ButtonItem();
            this.btnDatosPPAL_Prev = new DevComponents.DotNetBar.ButtonItem();
            this.txtDatosPPAL_PositionItem = new DevComponents.DotNetBar.TextBoxItem();
            this.btnDatosPPAL_Next = new DevComponents.DotNetBar.ButtonItem();
            this.btnDatosPPAL_Last = new DevComponents.DotNetBar.ButtonItem();
            this.laycRegistro = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.layoutGroup1 = new DevComponents.DotNetBar.Layout.LayoutGroup();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.chkBusqueda01 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkBusqueda02 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtFind = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnFind = new DevComponents.DotNetBar.ButtonX();
            this.bnEncontrados = new DevComponents.DotNetBar.Controls.BindingNavigatorEx(this.components);
            this.btnEncFirst = new DevComponents.DotNetBar.ButtonItem();
            this.btnEncPrev = new DevComponents.DotNetBar.ButtonItem();
            this.btnEncNext = new DevComponents.DotNetBar.ButtonItem();
            this.btnEncLast = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cmbBusqueda = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.BindingSource_PPAL = new System.Windows.Forms.BindingSource(this.components);
            this.lblDatosEnc_Status = new DevComponents.DotNetBar.LabelX();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnDatosPPAL)).BeginInit();
            this.laycRegistro.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnEncontrados)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_PPAL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FocusCuesEnabled = false;
            this.btnClose.Location = new System.Drawing.Point(647, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.MaximumSize = new System.Drawing.Size(24, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5);
            this.btnClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnClose.ShowSubItems = false;
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.Symbol = "";
            this.btnClose.SymbolSize = 12F;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBottom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelBottom.Controls.Add(this.bnDatosPPAL);
            this.panelBottom.Controls.Add(this.laycRegistro);
            this.panelBottom.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(2, 363);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(3);
            this.panelBottom.Size = new System.Drawing.Size(676, 44);
            this.panelBottom.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBottom.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelBottom.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelBottom.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBottom.Style.GradientAngle = 90;
            this.panelBottom.TabIndex = 0;
            // 
            // bnDatosPPAL
            // 
            this.bnDatosPPAL.AddNewRecordButton = this.btnDatosPPAL_Add;
            this.bnDatosPPAL.AntiAlias = true;
            this.bnDatosPPAL.BackColor = System.Drawing.Color.Transparent;
            this.bnDatosPPAL.CountLabel = this.lblDatosPPAL_Count;
            this.bnDatosPPAL.CountLabelFormat = "of {0}";
            this.bnDatosPPAL.DeleteButton = this.btnDatosPPAL_Del;
            this.bnDatosPPAL.Dock = System.Windows.Forms.DockStyle.Left;
            this.bnDatosPPAL.DockSide = DevComponents.DotNetBar.eDockSide.Bottom;
            this.bnDatosPPAL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnDatosPPAL.IsMaximized = false;
            this.bnDatosPPAL.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDatosPPAL_First,
            this.btnDatosPPAL_Prev,
            this.txtDatosPPAL_PositionItem,
            this.lblDatosPPAL_Count,
            this.btnDatosPPAL_Next,
            this.btnDatosPPAL_Last,
            this.btnDatosPPAL_Add,
            this.btnDatosPPAL_Del});
            this.bnDatosPPAL.ItemSpacing = 3;
            this.bnDatosPPAL.Location = new System.Drawing.Point(3, 3);
            this.bnDatosPPAL.Margin = new System.Windows.Forms.Padding(0);
            this.bnDatosPPAL.MoveFirstButton = this.btnDatosPPAL_First;
            this.bnDatosPPAL.MoveLastButton = this.btnDatosPPAL_Last;
            this.bnDatosPPAL.MoveNextButton = this.btnDatosPPAL_Next;
            this.bnDatosPPAL.MovePreviousButton = this.btnDatosPPAL_Prev;
            this.bnDatosPPAL.Name = "bnDatosPPAL";
            this.bnDatosPPAL.PositionTextBox = this.txtDatosPPAL_PositionItem;
            this.bnDatosPPAL.Size = new System.Drawing.Size(310, 38);
            this.bnDatosPPAL.Stretch = true;
            this.bnDatosPPAL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnDatosPPAL.TabIndex = 0;
            this.bnDatosPPAL.TabStop = false;
            this.bnDatosPPAL.Text = "bindingNavigatorEx2";
            // 
            // btnDatosPPAL_Add
            // 
            this.btnDatosPPAL_Add.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDatosPPAL_Add.HotFontBold = true;
            this.btnDatosPPAL_Add.Name = "btnDatosPPAL_Add";
            this.btnDatosPPAL_Add.Symbol = "";
            this.btnDatosPPAL_Add.SymbolSize = 24F;
            this.btnDatosPPAL_Add.Tag = "4";
            this.btnDatosPPAL_Add.Text = "Agregar";
            this.btnDatosPPAL_Add.Click += new System.EventHandler(this.btnsCRUD_Click);
            // 
            // lblDatosPPAL_Count
            // 
            this.lblDatosPPAL_Count.Name = "lblDatosPPAL_Count";
            this.lblDatosPPAL_Count.Text = "of {0}";
            // 
            // btnDatosPPAL_Del
            // 
            this.btnDatosPPAL_Del.ForeColor = System.Drawing.Color.Red;
            this.btnDatosPPAL_Del.HotFontBold = true;
            this.btnDatosPPAL_Del.Name = "btnDatosPPAL_Del";
            this.btnDatosPPAL_Del.Symbol = "";
            this.btnDatosPPAL_Del.SymbolSize = 24F;
            this.btnDatosPPAL_Del.Tag = "5";
            this.btnDatosPPAL_Del.Text = "Eliminar";
            this.btnDatosPPAL_Del.Click += new System.EventHandler(this.btnsCRUD_Click);
            // 
            // btnDatosPPAL_First
            // 
            this.btnDatosPPAL_First.Name = "btnDatosPPAL_First";
            this.btnDatosPPAL_First.Symbol = "";
            this.btnDatosPPAL_First.SymbolColor = System.Drawing.Color.Black;
            this.btnDatosPPAL_First.SymbolSize = 24F;
            this.btnDatosPPAL_First.Tag = "0";
            this.btnDatosPPAL_First.Text = "Move first";
            this.btnDatosPPAL_First.Click += new System.EventHandler(this.btnsCRUD_Click);
            // 
            // btnDatosPPAL_Prev
            // 
            this.btnDatosPPAL_Prev.Name = "btnDatosPPAL_Prev";
            this.btnDatosPPAL_Prev.Symbol = "";
            this.btnDatosPPAL_Prev.SymbolColor = System.Drawing.Color.Black;
            this.btnDatosPPAL_Prev.SymbolSize = 24F;
            this.btnDatosPPAL_Prev.Tag = "1";
            this.btnDatosPPAL_Prev.Text = "Move previous";
            this.btnDatosPPAL_Prev.Click += new System.EventHandler(this.btnsCRUD_Click);
            // 
            // txtDatosPPAL_PositionItem
            // 
            this.txtDatosPPAL_PositionItem.AccessibleName = "Position";
            this.txtDatosPPAL_PositionItem.BeginGroup = true;
            this.txtDatosPPAL_PositionItem.Name = "txtDatosPPAL_PositionItem";
            this.txtDatosPPAL_PositionItem.Text = "0";
            this.txtDatosPPAL_PositionItem.TextBoxWidth = 54;
            this.txtDatosPPAL_PositionItem.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // btnDatosPPAL_Next
            // 
            this.btnDatosPPAL_Next.BeginGroup = true;
            this.btnDatosPPAL_Next.Name = "btnDatosPPAL_Next";
            this.btnDatosPPAL_Next.Symbol = "";
            this.btnDatosPPAL_Next.SymbolColor = System.Drawing.Color.Black;
            this.btnDatosPPAL_Next.SymbolSize = 24F;
            this.btnDatosPPAL_Next.Tag = "2";
            this.btnDatosPPAL_Next.Text = "Move next";
            this.btnDatosPPAL_Next.Click += new System.EventHandler(this.btnsCRUD_Click);
            // 
            // btnDatosPPAL_Last
            // 
            this.btnDatosPPAL_Last.Name = "btnDatosPPAL_Last";
            this.btnDatosPPAL_Last.Symbol = "";
            this.btnDatosPPAL_Last.SymbolColor = System.Drawing.Color.Black;
            this.btnDatosPPAL_Last.SymbolSize = 24F;
            this.btnDatosPPAL_Last.Tag = "3";
            this.btnDatosPPAL_Last.Text = "Move last";
            this.btnDatosPPAL_Last.Click += new System.EventHandler(this.btnsCRUD_Click);
            // 
            // laycRegistro
            // 
            this.laycRegistro.BackColor = System.Drawing.Color.LightSteelBlue;
            this.laycRegistro.Controls.Add(this.btnOK);
            this.laycRegistro.Controls.Add(this.btnGuardar);
            this.laycRegistro.Controls.Add(this.btnCancelar);
            this.laycRegistro.Dock = System.Windows.Forms.DockStyle.Right;
            this.laycRegistro.ForeColor = System.Drawing.Color.Black;
            this.laycRegistro.Location = new System.Drawing.Point(316, 3);
            this.laycRegistro.Name = "laycRegistro";
            // 
            // 
            // 
            this.laycRegistro.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutGroup1,
            this.layoutSpacerItem1,
            this.layoutControlItem3});
            this.laycRegistro.Size = new System.Drawing.Size(357, 38);
            this.laycRegistro.TabIndex = 144;
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(246, 4);
            this.btnOK.Margin = new System.Windows.Forms.Padding(0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 30);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.Symbol = "";
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "<b>ESC</b> Cerrar";
            this.btnOK.TextColor = System.Drawing.Color.Black;
            this.btnOK.Click += new System.EventHandler(this.btnCerrar_click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.Location = new System.Drawing.Point(4, 4);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 30);
            this.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGuardar.Symbol = "";
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Tag = "6";
            this.btnGuardar.Text = "<b>F9</b> Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.Black;
            this.btnGuardar.Click += new System.EventHandler(this.btnsCRUD_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(119, 4);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 30);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.Symbol = "";
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Tag = "7";
            this.btnCancelar.Text = "<b>F10</b> Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.Black;
            this.btnCancelar.Click += new System.EventHandler(this.btnsCRUD_Click);
            // 
            // layoutGroup1
            // 
            this.layoutGroup1.Height = 100;
            this.layoutGroup1.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            this.layoutGroup1.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutGroup1.MinSize = new System.Drawing.Size(120, 32);
            this.layoutGroup1.Name = "layoutGroup1";
            this.layoutGroup1.Padding = new System.Windows.Forms.Padding(0);
            this.layoutGroup1.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.layoutGroup1.Width = 230;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnGuardar;
            this.layoutControlItem1.Height = 38;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Width = 115;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnCancelar;
            this.layoutControlItem2.Height = 38;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Width = 115;
            // 
            // layoutSpacerItem1
            // 
            this.layoutSpacerItem1.Height = 32;
            this.layoutSpacerItem1.Name = "layoutSpacerItem1";
            this.layoutSpacerItem1.Width = 50;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnOK;
            this.layoutControlItem3.Height = 100;
            this.layoutControlItem3.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            this.layoutControlItem3.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Width = 115;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.LightGray;
            this.panelBusqueda.Controls.Add(this.labelX2);
            this.panelBusqueda.Controls.Add(this.panelEx2);
            this.panelBusqueda.Controls.Add(this.btnFind);
            this.panelBusqueda.Controls.Add(this.bnEncontrados);
            this.panelBusqueda.Location = new System.Drawing.Point(2, 41);
            this.panelBusqueda.MaximumSize = new System.Drawing.Size(0, 36);
            this.panelBusqueda.MinimumSize = new System.Drawing.Size(676, 36);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.panelBusqueda.Size = new System.Drawing.Size(676, 36);
            this.superTooltip1.SetSuperTooltip(this.panelBusqueda, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Hola", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.panelBusqueda.TabIndex = 136;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.BackgroundStyle.BackColorGradientAngle = 90;
            this.labelX2.BackgroundStyle.BorderBottomWidth = 1;
            this.labelX2.BackgroundStyle.BorderColor = System.Drawing.Color.SteelBlue;
            this.labelX2.BackgroundStyle.BorderLeftWidth = 1;
            this.labelX2.BackgroundStyle.BorderRightWidth = 1;
            this.labelX2.BackgroundStyle.BorderTopWidth = 1;
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.labelX2.BackgroundStyle.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.BackgroundStyle.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.BackgroundStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.BackgroundStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.BackgroundStyle.PaddingLeft = 2;
            this.labelX2.BackgroundStyle.PaddingRight = 2;
            this.labelX2.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.labelX2.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.labelX2.BackgroundStyle.TextShadowColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelX2.BackgroundStyle.TextShadowOffset = new System.Drawing.Point(3, 3);
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(2, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(51, 26);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX2.TabIndex = 144;
            this.labelX2.Text = "Buscar:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.chkBusqueda01);
            this.panelEx2.Controls.Add(this.chkBusqueda02);
            this.panelEx2.Controls.Add(this.txtFind);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx2.Location = new System.Drawing.Point(164, 5);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.panelEx2.Size = new System.Drawing.Size(341, 26);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.Transparent;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.BorderWidth = 0;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 153;
            // 
            // chkBusqueda01
            // 
            // 
            // 
            // 
            this.chkBusqueda01.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkBusqueda01.BackgroundStyle.PaddingLeft = 2;
            this.chkBusqueda01.BackgroundStyle.PaddingRight = 2;
            this.chkBusqueda01.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkBusqueda01.Checked = true;
            this.chkBusqueda01.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBusqueda01.CheckValue = "Y";
            this.chkBusqueda01.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkBusqueda01.Location = new System.Drawing.Point(4, 3);
            this.chkBusqueda01.Name = "chkBusqueda01";
            this.chkBusqueda01.Size = new System.Drawing.Size(84, 23);
            this.chkBusqueda01.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkBusqueda01.TabIndex = 153;
            this.chkBusqueda01.Text = "Código";
            this.chkBusqueda01.CheckedChanged += new System.EventHandler(this.chkFind_CheckedChanged);
            // 
            // chkBusqueda02
            // 
            // 
            // 
            // 
            this.chkBusqueda02.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkBusqueda02.BackgroundStyle.PaddingLeft = 2;
            this.chkBusqueda02.BackgroundStyle.PaddingRight = 2;
            this.chkBusqueda02.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkBusqueda02.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkBusqueda02.Location = new System.Drawing.Point(88, 3);
            this.chkBusqueda02.Name = "chkBusqueda02";
            this.chkBusqueda02.Size = new System.Drawing.Size(87, 23);
            this.chkBusqueda02.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkBusqueda02.TabIndex = 152;
            this.chkBusqueda02.Text = "Descripción";
            this.chkBusqueda02.CheckedChanged += new System.EventHandler(this.chkFind_CheckedChanged);
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFind.Border.Class = "TextBoxBorder";
            this.txtFind.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFind.DisabledBackColor = System.Drawing.Color.White;
            this.txtFind.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtFind.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtFind.FocusHighlightEnabled = true;
            this.txtFind.ForeColor = System.Drawing.Color.Black;
            this.txtFind.Location = new System.Drawing.Point(175, 3);
            this.txtFind.MinimumSize = new System.Drawing.Size(0, 20);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(164, 20);
            this.txtFind.TabIndex = 147;
            this.txtFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFind_KeyPress);
            this.txtFind.Leave += new System.EventHandler(this.txtFind_LostFocus);
            // 
            // btnFind
            // 
            this.btnFind.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFind.BackColor = System.Drawing.Color.MediumBlue;
            this.btnFind.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(505, 5);
            this.btnFind.Margin = new System.Windows.Forms.Padding(5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnFind.Size = new System.Drawing.Size(79, 26);
            this.btnFind.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFind.Symbol = "";
            this.btnFind.SymbolSize = 10F;
            this.btnFind.TabIndex = 148;
            this.btnFind.Text = "F3 Buscar";
            this.btnFind.TextColor = System.Drawing.Color.White;
            this.btnFind.Click += new System.EventHandler(this.btnFind_click);
            // 
            // bnEncontrados
            // 
            this.bnEncontrados.AntiAlias = true;
            this.bnEncontrados.BackColor = System.Drawing.Color.Transparent;
            this.bnEncontrados.CountLabel = null;
            this.bnEncontrados.CountLabelFormat = "of {0}";
            this.bnEncontrados.Dock = System.Windows.Forms.DockStyle.Right;
            this.bnEncontrados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnEncontrados.IsMaximized = false;
            this.bnEncontrados.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnEncFirst,
            this.btnEncPrev,
            this.btnEncNext,
            this.btnEncLast});
            this.bnEncontrados.ItemSpacing = 3;
            this.bnEncontrados.Location = new System.Drawing.Point(584, 5);
            this.bnEncontrados.Margin = new System.Windows.Forms.Padding(0);
            this.bnEncontrados.MinimumSize = new System.Drawing.Size(90, 0);
            this.bnEncontrados.MoveFirstButton = this.btnEncFirst;
            this.bnEncontrados.MoveLastButton = this.btnEncLast;
            this.bnEncontrados.MoveNextButton = this.btnEncNext;
            this.bnEncontrados.MovePreviousButton = this.btnEncPrev;
            this.bnEncontrados.Name = "bnEncontrados";
            this.bnEncontrados.PaddingBottom = 0;
            this.bnEncontrados.PaddingTop = 3;
            this.bnEncontrados.Size = new System.Drawing.Size(90, 25);
            this.bnEncontrados.Stretch = true;
            this.bnEncontrados.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnEncontrados.TabIndex = 160;
            this.bnEncontrados.TabStop = false;
            this.bnEncontrados.Text = "bindingNavigatorEx2";
            this.bnEncontrados.VisibleChanged += new System.EventHandler(this.Buscar_BindingNavigator_VisibleChanged);
            // 
            // btnEncFirst
            // 
            this.btnEncFirst.Name = "btnEncFirst";
            this.btnEncFirst.Symbol = "";
            this.btnEncFirst.SymbolSize = 12F;
            this.btnEncFirst.Text = "Move first";
            // 
            // btnEncPrev
            // 
            this.btnEncPrev.Name = "btnEncPrev";
            this.btnEncPrev.Symbol = "";
            this.btnEncPrev.SymbolSize = 12F;
            this.btnEncPrev.Text = "Move previous";
            // 
            // btnEncNext
            // 
            this.btnEncNext.BeginGroup = true;
            this.btnEncNext.Name = "btnEncNext";
            this.btnEncNext.Symbol = "";
            this.btnEncNext.SymbolSize = 12F;
            this.btnEncNext.Text = "Move next";
            // 
            // btnEncLast
            // 
            this.btnEncLast.Name = "btnEncLast";
            this.btnEncLast.Symbol = "";
            this.btnEncLast.SymbolSize = 12F;
            this.btnEncLast.Text = "Move last";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.cmbBusqueda);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx1.Location = new System.Drawing.Point(48, 5);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.panelEx1.Size = new System.Drawing.Size(116, 26);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.Transparent;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.BorderWidth = 0;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 165;
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.DisplayMember = "Text";
            this.cmbBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBusqueda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusqueda.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmbBusqueda.FocusHighlightEnabled = true;
            this.cmbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBusqueda.ForeColor = System.Drawing.Color.Black;
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.ItemHeight = 14;
            this.cmbBusqueda.Location = new System.Drawing.Point(2, 3);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(112, 20);
            this.cmbBusqueda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbBusqueda.TabIndex = 162;
            this.cmbBusqueda.WatermarkText = "Agregar Datos";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // superTooltip1
            // 
            this.superTooltip1.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray);
            // 
            // BindingSource_PPAL
            // 
            this.BindingSource_PPAL.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.BindingSource_PPAL_AddingNew);
            this.BindingSource_PPAL.CurrentChanged += new System.EventHandler(this.BindingSource_PPAL_CurrentChanged);
            this.BindingSource_PPAL.PositionChanged += new System.EventHandler(this.BindingSource_PPAL_PositionChanged);
            // 
            // lblDatosEnc_Status
            // 
            this.lblDatosEnc_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatosEnc_Status.BackColor = System.Drawing.Color.LightYellow;
            // 
            // 
            // 
            this.lblDatosEnc_Status.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDatosEnc_Status.Location = new System.Drawing.Point(341, 79);
            this.lblDatosEnc_Status.Margin = new System.Windows.Forms.Padding(0);
            this.lblDatosEnc_Status.Name = "lblDatosEnc_Status";
            this.lblDatosEnc_Status.Size = new System.Drawing.Size(337, 18);
            this.lblDatosEnc_Status.TabIndex = 5;
            this.lblDatosEnc_Status.Text = "Estado de Edición";
            // 
            // dlgEditMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(680, 456);
            this.Controls.Add(this.lblDatosEnc_Status);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelBottom);
            this.MinimumSize = new System.Drawing.Size(680, 205);
            this.Name = "dlgEditMultiple";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "frmDatosEdit";
            this.Activated += new System.EventHandler(this.form_Activated);
            this.Deactivate += new System.EventHandler(this.form_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_Closed);
            this.Load += new System.EventHandler(this.dlgEditMultiple_Load);
            this.Shown += new System.EventHandler(this.form_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.Controls.SetChildIndex(this.panelBottom, 0);
            this.Controls.SetChildIndex(this.panelBusqueda, 0);
            this.Controls.SetChildIndex(this.lblDatosEnc_Status, 0);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnDatosPPAL)).EndInit();
            this.laycRegistro.ResumeLayout(false);
            this.panelBusqueda.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnEncontrados)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_PPAL)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private DevComponents.DotNetBar.PanelEx panelBottom;
		private DevComponents.DotNetBar.ButtonX btnOK;
		private DevComponents.DotNetBar.ButtonX btnGuardar;
		private System.Windows.Forms.Panel panelBusqueda;
		private DevComponents.DotNetBar.LabelX labelX2;
		private DevComponents.DotNetBar.PanelEx panelEx2;
		private DevComponents.DotNetBar.Controls.TextBoxX txtFind;
		private DevComponents.DotNetBar.ButtonX btnFind;
        private DevComponents.DotNetBar.Layout.LayoutControl laycRegistro;
        private DevComponents.DotNetBar.Layout.LayoutGroup layoutGroup1;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
        private DevComponents.DotNetBar.ButtonItem btnDatosPPAL_Add;
        private DevComponents.DotNetBar.LabelItem lblDatosPPAL_Count;
        private DevComponents.DotNetBar.ButtonItem btnDatosPPAL_Del;
        private DevComponents.DotNetBar.ButtonItem btnDatosPPAL_First;
        private DevComponents.DotNetBar.ButtonItem btnDatosPPAL_Prev;
        private DevComponents.DotNetBar.TextBoxItem txtDatosPPAL_PositionItem;
        private DevComponents.DotNetBar.ButtonItem btnDatosPPAL_Next;
        private DevComponents.DotNetBar.ButtonItem btnDatosPPAL_Last;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbBusqueda;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkBusqueda01;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkBusqueda02;
        private DevComponents.DotNetBar.ButtonItem btnEncFirst;
        private DevComponents.DotNetBar.ButtonItem btnEncPrev;
        private DevComponents.DotNetBar.ButtonItem btnEncNext;
        private DevComponents.DotNetBar.ButtonItem btnEncLast;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        private DevComponents.DotNetBar.LabelX lblDatosEnc_Status;
        internal DevComponents.DotNetBar.Controls.BindingNavigatorEx bnEncontrados;
        internal DevComponents.DotNetBar.Controls.BindingNavigatorEx bnDatosPPAL;
        internal System.Windows.Forms.BindingSource BindingSource_PPAL;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.DotNetBar.ButtonX btnClose;
    }
}