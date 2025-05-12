using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasAPP
{
    internal class CDeltoide
    {
        private float lado1, lado2, angulo;
        private float perimetro, area;

        public CDeltoide()
        {
            lado1 = lado2 = angulo = 0.0f;
            perimetro = area = 0.0f;
        }

        public void LeerDatos(TextBox txtLado1, TextBox txtLado2, TextBox txtAngulo)
        {
            try
            {
                lado1 = float.Parse(txtLado1.Text);
                lado2 = float.Parse(txtLado2.Text);
                angulo = float.Parse(txtAngulo.Text);

                if (lado1 <= 0 || lado2 <= 0 || angulo <= 0 || angulo >= 180)
                {
                    MessageBox.Show("Los valores deben ser mayores que cero y el ángulo debe estar entre 0 y 180 grados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lado1 = lado2 = angulo = 0;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CalcularArea()
        {
            // Convertir el ángulo de grados a radianes
            double anguloRad = angulo * (Math.PI / 180);
            area = (float)(0.5 * lado1 * lado2 * Math.Sin(anguloRad));
        }

        public void CalcularPerimetro()
        {
            perimetro = 2 * (lado1 + lado2);
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

        public void InicializarDatos(TextBox txtLado1, TextBox txtLado2, TextBox txtAngulo, TextBox txtPerimetro, TextBox txtArea)
        {
            lado1 = lado2 = angulo = 0.0f;
            perimetro = area = 0.0f;

            txtLado1.Text = "";
            txtLado2.Text = "";
            txtAngulo.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            txtLado1.Focus();
        }

        public void CerrarFormulario(Form formulario)
        {
            formulario.Close();
        }
    }
}
