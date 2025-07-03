namespace AlgoritmosComputacionGraficaApp
{
    partial class FrmBresenhamElipses
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
            this.txtRadioX = new System.Windows.Forms.TextBox();
            this.lblRadioX = new System.Windows.Forms.Label();
            this.txtCentroY = new System.Windows.Forms.TextBox();
            this.lblCentroY = new System.Windows.Forms.Label();
            this.txtCentroX = new System.Windows.Forms.TextBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lblCentroX = new System.Windows.Forms.Label();
            this.txtRadioY = new System.Windows.Forms.TextBox();
            this.lblRadioY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 30);
            this.label2.TabIndex = 64;
            this.label2.Text = "BRESENHAM ELIPSES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(937, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Lista Pixeles Encendidos";
            // 
            // txtPuntos
            // 
            this.txtPuntos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntos.FormattingEnabled = true;
            this.txtPuntos.ItemHeight = 16;
            this.txtPuntos.Location = new System.Drawing.Point(930, 203);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(267, 276);
            this.txtPuntos.TabIndex = 62;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(136, 428);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 32);
            this.btnLimpiar.TabIndex = 61;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(22, 428);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 32);
            this.btnCalcular.TabIndex = 60;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtRadioX
            // 
            this.txtRadioX.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRadioX.Location = new System.Drawing.Point(125, 310);
            this.txtRadioX.Name = "txtRadioX";
            this.txtRadioX.Size = new System.Drawing.Size(100, 22);
            this.txtRadioX.TabIndex = 59;
            // 
            // lblRadioX
            // 
            this.lblRadioX.AutoSize = true;
            this.lblRadioX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadioX.Location = new System.Drawing.Point(32, 310);
            this.lblRadioX.Name = "lblRadioX";
            this.lblRadioX.Size = new System.Drawing.Size(78, 20);
            this.lblRadioX.TabIndex = 58;
            this.lblRadioX.Text = "Radio x:";
            // 
            // txtCentroY
            // 
            this.txtCentroY.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCentroY.Location = new System.Drawing.Point(125, 243);
            this.txtCentroY.Name = "txtCentroY";
            this.txtCentroY.Size = new System.Drawing.Size(100, 22);
            this.txtCentroY.TabIndex = 57;
            // 
            // lblCentroY
            // 
            this.lblCentroY.AutoSize = true;
            this.lblCentroY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentroY.Location = new System.Drawing.Point(29, 243);
            this.lblCentroY.Name = "lblCentroY";
            this.lblCentroY.Size = new System.Drawing.Size(88, 20);
            this.lblCentroY.TabIndex = 56;
            this.lblCentroY.Text = "Centro Y:";
            // 
            // txtCentroX
            // 
            this.txtCentroX.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCentroX.Location = new System.Drawing.Point(125, 178);
            this.txtCentroX.Name = "txtCentroX";
            this.txtCentroX.Size = new System.Drawing.Size(100, 22);
            this.txtCentroX.TabIndex = 55;
            // 
            // picCanvas
            // 
            this.picCanvas.AccessibleName = "";
            this.picCanvas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.picCanvas.Location = new System.Drawing.Point(262, 104);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(629, 435);
            this.picCanvas.TabIndex = 54;
            this.picCanvas.TabStop = false;
            this.picCanvas.Tag = "";
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            // 
            // lblCentroX
            // 
            this.lblCentroX.AutoSize = true;
            this.lblCentroX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentroX.Location = new System.Drawing.Point(28, 178);
            this.lblCentroX.Name = "lblCentroX";
            this.lblCentroX.Size = new System.Drawing.Size(89, 20);
            this.lblCentroX.TabIndex = 53;
            this.lblCentroX.Text = "Centro X:";
            // 
            // txtRadioY
            // 
            this.txtRadioY.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRadioY.Location = new System.Drawing.Point(125, 372);
            this.txtRadioY.Name = "txtRadioY";
            this.txtRadioY.Size = new System.Drawing.Size(100, 22);
            this.txtRadioY.TabIndex = 66;
            // 
            // lblRadioY
            // 
            this.lblRadioY.AutoSize = true;
            this.lblRadioY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadioY.Location = new System.Drawing.Point(32, 372);
            this.lblRadioY.Name = "lblRadioY";
            this.lblRadioY.Size = new System.Drawing.Size(80, 20);
            this.lblRadioY.TabIndex = 65;
            this.lblRadioY.Text = "Radio Y:";
            // 
            // FrmBresenhamElipses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 576);
            this.Controls.Add(this.txtRadioY);
            this.Controls.Add(this.lblRadioY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRadioX);
            this.Controls.Add(this.lblRadioX);
            this.Controls.Add(this.txtCentroY);
            this.Controls.Add(this.lblCentroY);
            this.Controls.Add(this.txtCentroX);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.lblCentroX);
            this.Name = "FrmBresenhamElipses";
            this.Text = "FrmBresenhamElipses";
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
        private System.Windows.Forms.TextBox txtRadioX;
        private System.Windows.Forms.Label lblRadioX;
        private System.Windows.Forms.TextBox txtCentroY;
        private System.Windows.Forms.Label lblCentroY;
        private System.Windows.Forms.TextBox txtCentroX;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblCentroX;
        private System.Windows.Forms.TextBox txtRadioY;
        private System.Windows.Forms.Label lblRadioY;
    }
}