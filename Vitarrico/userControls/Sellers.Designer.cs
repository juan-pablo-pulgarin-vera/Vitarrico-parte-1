namespace Vitarrico
{
    partial class Sellers
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
            this.menuStripSellers = new System.Windows.Forms.MenuStrip();
            this.uSERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSellers.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripSellers
            // 
            this.menuStripSellers.BackColor = System.Drawing.Color.Firebrick;
            this.menuStripSellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuStripSellers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripSellers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSERSToolStripMenuItem,
            this.pRIToolStripMenuItem});
            this.menuStripSellers.Location = new System.Drawing.Point(0, 0);
            this.menuStripSellers.Name = "menuStripSellers";
            this.menuStripSellers.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripSellers.Size = new System.Drawing.Size(215, 24);
            this.menuStripSellers.TabIndex = 1;
            this.menuStripSellers.Text = "menuStrip1";
            // 
            // uSERSToolStripMenuItem
            // 
            this.uSERSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uSERSToolStripMenuItem.Name = "uSERSToolStripMenuItem";
            this.uSERSToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.uSERSToolStripMenuItem.Text = "ORDERS";
            // 
            // pRIToolStripMenuItem
            // 
            this.pRIToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pRIToolStripMenuItem.Name = "pRIToolStripMenuItem";
            this.pRIToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.pRIToolStripMenuItem.Text = "CUSTOMERS";
            // 
            // Sellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStripSellers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Sellers";
            this.Size = new System.Drawing.Size(215, 23);
            this.menuStripSellers.ResumeLayout(false);
            this.menuStripSellers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripSellers;
        private System.Windows.Forms.ToolStripMenuItem uSERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRIToolStripMenuItem;
    }
}
