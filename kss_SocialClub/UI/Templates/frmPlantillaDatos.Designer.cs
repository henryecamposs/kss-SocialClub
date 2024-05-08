namespace kss_SocialClub.UI.Templates
{
    partial class frmPlantillaDatos<TEntity>
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
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnFirst = new DevComponents.DotNetBar.ButtonX();
            this.btnPrev = new DevComponents.DotNetBar.ButtonX();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.btnLast = new DevComponents.DotNetBar.ButtonX();
            this.tlDesplazamiento = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.panelDesplazamiento = new System.Windows.Forms.Panel();
            this.tlEdicion = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnDel = new DevComponents.DotNetBar.ButtonX();
            this.tlEditSearch = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.btnSelect = new DevComponents.DotNetBar.ButtonX();
            this.tlDesplazamiento.SuspendLayout();
            this.panelDesplazamiento.SuspendLayout();
            this.tlEdicion.SuspendLayout();
            this.tlEditSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCount.Location = new System.Drawing.Point(133, 3);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(50, 35);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "1 de 100";
            this.lblCount.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnFirst
            // 
            this.btnFirst.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFirst.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFirst.Image = global::kss_BachaQOS.Properties.Resources.webicons_34;
            this.btnFirst.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnFirst.Location = new System.Drawing.Point(3, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(59, 35);
            this.btnFirst.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Tag = "first";
            this.btnFirst.Click += new System.EventHandler(this.btnAccion_click);
            // 
            // btnPrev
            // 
            this.btnPrev.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrev.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnPrev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrev.Image = global::kss_BachaQOS.Properties.Resources.webicons_44;
            this.btnPrev.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnPrev.Location = new System.Drawing.Point(68, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(59, 35);
            this.btnPrev.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Tag = "prev";
            this.btnPrev.Click += new System.EventHandler(this.btnAccion_click);
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.Image = global::kss_BachaQOS.Properties.Resources.webicons_45;
            this.btnNext.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnNext.Location = new System.Drawing.Point(198, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(59, 35);
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.TabIndex = 1;
            this.btnNext.Tag = "next";
            this.btnNext.Click += new System.EventHandler(this.btnAccion_click);
            // 
            // btnLast
            // 
            this.btnLast.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLast.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnLast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLast.Image = global::kss_BachaQOS.Properties.Resources.webicons_42;
            this.btnLast.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnLast.Location = new System.Drawing.Point(263, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(61, 35);
            this.btnLast.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLast.TabIndex = 1;
            this.btnLast.Tag = "last";
            this.btnLast.Click += new System.EventHandler(this.btnAccion_click);
            // 
            // tlDesplazamiento
            // 
            this.tlDesplazamiento.ColumnCount = 5;
            this.tlDesplazamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlDesplazamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlDesplazamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlDesplazamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlDesplazamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlDesplazamiento.Controls.Add(this.lblCount, 2, 0);
            this.tlDesplazamiento.Controls.Add(this.btnFirst, 0, 0);
            this.tlDesplazamiento.Controls.Add(this.btnPrev, 1, 0);
            this.tlDesplazamiento.Controls.Add(this.btnNext, 3, 0);
            this.tlDesplazamiento.Controls.Add(this.btnLast, 4, 0);
            this.tlDesplazamiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlDesplazamiento.Location = new System.Drawing.Point(0, 0);
            this.tlDesplazamiento.Name = "tlDesplazamiento";
            this.tlDesplazamiento.RowCount = 1;
            this.tlDesplazamiento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlDesplazamiento.Size = new System.Drawing.Size(327, 41);
            this.tlDesplazamiento.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Image = global::kss_BachaQOS.Properties.Resources.webicons_207;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnCancel.Location = new System.Drawing.Point(166, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 37);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnAccion_click);
            // 
            // panelDesplazamiento
            // 
            this.panelDesplazamiento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDesplazamiento.Controls.Add(this.tlEdicion);
            this.panelDesplazamiento.Controls.Add(this.tlDesplazamiento);
            this.panelDesplazamiento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDesplazamiento.Location = new System.Drawing.Point(0, 399);
            this.panelDesplazamiento.Name = "panelDesplazamiento";
            this.panelDesplazamiento.Size = new System.Drawing.Size(327, 43);
            this.panelDesplazamiento.TabIndex = 9;
            // 
            // tlEdicion
            // 
            this.tlEdicion.ColumnCount = 2;
            this.tlEdicion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlEdicion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlEdicion.Controls.Add(this.btnCancel, 1, 0);
            this.tlEdicion.Controls.Add(this.btnSave, 0, 0);
            this.tlEdicion.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlEdicion.Location = new System.Drawing.Point(0, 41);
            this.tlEdicion.Name = "tlEdicion";
            this.tlEdicion.RowCount = 1;
            this.tlEdicion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlEdicion.Size = new System.Drawing.Size(327, 43);
            this.tlEdicion.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Image = global::kss_BachaQOS.Properties.Resources.webicons_160;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 37);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnAccion_click);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Image = global::kss_BachaQOS.Properties.Resources.btn_buscar;
            this.btnSearch.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnSearch.Location = new System.Drawing.Point(151, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 35);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Tag = "search";
            this.btnSearch.Click += new System.EventHandler(this.btnAccion_click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Image = global::kss_BachaQOS.Properties.Resources.btn_reporte;
            this.btnEdit.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnEdit.Location = new System.Drawing.Point(195, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(38, 35);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Tag = "edit";
            this.btnEdit.Click += new System.EventHandler(this.btnAccion_click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Image = global::kss_BachaQOS.Properties.Resources.btn_circ_plusa;
            this.btnAdd.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnAdd.Location = new System.Drawing.Point(239, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 35);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Tag = "add";
            this.btnAdd.Click += new System.EventHandler(this.btnAccion_click);
            // 
            // btnDel
            // 
            this.btnDel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDel.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDel.Image = global::kss_BachaQOS.Properties.Resources.btn_circ_minusr;
            this.btnDel.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnDel.Location = new System.Drawing.Point(283, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(41, 35);
            this.btnDel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDel.TabIndex = 0;
            this.btnDel.Tag = "delete";
            this.btnDel.Click += new System.EventHandler(this.btnAccion_click);
            // 
            // tlEditSearch
            // 
            this.tlEditSearch.ColumnCount = 5;
            this.tlEditSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tlEditSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tlEditSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tlEditSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tlEditSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tlEditSearch.Controls.Add(this.txtSearch, 0, 0);
            this.tlEditSearch.Controls.Add(this.btnSearch, 1, 0);
            this.tlEditSearch.Controls.Add(this.btnEdit, 2, 0);
            this.tlEditSearch.Controls.Add(this.btnAdd, 3, 0);
            this.tlEditSearch.Controls.Add(this.btnDel, 4, 0);
            this.tlEditSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlEditSearch.Location = new System.Drawing.Point(0, 0);
            this.tlEditSearch.Name = "tlEditSearch";
            this.tlEditSearch.RowCount = 1;
            this.tlEditSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEditSearch.Size = new System.Drawing.Size(327, 41);
            this.tlEditSearch.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.DisabledBackColor = System.Drawing.Color.White;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSearch.FocusHighlightEnabled = true;
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(3, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PreventEnterBeep = true;
            this.txtSearch.Size = new System.Drawing.Size(142, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.tlEditSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 41);
            this.panel1.TabIndex = 6;
            // 
            // panelDatos
            // 
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatos.Location = new System.Drawing.Point(0, 78);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(327, 321);
            this.panelDatos.TabIndex = 10;
            // 
            // btnSelect
            // 
            this.btnSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSelect.Image = global::kss_BachaQOS.Properties.Resources.btn_circ_oka;
            this.btnSelect.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnSelect.Location = new System.Drawing.Point(206, 1);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(116, 35);
            this.btnSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSelect.TabIndex = 14;
            this.btnSelect.Text = "<b>Seleccionar</b>";
            this.btnSelect.Visible = false;
            // 
            // frmPlantillaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 481);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDesplazamiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPlantillaDatos";
            this.Text = "frmPlantilla";
            this.Load += new System.EventHandler(this.frmPlantillaDatos_Load);
            this.Controls.SetChildIndex(this.panelDesplazamiento, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panelDatos, 0);
            this.Controls.SetChildIndex(this.btnSelect, 0);
            this.tlDesplazamiento.ResumeLayout(false);
            this.panelDesplazamiento.ResumeLayout(false);
            this.tlEdicion.ResumeLayout(false);
            this.tlEditSearch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.ButtonX btnFirst;
        private DevComponents.DotNetBar.ButtonX btnPrev;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private DevComponents.DotNetBar.ButtonX btnLast;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.Panel panelDesplazamiento;
        private System.Windows.Forms.TableLayoutPanel tlEdicion;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnDel;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        internal System.Windows.Forms.TableLayoutPanel tlDesplazamiento;
        internal System.Windows.Forms.TableLayoutPanel tlEditSearch;
        internal System.Windows.Forms.Panel panelDatos;
        private DevComponents.DotNetBar.ButtonX btnSelect;
    }
}