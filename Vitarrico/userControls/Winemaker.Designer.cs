namespace Vitarrico
{
    partial class Winemaker
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
            this.menuStripWinemaker = new System.Windows.Forms.MenuStrip();
            this.uSERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripWinemaker.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripWinemaker
            // 
            this.menuStripWinemaker.BackColor = System.Drawing.Color.Firebrick;
            this.menuStripWinemaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuStripWinemaker.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripWinemaker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSERSToolStripMenuItem,
            this.pRIToolStripMenuItem});
            this.menuStripWinemaker.Location = new System.Drawing.Point(0, 0);
            this.menuStripWinemaker.Name = "menuStripWinemaker";
            this.menuStripWinemaker.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripWinemaker.Size = new System.Drawing.Size(246, 24);
            this.menuStripWinemaker.TabIndex = 1;
            this.menuStripWinemaker.Text = "menuStrip1";
            this.menuStripWinemaker.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripWinemaker_ItemClicked);
            // 
            // uSERSToolStripMenuItem
            // 
            this.uSERSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uSERSToolStripMenuItem.Name = "uSERSToolStripMenuItem";
            this.uSERSToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.uSERSToolStripMenuItem.Text = "PRODUCTS";
            // 
            // pRIToolStripMenuItem
            // 
            this.pRIToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pRIToolStripMenuItem.Name = "pRIToolStripMenuItem";
            this.pRIToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.pRIToolStripMenuItem.Text = "PROVIDERS";
            // 
            // Winemaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStripWinemaker);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Winemaker";
            this.Size = new System.Drawing.Size(246, 22);
            this.menuStripWinemaker.ResumeLayout(false);
            this.menuStripWinemaker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripWinemaker;
        private System.Windows.Forms.ToolStripMenuItem uSERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRIToolStripMenuItem;
    }
}
