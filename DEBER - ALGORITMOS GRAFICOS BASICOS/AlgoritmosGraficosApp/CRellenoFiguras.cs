using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosGraficosApp
{
    internal class CRellenoFiguras
    {
        private float mLado;
        private float mAltura;
        private float mPerimetro;
        private float mArea;

        public CRellenoFiguras()
        {
            mLado = 0.0f;
            mAltura = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
        }

        public void LeerDatos(TextBox txtLado, TextBox txtAltura)
        {
            try
            {
                mLado = float.Parse(txtLado.Text);
                mAltura = float.Parse(txtAltura.Text);

                if (mLado <= 0 || mAltura <= 0)
                {
                    MessageBox.Show("Lado y altura deben ser positivos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mLado = 0;
                    mAltura = 0;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mLado = 0;
                mAltura = 0;
            }
        }

        public void CalcularPerimetro() => mPerimetro = 4 * mLado;

        public void CalcularArea() => mArea = mLado * mAltura;

        public void MostrarDatos(TextBox txtPerimetro, TextBox txtArea)
        {
            if (mLado > 0 && mAltura > 0)
            {
                txtPerimetro.Text = mPerimetro.ToString("0.00");
                txtArea.Text = mArea.ToString("0.00");
            }
            else
            {
                txtPerimetro.Text = "";
                txtArea.Text = "";
            }
        }

        public void InicializarDatos(TextBox txtLado, TextBox txtAltura, TextBox txtPerimetro, TextBox txtArea)
        {
            mLado = 0.0f;
            mAltura = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
            txtLado.Text = "";
            txtAltura.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtLado.Focus();
        }

        public void DibujarRombo(PictureBox picCanvas)
        {
            int ancho = picCanvas.Width;
            int alto = picCanvas.Height;

            Bitmap bmp = new Bitmap(ancho, alto);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            Pen lapiz = new Pen(Color.Black, 2);

            // Escalar para visibilidad
            float escala = 10.0f;
            int lado = (int)(mLado * escala);
            int altura = (int)(mAltura * escala);

            if (lado == 0 || altura == 0)
            {
                MessageBox.Show("No se puede dibujar con valores cero.");
                return;
            }

            int centroX = ancho / 2;
            int centroY = alto / 2;

            // Calcular puntos del rombo
            Point[] puntos = new Point[4];
            puntos[0] = new Point(centroX, centroY - altura / 2);     // arriba
            puntos[1] = new Point(centroX + lado / 2, centroY);       // derecha
            puntos[2] = new Point(centroX, centroY + altura / 2);     // abajo
            puntos[3] = new Point(centroX - lado / 2, centroY);       // izquierda

            g.DrawPolygon(lapiz, puntos);

            picCanvas.Image = bmp;
        }

        public void CerrarFormulario(Form form)
        {
            form.Close();
        }
    }
}
