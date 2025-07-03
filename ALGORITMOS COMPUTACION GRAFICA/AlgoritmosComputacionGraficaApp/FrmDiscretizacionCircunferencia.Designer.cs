namespace AlgoritmosGraficosApp
{
    partial class FrmDiscretizacionCircunferencia
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPuntos = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtCentroY = new System.Windows.Forms.TextBox();
            this.lblCentroY = new System.Windows.Forms.Label();
            this.txtCentroX = new System.Windows.Forms.TextBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lblCentroX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(560, 30);
            this.label2.TabIndex = 52;
            this.label2.Text = "DISCRETIZACIÓN DE CIRCUNFERENCIAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(929, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Lista Pixeles Encendidos";
            // 
            // txtPuntos
            // 
            this.txtPuntos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntos.FormattingEnabled = true;
            this.txtPuntos.ItemHeight = 16;
            this.txtPuntos.Location = new System.Drawing.Point(922, 199);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(267, 276);
            this.txtPuntos.TabIndex = 50;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(127, 384);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 32);
            this.btnLimpiar.TabIndex = 49;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(13, 384);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 32);
            this.btnCalcular.TabIndex = 48;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtRadio
            // 
            this.txtRadio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRadio.Location = new System.Drawing.Point(117, 306);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 22);
            this.txtRadio.TabIndex = 45;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadio.Location = new System.Drawing.Point(24, 306);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(63, 20);
            this.lblRadio.TabIndex = 44;
            this.lblRadio.Text = "Radio:";
            // 
            // txtCentroY
            // 
            this.txtCentroY.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCentroY.Location = new System.Drawing.Point(117, 239);
            this.txtCentroY.Name = "txtCentroY";
            this.txtCentroY.Size = new System.Drawing.Size(100, 22);
            this.txtCentroY.TabIndex = 43;
            // 
            // lblCentroY
            // 
            this.lblCentroY.AutoSize = true;
            this.lblCentroY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentroY.Location = new System.Drawing.Point(21, 239);
            this.lblCentroY.Name = "lblCentroY";
            this.lblCentroY.Size = new System.Drawing.Size(88, 20);
            this.lblCentroY.TabIndex = 42;
            this.lblCentroY.Text = "Centro Y:";
            // 
            // txtCentroX
            // 
            this.txtCentroX.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCentroX.Location = new System.Drawing.Point(117, 174);
            this.txtCentroX.Name = "txtCentroX";
            this.txtCentroX.Size = new System.Drawing.Size(100, 22);
            this.txtCentroX.TabIndex = 41;
            // 
            // picCanvas
            // 
            this.picCanvas.AccessibleName = "";
            this.picCanvas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.picCanvas.Location = new System.Drawing.Point(254, 100);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(629, 435);
            this.picCanvas.TabIndex = 40;
            this.picCanvas.TabStop = false;
            this.picCanvas.Tag = "";
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            // 
            // lblCentroX
            // 
            this.lblCentroX.AutoSize = true;
            this.lblCentroX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentroX.Location = new System.Drawing.Point(20, 174);
            this.lblCentroX.Name = "lblCentroX";
            this.lblCentroX.Size = new System.Drawing.Size(89, 20);
            this.lblCentroX.TabIndex = 39;
            this.lblCentroX.Text = "Centro X:";
            // 
            // FrmDiscretizacionCircunferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1218, 571);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.txtCentroY);
            this.Controls.Add(this.lblCentroY);
            this.Controls.Add(this.txtCentroX);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.lblCentroX);
            this.Name = "FrmDiscretizacionCircunferencia";
            this.Text = "FrmDiscretizacionCircunferencia";
            this.Load += new System.EventHandler(this.FrmDiscretizacionCircunferencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox txtPuntos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtCentroY;
        private System.Windows.Forms.Label lblCentroY;
        private System.Windows.Forms.TextBox txtCentroX;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblCentroX;
    }
}