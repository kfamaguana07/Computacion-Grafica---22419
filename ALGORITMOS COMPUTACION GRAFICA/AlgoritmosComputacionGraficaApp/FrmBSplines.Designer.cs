namespace AlgoritmosComputacionGraficaApp
{
    partial class FrmBSplines
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(566, 25);
            this.label5.TabIndex = 65;
            this.label5.Text = "Dibuje al menos 4 puntos para generar la curva B-Splines";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Click Der: Eliminar Punto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Click Izq: Agregar Punto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "INDICACIONES:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 30);
            this.label2.TabIndex = 61;
            this.label2.Text = "CURVAS DE B-SPLINES";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(57, 392);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 32);
            this.btnLimpiar.TabIndex = 60;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.AccessibleName = "";
            this.picCanvas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.picCanvas.Location = new System.Drawing.Point(267, 68);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(726, 464);
            this.picCanvas.TabIndex = 59;
            this.picCanvas.TabStop = false;
            this.picCanvas.Tag = "";
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            // 
            // FrmBSplines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 597);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmBSplines";
            this.Text = "FrmBSplines";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}