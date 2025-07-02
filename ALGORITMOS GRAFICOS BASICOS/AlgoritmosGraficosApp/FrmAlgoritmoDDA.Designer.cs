namespace AlgoritmosGraficosApp
{
    partial class FrmAlgoritmoDDA
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtYf = new System.Windows.Forms.TextBox();
            this.lblYf = new System.Windows.Forms.Label();
            this.txtXf = new System.Windows.Forms.TextBox();
            this.lblXf = new System.Windows.Forms.Label();
            this.txtYo = new System.Windows.Forms.TextBox();
            this.lblYo = new System.Windows.Forms.Label();
            this.txtXo = new System.Windows.Forms.TextBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lblXo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtPuntos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(14, 418);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 32);
            this.btnCalcular.TabIndex = 20;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtYf
            // 
            this.txtYf.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtYf.Location = new System.Drawing.Point(96, 342);
            this.txtYf.Name = "txtYf";
            this.txtYf.Size = new System.Drawing.Size(100, 22);
            this.txtYf.TabIndex = 19;
            // 
            // lblYf
            // 
            this.lblYf.AutoSize = true;
            this.lblYf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYf.Location = new System.Drawing.Point(64, 342);
            this.lblYf.Name = "lblYf";
            this.lblYf.Size = new System.Drawing.Size(32, 20);
            this.lblYf.TabIndex = 18;
            this.lblYf.Text = "Yf:";
            // 
            // txtXf
            // 
            this.txtXf.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtXf.Location = new System.Drawing.Point(96, 270);
            this.txtXf.Name = "txtXf";
            this.txtXf.Size = new System.Drawing.Size(100, 22);
            this.txtXf.TabIndex = 17;
            // 
            // lblXf
            // 
            this.lblXf.AutoSize = true;
            this.lblXf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXf.Location = new System.Drawing.Point(63, 270);
            this.lblXf.Name = "lblXf";
            this.lblXf.Size = new System.Drawing.Size(33, 20);
            this.lblXf.TabIndex = 16;
            this.lblXf.Text = "Xf:";
            // 
            // txtYo
            // 
            this.txtYo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtYo.Location = new System.Drawing.Point(96, 203);
            this.txtYo.Name = "txtYo";
            this.txtYo.Size = new System.Drawing.Size(100, 22);
            this.txtYo.TabIndex = 15;
            // 
            // lblYo
            // 
            this.lblYo.AutoSize = true;
            this.lblYo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYo.Location = new System.Drawing.Point(60, 203);
            this.lblYo.Name = "lblYo";
            this.lblYo.Size = new System.Drawing.Size(36, 20);
            this.lblYo.TabIndex = 14;
            this.lblYo.Text = "Yo:";
            // 
            // txtXo
            // 
            this.txtXo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtXo.Location = new System.Drawing.Point(96, 138);
            this.txtXo.Name = "txtXo";
            this.txtXo.Size = new System.Drawing.Size(100, 22);
            this.txtXo.TabIndex = 13;
            // 
            // picCanvas
            // 
            this.picCanvas.AccessibleName = "";
            this.picCanvas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.picCanvas.Location = new System.Drawing.Point(254, 93);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(629, 435);
            this.picCanvas.TabIndex = 12;
            this.picCanvas.TabStop = false;
            this.picCanvas.Tag = "";
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvasPaint);
            // 
            // lblXo
            // 
            this.lblXo.AutoSize = true;
            this.lblXo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXo.Location = new System.Drawing.Point(59, 138);
            this.lblXo.Name = "lblXo";
            this.lblXo.Size = new System.Drawing.Size(37, 20);
            this.lblXo.TabIndex = 11;
            this.lblXo.Text = "Xo:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(128, 418);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 32);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtPuntos
            // 
            this.txtPuntos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntos.FormattingEnabled = true;
            this.txtPuntos.ItemHeight = 16;
            this.txtPuntos.Location = new System.Drawing.Point(922, 192);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(267, 276);
            this.txtPuntos.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(929, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Lista Pixeles Encendidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "ALGORITMO DDA";
            // 
            // FrmAlgoritmoDDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1221, 564);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtYf);
            this.Controls.Add(this.lblYf);
            this.Controls.Add(this.txtXf);
            this.Controls.Add(this.lblXf);
            this.Controls.Add(this.txtYo);
            this.Controls.Add(this.lblYo);
            this.Controls.Add(this.txtXo);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.lblXo);
            this.Name = "FrmAlgoritmoDDA";
            this.Text = "FrmAlgoritmoDDA";
            this.Load += new System.EventHandler(this.FrmAlgoritmoDDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtYf;
        private System.Windows.Forms.Label lblYf;
        private System.Windows.Forms.TextBox txtXf;
        private System.Windows.Forms.Label lblXf;
        private System.Windows.Forms.TextBox txtYo;
        private System.Windows.Forms.Label lblYo;
        private System.Windows.Forms.TextBox txtXo;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblXo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox txtPuntos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}