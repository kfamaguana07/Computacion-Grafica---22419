using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasAPP
{
    internal class CRomboide
    {
        private float baseR, altura;
        private float area, perimetro;

        public CRomboide()
        {
            baseR = altura = 0.0f;
            area = perimetro = 0.0f;
        }

        public void LeerDatos(TextBox txtBase, TextBox txtAltura)
        {
            try
            {
                baseR = float.Parse(txtBase.Text);
                altura = float.Parse(txtAltura.Text);

                if (baseR <= 0 || altura <= 0)
                {
                    MessageBox.Show("La base y altura deben ser mayores que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baseR = altura = 0;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CalcularArea()
        {
            area = baseR * altura;
        }

        public void CalcularPerimetro()
        {
            // Se asume que el lado opuesto a la base es igual a la base
            perimetro = 2 * (baseR + baseR);
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

        public void InicializarDatos(TextBox txtBase, TextBox txtAltura, TextBox txtPerimetro, TextBox txtArea)
        {
            baseR = altura = area = perimetro = 0.0f;

            txtBase.Text = "";
            txtAltura.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            txtBase.Focus();
        }

        public void CerrarFormulario(Form formulario)
        {
            formulario.Close();
        }
    }
}
