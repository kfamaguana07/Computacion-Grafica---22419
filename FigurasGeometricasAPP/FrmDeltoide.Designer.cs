namespace FigurasGeometricasAPP
{
    partial class FrmDeltoide
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
            this.lblTriangulo = new System.Windows.Forms.Label();
            this.grbSalidas = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.grbProceso = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grbEntrada = new System.Windows.Forms.GroupBox();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.lblAngulo = new System.Windows.Forms.Label();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.grbSalidas.SuspendLayout();
            this.grbProceso.SuspendLayout();
            this.grbEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.Font = new System.Drawing.Font("ROG Fonts", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriangulo.ForeColor = System.Drawing.Color.Red;
            this.lblTriangulo.Location = new System.Drawing.Point(308, 23);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(208, 36);
            this.lblTriangulo.TabIndex = 36;
            this.lblTriangulo.Text = "DELTOIDE";
            // 
            // grbSalidas
            // 
            this.grbSalidas.Controls.Add(this.txtArea);
            this.grbSalidas.Controls.Add(this.txtPerimetro);
            this.grbSalidas.Controls.Add(this.lblArea);
            this.grbSalidas.Controls.Add(this.lblPerimetro);
            this.grbSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSalidas.Location = new System.Drawing.Point(204, 397);
            this.grbSalidas.Margin = new System.Windows.Forms.Padding(4);
            this.grbSalidas.Name = "grbSalidas";
            this.grbSalidas.Padding = new System.Windows.Forms.Padding(4);
            this.grbSalidas.Size = new System.Drawing.Size(376, 181);
            this.grbSalidas.TabIndex = 35;
            this.grbSalidas.TabStop = false;
            this.grbSalidas.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(167, 116);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(132, 27);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Enabled = false;
            this.txtPerimetro.Location = new System.Drawing.Point(167, 46);
            this.txtPerimetro.Margin = new System.Windows.Forms.Padding(4);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(132, 27);
            this.txtPerimetro.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(35, 116);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(44, 20);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(31, 46);
            this.lblPerimetro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(82, 20);
            this.lblPerimetro.TabIndex = 0;
            this.lblPerimetro.Text = "Perimetro";
            // 
            // grbProceso
            // 
            this.grbProceso.Controls.Add(this.btnSalir);
            this.grbProceso.Controls.Add(this.btnLimpiar);
            this.grbProceso.Controls.Add(this.btnCalcular);
            this.grbProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProceso.Location = new System.Drawing.Point(202, 274);
            this.grbProceso.Margin = new System.Windows.Forms.Padding(4);
            this.grbProceso.Name = "grbProceso";
            this.grbProceso.Padding = new System.Windows.Forms.Padding(4);
            this.grbProceso.Size = new System.Drawing.Size(379, 95);
            this.grbProceso.TabIndex = 34;
            this.grbProceso.TabStop = false;
            this.grbProceso.Text = "Proceso";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(267, 41);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(145, 41);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(25, 41);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grbEntrada
            // 
            this.grbEntrada.Controls.Add(this.txtAngulo);
            this.grbEntrada.Controls.Add(this.lblAngulo);
            this.grbEntrada.Controls.Add(this.txtLado2);
            this.grbEntrada.Controls.Add(this.lblLado2);
            this.grbEntrada.Controls.Add(this.txtLado1);
            this.grbEntrada.Controls.Add(this.lblLado1);
            this.grbEntrada.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEntrada.Location = new System.Drawing.Point(206, 78);
            this.grbEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.grbEntrada.Name = "grbEntrada";
            this.grbEntrada.Padding = new System.Windows.Forms.Padding(4);
            this.grbEntrada.Size = new System.Drawing.Size(375, 188);
            this.grbEntrada.TabIndex = 33;
            this.grbEntrada.TabStop = false;
            this.grbEntrada.Text = "Entrada";
            // 
            // txtAngulo
            // 
            this.txtAngulo.Location = new System.Drawing.Point(164, 143);
            this.txtAngulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(132, 28);
            this.txtAngulo.TabIndex = 6;
            // 
            // lblAngulo
            // 
            this.lblAngulo.AutoSize = true;
            this.lblAngulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngulo.Location = new System.Drawing.Point(20, 144);
            this.lblAngulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(78, 22);
            this.lblAngulo.TabIndex = 5;
            this.lblAngulo.Text = "Ángulo:";
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(164, 92);
            this.txtLado2.Margin = new System.Windows.Forms.Padding(4);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(132, 28);
            this.txtLado2.TabIndex = 4;
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado2.Location = new System.Drawing.Point(20, 93);
            this.lblLado2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(75, 22);
            this.lblLado2.TabIndex = 3;
            this.lblLado2.Text = "Lado 2:";
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(164, 43);
            this.txtLado1.Margin = new System.Windows.Forms.Padding(4);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(132, 28);
            this.txtLado1.TabIndex = 2;
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado1.Location = new System.Drawing.Point(20, 44);
            this.lblLado1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(75, 22);
            this.lblLado1.TabIndex = 0;
            this.lblLado1.Text = "Lado 1:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(482, 296);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 36);
            this.button3.TabIndex = 32;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmDeltoide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.lblTriangulo);
            this.Controls.Add(this.grbSalidas);
            this.Controls.Add(this.grbProceso);
            this.Controls.Add(this.grbEntrada);
            this.Controls.Add(this.button3);
            this.Name = "FrmDeltoide";
            this.Text = "FrmDeltoide";
            this.Load += new System.EventHandler(this.FrmDeltoide_Load);
            this.grbSalidas.ResumeLayout(false);
            this.grbSalidas.PerformLayout();
            this.grbProceso.ResumeLayout(false);
            this.grbEntrada.ResumeLayout(false);
            this.grbEntrada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTriangulo;
        private System.Windows.Forms.GroupBox grbSalidas;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.GroupBox grbProceso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grbEntrada;
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.Label lblAngulo;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Button button3;
    }
}