namespace AlgoritmosGraficosApp
{
    partial class FrmIndex
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aLGORITMOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineasRectasDDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineasRectasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circunferenciasBresenhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rellenoFigurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLGORITMOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aLGORITMOSToolStripMenuItem
            // 
            this.aLGORITMOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineasRectasDDAToolStripMenuItem,
            this.lineasRectasToolStripMenuItem,
            this.circunferenciasBresenhamToolStripMenuItem,
            this.rellenoFigurasToolStripMenuItem});
            this.aLGORITMOSToolStripMenuItem.Font = new System.Drawing.Font("Maiandra GD", 8F);
            this.aLGORITMOSToolStripMenuItem.Name = "aLGORITMOSToolStripMenuItem";
            this.aLGORITMOSToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.aLGORITMOSToolStripMenuItem.Text = "ALGORITMOS";
            // 
            // lineasRectasDDAToolStripMenuItem
            // 
            this.lineasRectasDDAToolStripMenuItem.Name = "lineasRectasDDAToolStripMenuItem";
            this.lineasRectasDDAToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.lineasRectasDDAToolStripMenuItem.Text = "Lineas Rectas - DDA";
            this.lineasRectasDDAToolStripMenuItem.Click += new System.EventHandler(this.lineasRectasDDAToolStripMenuItem_Click);
            // 
            // lineasRectasToolStripMenuItem
            // 
            this.lineasRectasToolStripMenuItem.Name = "lineasRectasToolStripMenuItem";
            this.lineasRectasToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.lineasRectasToolStripMenuItem.Text = "Lineas Rectas - Bresenham";
            this.lineasRectasToolStripMenuItem.Click += new System.EventHandler(this.lineasRectasToolStripMenuItem_Click);
            // 
            // circunferenciasBresenhamToolStripMenuItem
            // 
            this.circunferenciasBresenhamToolStripMenuItem.Name = "circunferenciasBresenhamToolStripMenuItem";
            this.circunferenciasBresenhamToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.circunferenciasBresenhamToolStripMenuItem.Text = "Circunferencias - Bresenham";
            this.circunferenciasBresenhamToolStripMenuItem.Click += new System.EventHandler(this.circunferenciasBresenhamToolStripMenuItem_Click);
            // 
            // rellenoFigurasToolStripMenuItem
            // 
            this.rellenoFigurasToolStripMenuItem.Name = "rellenoFigurasToolStripMenuItem";
            this.rellenoFigurasToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.rellenoFigurasToolStripMenuItem.Text = "Relleno Figuras";
            this.rellenoFigurasToolStripMenuItem.Click += new System.EventHandler(this.rellenoFigurasToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 86);
            this.label1.TabIndex = 1;
            this.label1.Text = "Implementación de Algoritmos \r\nGráficos Básicos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 20.21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kevin Amaguaña Casa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 20.21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 43);
            this.label3.TabIndex = 3;
            this.label3.Text = "COMPUTACIÓN GRAFICA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 539);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmIndex";
            this.Text = "FrmIndex";
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aLGORITMOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineasRectasDDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineasRectasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circunferenciasBresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rellenoFigurasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}