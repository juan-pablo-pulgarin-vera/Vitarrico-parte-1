namespace Vitarrico
{
    partial class FrmVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendedor));
            this.pnlInicioVendedor = new System.Windows.Forms.Panel();
            this.menuStripPrincipalVende = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROVEEDORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDEDORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNameUserVende = new System.Windows.Forms.Label();
            this.menuStripPrincipalVende.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInicioVendedor
            // 
            this.pnlInicioVendedor.BackColor = System.Drawing.Color.Gray;
            this.pnlInicioVendedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlInicioVendedor.Location = new System.Drawing.Point(-4, 32);
            this.pnlInicioVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInicioVendedor.Name = "pnlInicioVendedor";
            this.pnlInicioVendedor.Size = new System.Drawing.Size(1189, 663);
            this.pnlInicioVendedor.TabIndex = 1;
            // 
            // menuStripPrincipalVende
            // 
            this.menuStripPrincipalVende.BackColor = System.Drawing.Color.Firebrick;
            this.menuStripPrincipalVende.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuStripPrincipalVende.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPrincipalVende.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem,
            this.uSUARIOSToolStripMenuItem,
            this.pROVEEDORESToolStripMenuItem,
            this.vENDEDORESToolStripMenuItem});
            this.menuStripPrincipalVende.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipalVende.Name = "menuStripPrincipalVende";
            this.menuStripPrincipalVende.Size = new System.Drawing.Size(1179, 28);
            this.menuStripPrincipalVende.TabIndex = 2;
            this.menuStripPrincipalVende.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.uSUARIOSToolStripMenuItem.Text = "PEDIDOS";
            // 
            // pROVEEDORESToolStripMenuItem
            // 
            this.pROVEEDORESToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pROVEEDORESToolStripMenuItem.Name = "pROVEEDORESToolStripMenuItem";
            this.pROVEEDORESToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.pROVEEDORESToolStripMenuItem.Text = "REGISTRO CLIENTES";
            // 
            // vENDEDORESToolStripMenuItem
            // 
            this.vENDEDORESToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.vENDEDORESToolStripMenuItem.Name = "vENDEDORESToolStripMenuItem";
            this.vENDEDORESToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.vENDEDORESToolStripMenuItem.Text = "INFORMACIÓN ADICIONAL";
            // 
            // lblNameUserVende
            // 
            this.lblNameUserVende.AutoSize = true;
            this.lblNameUserVende.BackColor = System.Drawing.Color.Firebrick;
            this.lblNameUserVende.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblNameUserVende.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNameUserVende.Location = new System.Drawing.Point(939, 0);
            this.lblNameUserVende.Name = "lblNameUserVende";
            this.lblNameUserVende.Size = new System.Drawing.Size(0, 22);
            this.lblNameUserVende.TabIndex = 5;
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.lblNameUserVende);
            this.Controls.Add(this.menuStripPrincipalVende);
            this.Controls.Add(this.pnlInicioVendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStripPrincipalVende.ResumeLayout(false);
            this.menuStripPrincipalVende.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInicioVendedor;
        private System.Windows.Forms.MenuStrip menuStripPrincipalVende;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROVEEDORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENDEDORESToolStripMenuItem;
        private System.Windows.Forms.Label lblNameUserVende;
    }
}