using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasAPP
{
    internal class COctagono
    {
        private float radio;
        private float perimetro, area;

        public COctagono()
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
            float lado = 2 * radio * (float)Math.Sin(Math.PI / 8);
            perimetro = 8 * lado;
        }

        public void CalcularArea()
        {
            area = 2 * (1 + (float)Math.Sqrt(2)) * radio * radio;
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
