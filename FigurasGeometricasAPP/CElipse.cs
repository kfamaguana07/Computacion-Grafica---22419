using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasAPP
{
    internal class CElipse
    {
        private float ejeMayor, ejeMenor;
        private float perimetro, area;

        public CElipse()
        {
            ejeMayor = ejeMenor = 0.0f;
            perimetro = area = 0.0f;
        }

        public void LeerDatos(TextBox txtEjeMay, TextBox txtEjeMen)
        {
            try
            {
                ejeMayor = float.Parse(txtEjeMay.Text);
                ejeMenor = float.Parse(txtEjeMen.Text);

                if (ejeMayor <= 0 || ejeMenor <= 0)
                {
                    MessageBox.Show("Los ejes deben ser mayores que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ejeMayor = ejeMenor = 0;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CalcularArea()
        {
            area = (float)Math.PI * ejeMayor * ejeMenor;
        }

        public void CalcularPerimetro()
        {
            // Fórmula aproximada de Ramanujan
            double a = ejeMayor;
            double b = ejeMenor;
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

        public void InicializarDatos(TextBox txtEjeMay, TextBox txtEjeMen, TextBox txtPerimetro, TextBox txtArea)
        {
            ejeMayor = ejeMenor = 0.0f;
            perimetro = area = 0.0f;

            txtEjeMay.Text = "";
            txtEjeMen.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            txtEjeMay.Focus();
        }

        public void CerrarFormulario(Form formulario)
        {
            formulario.Close();
        }
    }
}
