namespace Vitarrico
{
    partial class Administrator
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripAdministrator = new System.Windows.Forms.MenuStrip();
            this.uSERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sELLERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAdministrator.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAdministrator
            // 
            this.menuStripAdministrator.BackColor = System.Drawing.Color.Firebrick;
            this.menuStripAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuStripAdministrator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAdministrator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSERSToolStripMenuItem,
            this.pRIToolStripMenuItem,
            this.sELLERSToolStripMenuItem});
            this.menuStripAdministrator.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdministrator.Name = "menuStripAdministrator";
            this.menuStripAdministrator.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripAdministrator.Size = new System.Drawing.Size(309, 24);
            this.menuStripAdministrator.TabIndex = 0;
            this.menuStripAdministrator.Text = "menuStrip1";
            // 
            // uSERSToolStripMenuItem
            // 
            this.uSERSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uSERSToolStripMenuItem.Name = "uSERSToolStripMenuItem";
            this.uSERSToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.uSERSToolStripMenuItem.Text = "USERS";
            // 
            // pRIToolStripMenuItem
            // 
            this.pRIToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pRIToolStripMenuItem.Name = "pRIToolStripMenuItem";
            this.pRIToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.pRIToolStripMenuItem.Text = "PROVIDERS";
            // 
            // sELLERSToolStripMenuItem
            // 
            this.sELLERSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sELLERSToolStripMenuItem.Name = "sELLERSToolStripMenuItem";
            this.sELLERSToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.sELLERSToolStripMenuItem.Text = "SELLERS";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStripAdministrator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Administrator";
            this.Size = new System.Drawing.Size(309, 22);
            this.menuStripAdministrator.ResumeLayout(false);
            this.menuStripAdministrator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAdministrator;
        private System.Windows.Forms.ToolStripMenuItem uSERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sELLERSToolStripMenuItem;
    }
}
