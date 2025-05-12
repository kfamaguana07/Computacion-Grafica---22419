namespace FigurasGeometricasAPP
{
    partial class FrmTrapecio
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
            this.txtLadoDer = new System.Windows.Forms.TextBox();
            this.lblLadoDer = new System.Windows.Forms.Label();
            this.txtLadoIzq = new System.Windows.Forms.TextBox();
            this.lblLadoIzq = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtBaseMen = new System.Windows.Forms.TextBox();
            this.lblBaseMen = new System.Windows.Forms.Label();
            this.txtBaseMay = new System.Windows.Forms.TextBox();
            this.lblBaseMay = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
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
            this.lblTriangulo.Location = new System.Drawing.Point(306, 20);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(214, 36);
            this.lblTriangulo.TabIndex = 31;
            this.lblTriangulo.Text = "TRAPECIO";
            // 
            // grbSalidas
            // 
            this.grbSalidas.Controls.Add(this.txtArea);
            this.grbSalidas.Controls.Add(this.txtPerimetro);
            this.grbSalidas.Controls.Add(this.lblArea);
            this.grbSalidas.Controls.Add(this.lblPerimetro);
            this.grbSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSalidas.Location = new System.Drawing.Point(209, 430);
            this.grbSalidas.Margin = new System.Windows.Forms.Padding(4);
            this.grbSalidas.Name = "grbSalidas";
            this.grbSalidas.Padding = new System.Windows.Forms.Padding(4);
            this.grbSalidas.Size = new System.Drawing.Size(376, 181);
            this.grbSalidas.TabIndex = 30;
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
            this.grbProceso.Location = new System.Drawing.Point(209, 327);
            this.grbProceso.Margin = new System.Windows.Forms.Padding(4);
            this.grbProceso.Name = "grbProceso";
            this.grbProceso.Padding = new System.Windows.Forms.Padding(4);
            this.grbProceso.Size = new System.Drawing.Size(379, 95);
            this.grbProceso.TabIndex = 29;
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
            this.grbEntrada.Controls.Add(this.txtAltura);
            this.grbEntrada.Controls.Add(this.lblAltura);
            this.grbEntrada.Controls.Add(this.txtBaseMen);
            this.grbEntrada.Controls.Add(this.lblBaseMen);
            this.grbEntrada.Controls.Add(this.txtBaseMay);
            this.grbEntrada.Controls.Add(this.lblBaseMay);
            this.grbEntrada.Controls.Add(this.txtLadoDer);
            this.grbEntrada.Controls.Add(this.lblLadoDer);
            this.grbEntrada.Controls.Add(this.txtLadoIzq);
            this.grbEntrada.Controls.Add(this.lblLadoIzq);
            this.grbEntrada.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEntrada.Location = new System.Drawing.Point(209, 69);
            this.grbEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.grbEntrada.Name = "grbEntrada";
            this.grbEntrada.Padding = new System.Windows.Forms.Padding(4);
            this.grbEntrada.Size = new System.Drawing.Size(375, 250);
            this.grbEntrada.TabIndex = 28;
            this.grbEntrada.TabStop = false;
            this.grbEntrada.Text = "Entrada";
            // 
            // txtLadoDer
            // 
            this.txtLadoDer.Location = new System.Drawing.Point(180, 72);
            this.txtLadoDer.Margin = new System.Windows.Forms.Padding(4);
            this.txtLadoDer.Name = "txtLadoDer";
            this.txtLadoDer.Size = new System.Drawing.Size(132, 28);
            this.txtLadoDer.TabIndex = 4;
            // 
            // lblLadoDer
            // 
            this.lblLadoDer.AutoSize = true;
            this.lblLadoDer.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoDer.Location = new System.Drawing.Point(21, 75);
            this.lblLadoDer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLadoDer.Name = "lblLadoDer";
            this.lblLadoDer.Size = new System.Drawing.Size(134, 22);
            this.lblLadoDer.TabIndex = 3;
            this.lblLadoDer.Text = "Lado Derecho:";
            // 
            // txtLadoIzq
            // 
            this.txtLadoIzq.Location = new System.Drawing.Point(180, 27);
            this.txtLadoIzq.Margin = new System.Windows.Forms.Padding(4);
            this.txtLadoIzq.Name = "txtLadoIzq";
            this.txtLadoIzq.Size = new System.Drawing.Size(132, 28);
            this.txtLadoIzq.TabIndex = 2;
            // 
            // lblLadoIzq
            // 
            this.lblLadoIzq.AutoSize = true;
            this.lblLadoIzq.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoIzq.Location = new System.Drawing.Point(21, 30);
            this.lblLadoIzq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLadoIzq.Name = "lblLadoIzq";
            this.lblLadoIzq.Size = new System.Drawing.Size(146, 22);
            this.lblLadoIzq.TabIndex = 0;
            this.lblLadoIzq.Text = "Lado Izquierdo:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(489, 349);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 36);
            this.button3.TabIndex = 27;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtBaseMen
            // 
            this.txtBaseMen.Location = new System.Drawing.Point(180, 158);
            this.txtBaseMen.Margin = new System.Windows.Forms.Padding(4);
            this.txtBaseMen.Name = "txtBaseMen";
            this.txtBaseMen.Size = new System.Drawing.Size(132, 28);
            this.txtBaseMen.TabIndex = 8;
            // 
            // lblBaseMen
            // 
            this.lblBaseMen.AutoSize = true;
            this.lblBaseMen.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMen.Location = new System.Drawing.Point(21, 161);
            this.lblBaseMen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseMen.Name = "lblBaseMen";
            this.lblBaseMen.Size = new System.Drawing.Size(117, 22);
            this.lblBaseMen.TabIndex = 7;
            this.lblBaseMen.Text = "Base Menor:";
            // 
            // txtBaseMay
            // 
            this.txtBaseMay.Location = new System.Drawing.Point(180, 113);
            this.txtBaseMay.Margin = new System.Windows.Forms.Padding(4);
            this.txtBaseMay.Name = "txtBaseMay";
            this.txtBaseMay.Size = new System.Drawing.Size(132, 28);
            this.txtBaseMay.TabIndex = 6;
            // 
            // lblBaseMay
            // 
            this.lblBaseMay.AutoSize = true;
            this.lblBaseMay.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMay.Location = new System.Drawing.Point(21, 121);
            this.lblBaseMay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseMay.Name = "lblBaseMay";
            this.lblBaseMay.Size = new System.Drawing.Size(116, 22);
            this.lblBaseMay.TabIndex = 5;
            this.lblBaseMay.Text = "Base Mayor:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(180, 203);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(132, 28);
            this.txtAltura.TabIndex = 10;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(21, 206);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(70, 22);
            this.lblAltura.TabIndex = 9;
            this.lblAltura.Text = "Altura:";
            // 
            // FrmTrapecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.lblTriangulo);
            this.Controls.Add(this.grbSalidas);
            this.Controls.Add(this.grbProceso);
            this.Controls.Add(this.grbEntrada);
            this.Controls.Add(this.button3);
            this.Name = "FrmTrapecio";
            this.Text = "FrmTrapecio";
            this.Load += new System.EventHandler(this.FrmTrapecio_Load);
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
        private System.Windows.Forms.TextBox txtLadoDer;
        private System.Windows.Forms.Label lblLadoDer;
        private System.Windows.Forms.TextBox txtLadoIzq;
        private System.Windows.Forms.Label lblLadoIzq;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtBaseMen;
        private System.Windows.Forms.Label lblBaseMen;
        private System.Windows.Forms.TextBox txtBaseMay;
        private System.Windows.Forms.Label lblBaseMay;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
    }
}