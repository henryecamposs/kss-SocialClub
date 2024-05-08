namespace kss_A_Ganador.Forms.Plantillas
{
	partial class dlgEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgEdit));
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.swbtnActivo = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.lcSave = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.layoutGroup4 = new DevComponents.DotNetBar.Layout.LayoutGroup();
            this.laybtnCancel = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.laybtnSave = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelDatoPpal1 = new ksslib_c_design.Controls.LabelDatoPpal();
            this.lcSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(0, 0);
            this.btnClose.TabIndex = 0;
            // 
            // swbtnActivo
            // 
            // 
            // 
            // 
            this.swbtnActivo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swbtnActivo.Dock = System.Windows.Forms.DockStyle.Right;
            this.swbtnActivo.Location = new System.Drawing.Point(391, 29);
            this.swbtnActivo.MaximumSize = new System.Drawing.Size(85, 30);
            this.swbtnActivo.Name = "swbtnActivo";
            this.swbtnActivo.OffText = "Inactivo";
            this.swbtnActivo.OnText = "Activo";
            this.swbtnActivo.Size = new System.Drawing.Size(74, 30);
            this.swbtnActivo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbtnActivo.TabIndex = 1;
            this.swbtnActivo.Value = true;
            this.swbtnActivo.ValueObject = "Y";
            this.swbtnActivo.ValueChanged += new System.EventHandler(this.swbtnActivo_ValueChanged);
            // 
            // lcSave
            // 
            this.lcSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lcSave.BackColor = System.Drawing.Color.Gray;
            this.lcSave.Controls.Add(this.btnCancel);
            this.lcSave.Controls.Add(this.btnSave);
            this.lcSave.ForeColor = System.Drawing.Color.Black;
            this.lcSave.Location = new System.Drawing.Point(120, 300);
            this.lcSave.Margin = new System.Windows.Forms.Padding(0);
            this.lcSave.Name = "lcSave";
            // 
            // 
            // 
            this.lcSave.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutGroup4});
            this.lcSave.Size = new System.Drawing.Size(232, 33);
            this.lcSave.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(3, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 27);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.Symbol = "";
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "<b>F10</b> Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnSave.Location = new System.Drawing.Point(118, 3);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 27);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.Symbol = "";
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "<b>F9</b> Guardar";
            this.btnSave.TextColor = System.Drawing.Color.Black;
            // 
            // layoutGroup4
            // 
            this.layoutGroup4.Height = 100;
            this.layoutGroup4.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            this.layoutGroup4.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.laybtnCancel,
            this.laybtnSave});
            this.layoutGroup4.MinSize = new System.Drawing.Size(120, 32);
            this.layoutGroup4.Name = "layoutGroup4";
            this.layoutGroup4.Padding = new System.Windows.Forms.Padding(0);
            this.layoutGroup4.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.layoutGroup4.Width = 230;
            // 
            // laybtnCancel
            // 
            this.laybtnCancel.Control = this.btnCancel;
            this.laybtnCancel.Height = 100;
            this.laybtnCancel.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            this.laybtnCancel.MinSize = new System.Drawing.Size(32, 20);
            this.laybtnCancel.Name = "laybtnCancel";
            this.laybtnCancel.Padding = new System.Windows.Forms.Padding(3);
            this.laybtnCancel.Width = 50;
            this.laybtnCancel.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // laybtnSave
            // 
            this.laybtnSave.Control = this.btnSave;
            this.laybtnSave.Height = 100;
            this.laybtnSave.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            this.laybtnSave.MinSize = new System.Drawing.Size(32, 20);
            this.laybtnSave.Name = "laybtnSave";
            this.laybtnSave.Padding = new System.Windows.Forms.Padding(3);
            this.laybtnSave.Width = 50;
            this.laybtnSave.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // labelDatoPpal1
            // 
            this.labelDatoPpal1.BackColor = System.Drawing.Color.Transparent;
            this.labelDatoPpal1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDatoPpal1.Location = new System.Drawing.Point(4, 29);
            this.labelDatoPpal1.MaximumSize = new System.Drawing.Size(0, 33);
            this.labelDatoPpal1.MinimumSize = new System.Drawing.Size(334, 29);
            this.labelDatoPpal1.Name = "labelDatoPpal1";
            this.labelDatoPpal1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDatoPpal1.Size = new System.Drawing.Size(387, 29);
            this.labelDatoPpal1.TabIndex = 32;
            this.labelDatoPpal1.Load += new System.EventHandler(this.labelDatoPpal1_Load);
            // 
            // dlgEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 344);
            this.Controls.Add(this.labelDatoPpal1);
            this.Controls.Add(this.swbtnActivo);
            this.Controls.Add(this.lcSave);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(469, 344);
            this.Name = "dlgEdit";
            this.Text = "dialogo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DialogoGuardar_KeyDown);
            this.Controls.SetChildIndex(this.lcSave, 0);
            this.Controls.SetChildIndex(this.swbtnActivo, 0);
            this.Controls.SetChildIndex(this.labelDatoPpal1, 0);
            this.lcSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        internal System.Windows.Forms.BindingSource bindingSource1;
        internal DevComponents.DotNetBar.Controls.SwitchButton swbtnActivo;
        private DevComponents.DotNetBar.Layout.LayoutControl lcSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Layout.LayoutGroup layoutGroup4;
        private DevComponents.DotNetBar.Layout.LayoutControlItem laybtnCancel;
        private DevComponents.DotNetBar.Layout.LayoutControlItem laybtnSave;
        private ksslib_c_design.Controls.LabelDatoPpal labelDatoPpal1;
        private DevComponents.DotNetBar.ButtonX btnClose;
    }
}