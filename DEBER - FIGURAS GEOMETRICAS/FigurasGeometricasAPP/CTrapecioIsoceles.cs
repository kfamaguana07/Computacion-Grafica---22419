using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasAPP
{
    internal class CTrapecioIsoceles
    {
        private float baseMayor, baseMenor, altura;
        private float perimetro, area;

        public CTrapecioIsoceles()
        {
            baseMayor = baseMenor = altura = 0.0f;
            perimetro = area = 0.0f;
        }

        public void LeerDatos(TextBox txtBaseMay, TextBox txtBaseMen, TextBox txtAltura)
        {
            try
            {
                baseMayor = float.Parse(txtBaseMay.Text);
                baseMenor = float.Parse(txtBaseMen.Text);
                altura = float.Parse(txtAltura.Text);

                if (baseMayor <= 0 || baseMenor <= 0 || altura <= 0)
                {
                    MessageBox.Show("Todos los valores deben ser positivos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baseMayor = baseMenor = altura = 0;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CalcularPerimetro()
        {
            float diferencia = (baseMayor - baseMenor) / 2;
            float ladoIgual = (float)Math.Sqrt(diferencia * diferencia + altura * altura);
            perimetro = baseMayor + baseMenor + 2 * ladoIgual;
        }

        public void CalcularArea()
        {
            area = ((baseMayor + baseMenor) * altura) / 2;
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

        public void InicializarDatos(TextBox txtBaseMay, TextBox txtBaseMen, TextBox txtAltura, TextBox txtPerimetro, TextBox txtArea)
        {
            baseMayor = baseMenor = altura = 0.0f;
            perimetro = area = 0.0f;

            txtBaseMay.Text = "";
            txtBaseMen.Text = "";
            txtAltura.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            txtBaseMay.Focus();
        }

        public void CerrarFormulario(Form formulario)
        {
            formulario.Close();
        }
    }
}
