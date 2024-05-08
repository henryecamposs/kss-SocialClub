namespace kss_SocialClub_Design.Dialogs
{
    partial class DialogOK_mskin
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
            this.btnOK = new MaterialSkin.Controls.MaterialFlatButton();
            this.pickssLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pickssLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.AutoSize = true;
            this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOK.Depth = 0;
            this.btnOK.Icon = null;
            this.btnOK.Location = new System.Drawing.Point(344, 263);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOK.Name = "btnOK";
            this.btnOK.Primary = false;
            this.btnOK.Size = new System.Drawing.Size(82, 36);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Aceptar";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // pickssLogo
            // 
            this.pickssLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pickssLogo.BackColor = System.Drawing.Color.Transparent;
            this.pickssLogo.Location = new System.Drawing.Point(5, 264);
            this.pickssLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pickssLogo.Name = "pickssLogo";
            this.pickssLogo.Size = new System.Drawing.Size(92, 36);
            this.pickssLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pickssLogo.TabIndex = 10;
            this.pickssLogo.TabStop = false;
            // 
            // DialogOK_mskin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 307);
            this.Controls.Add(this.pickssLogo);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogOK_mskin";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Dialogo";
            this.Shown += new System.EventHandler(this.DialogOK_mskin_Shown);
            this.Resize += new System.EventHandler(this.DialogOK_mskin_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pickssLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialFlatButton btnOK;
        private System.Windows.Forms.PictureBox pickssLogo;
    }
}