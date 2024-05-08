using kss_BigPOS.Design.Ctrls.POS;
using System;
using System.Windows.Forms;

namespace Kss_SocialCLubTest.kss_BigPOS.Design
{
    partial class frmEntity
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
            this.ctrlPOSDlgDatosUsuarios1 = new ctrlPOSDlgDatosUsuarios();
            this.worldUnidadesMedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.worldUnidadesMedidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlPOSDlgDatosUsuarios1
            // 
            this.ctrlPOSDlgDatosUsuarios1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrlPOSDlgDatosUsuarios1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPOSDlgDatosUsuarios1.EntidadActual = null;
            this.ctrlPOSDlgDatosUsuarios1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPOSDlgDatosUsuarios1.MinimumSize = new System.Drawing.Size(480, 160);
            this.ctrlPOSDlgDatosUsuarios1.Name = "ctrlPOSDlgDatosUsuarios1";
            this.ctrlPOSDlgDatosUsuarios1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.ctrlPOSDlgDatosUsuarios1.Size = new System.Drawing.Size(613, 373);
            this.ctrlPOSDlgDatosUsuarios1.TabIndex = 0;
            this.ctrlPOSDlgDatosUsuarios1.Titulo = "Registrar Guardar Documento de Caja.";
            // 
            // worldUnidadesMedidaBindingSource
            // 
            this.worldUnidadesMedidaBindingSource.DataSource = typeof(kss_DataObjects.Entities.World_UnidadesMedida);
            // 
            // frmEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 373);
            this.Controls.Add(this.ctrlPOSDlgDatosUsuarios1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEntity";
            this.Text = "frmEntity";
            ((System.ComponentModel.ISupportInitialize)(this.worldUnidadesMedidaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPOSDlgDatosUsuarios ctrlPOSDlgDatosUsuarios1;
        private BindingSource worldUnidadesMedidaBindingSource;
    }
}