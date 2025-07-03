namespace CohenSutherlandAPP
{
    partial class FrmCohenSutherland
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRecortar = new System.Windows.Forms.Button();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.lblY2 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.lblX2 = new System.Windows.Forms.Label();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.lblY1 = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lblX1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 30);
            this.label2.TabIndex = 38;
            this.label2.Text = "ALGORITMO COHENSUTERLAND";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(140, 452);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 32);
            this.btnLimpiar.TabIndex = 35;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRecortar
            // 
            this.btnRecortar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRecortar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecortar.Location = new System.Drawing.Point(26, 452);
            this.btnRecortar.Name = "btnRecortar";
            this.btnRecortar.Size = new System.Drawing.Size(108, 32);
            this.btnRecortar.TabIndex = 34;
            this.btnRecortar.Text = "Recortar";
            this.btnRecortar.UseVisualStyleBackColor = false;
            this.btnRecortar.Click += new System.EventHandler(this.btnRecortar_Click);
            // 
            // txtY2
            // 
            this.txtY2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtY2.Location = new System.Drawing.Point(108, 376);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 22);
            this.txtY2.TabIndex = 33;
            // 
            // lblY2
            // 
            this.lblY2.AutoSize = true;
            this.lblY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY2.Location = new System.Drawing.Point(76, 376);
            this.lblY2.Name = "lblY2";
            this.lblY2.Size = new System.Drawing.Size(36, 20);
            this.lblY2.TabIndex = 32;
            this.lblY2.Text = "Y2:";
            // 
            // txtX2
            // 
            this.txtX2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtX2.Location = new System.Drawing.Point(108, 304);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 22);
            this.txtX2.TabIndex = 31;
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX2.Location = new System.Drawing.Point(75, 304);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(37, 20);
            this.lblX2.TabIndex = 30;
            this.lblX2.Text = "X2:";
            // 
            // txtY1
            // 
            this.txtY1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtY1.Location = new System.Drawing.Point(108, 237);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(100, 22);
            this.txtY1.TabIndex = 29;
            // 
            // lblY1
            // 
            this.lblY1.AutoSize = true;
            this.lblY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY1.Location = new System.Drawing.Point(72, 237);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(36, 20);
            this.lblY1.TabIndex = 28;
            this.lblY1.Text = "Y1:";
            // 
            // txtX1
            // 
            this.txtX1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtX1.Location = new System.Drawing.Point(108, 172);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(100, 22);
            this.txtX1.TabIndex = 27;
            // 
            // picCanvas
            // 
            this.picCanvas.AccessibleName = "";
            this.picCanvas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.picCanvas.Location = new System.Drawing.Point(266, 127);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(629, 435);
            this.picCanvas.TabIndex = 26;
            this.picCanvas.TabStop = false;
            this.picCanvas.Tag = "";
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX1.Location = new System.Drawing.Point(71, 172);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(37, 20);
            this.lblX1.TabIndex = 25;
            this.lblX1.Text = "X1:";
            // 
            // FrmCohenSutherland
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRecortar);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.lblY2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.lblY1);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.lblX1);
            this.Name = "FrmCohenSutherland";
            this.Text = "FrmCohenSutherland";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRecortar;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Label lblY2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Label lblY1;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblX1;
    }
}