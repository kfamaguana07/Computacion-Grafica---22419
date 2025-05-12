using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasAPP
{
    internal class CPentagono
    {
        private float radio;
        private float perimetro, area;

        public CPentagono()
        {
            radio = perimetro = area = 0.0f;
        }

        public void Leer(TextBox txtRadio)
        {
            try
            {
                radio = float.Parse(txtRadio.Text);
                if (radio <= 0)
                {
                    MessageBox.Show("El radio debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    radio = 0;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor numérico válido para el radio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CalcularPerimetro()
        {
            float lado = 2 * radio * (float)Math.Sin(Math.PI / 5); // sin(36°)
            perimetro = 5 * lado;
        }

        public void CalcularArea()
        {
            area = (5f / 2f) * radio * radio * (float)Math.Sin(2 * Math.PI / 5); // sin(72°)
        }

        public void Mostrar(TextBox txtPerimetro, TextBox txtArea)
        {
            if (radio > 0)
            {
                txtPerimetro.Text = perimetro.ToString("0.00");
                txtArea.Text = area.ToString("0.00");
            }
        }

        public void Inicializar(TextBox txtRadio, TextBox txtPerimetro, TextBox txtArea)
        {
            radio = perimetro = area = 0.0f;
            txtRadio.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtRadio.Focus();
        }

        public void Salir(Form formulario)
        {
            formulario.Close();
        }
    }
}
