using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasAPP
{
    internal class COvalo
    {
        private float ancho, alto;
        private float perimetro, area;

        public COvalo()
        {
            ancho = alto = 0.0f;
            perimetro = area = 0.0f;
        }

        public void LeerDatos(TextBox txtAncho, TextBox txtAlto)
        {
            try
            {
                ancho = float.Parse(txtAncho.Text);
                alto = float.Parse(txtAlto.Text);

                if (ancho <= 0 || alto <= 0)
                {
                    MessageBox.Show("El ancho y alto deben ser mayores que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ancho = alto = 0;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CalcularArea()
        {
            area = (float)Math.PI * (ancho / 2) * (alto / 2);
        }

        public void CalcularPerimetro()
        {
            // Fórmula aproximada de Ramanujan
            double a = ancho;
            double b = alto;
            double h = Math.Pow((a - b), 2) / Math.Pow((a + b), 2);
            perimetro = (float)(Math.PI * (a + b) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h))));
        }

        public void MostrarDatos(TextBox txtPerimetro, TextBox txtArea)
        {
            if (area > 0 && perimetro > 0)
            {
                txtPerimetro.Text = perimetro.ToString("0.00");
                txtArea.Text = area.ToString("0.00");
            }
            else
            {
                txtPerimetro.Text = "";
                txtArea.Text = "";
            }
        }

        public void InicializarDatos(TextBox txtAncho, TextBox txtAlto, TextBox txtPerimetro, TextBox txtArea)
        {
            ancho = alto = 0.0f;
            perimetro = area = 0.0f;

            txtAncho.Text = "";
            txtAlto.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            txtAncho.Focus();
        }

        public void CerrarFormulario(Form formulario)
        {
            formulario.Close();
        }
    }
}
