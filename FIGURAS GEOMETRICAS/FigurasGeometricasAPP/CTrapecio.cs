using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasAPP
{
    internal class CTrapecio
    {
        private float ladoDer, ladoIzq, baseMayor, baseMenor, altura;
        private float perimetro, area;

        public CTrapecio()
        {
            ladoDer = ladoIzq = baseMayor = baseMenor = altura = 0.0f;
            perimetro = area = 0.0f;
        }

        public void LeerDatos(TextBox txtLadoDer, TextBox txtLadoIzq, TextBox txtBaseMay, TextBox txtBaseMen, TextBox txtAltura)
        {
            try
            {
                ladoDer = float.Parse(txtLadoDer.Text);
                ladoIzq = float.Parse(txtLadoIzq.Text);
                baseMayor = float.Parse(txtBaseMay.Text);
                baseMenor = float.Parse(txtBaseMen.Text);
                altura = float.Parse(txtAltura.Text);

                if (ladoDer <= 0 || ladoIzq <= 0 || baseMayor <= 0 || baseMenor <= 0 || altura <= 0)
                {
                    MessageBox.Show("Todos los valores deben ser positivos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ladoDer = ladoIzq = baseMayor = baseMenor = altura = 0;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CalcularPerimetro()
        {
            perimetro = ladoDer + ladoIzq + baseMayor + baseMenor;
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

        public void InicializarDatos(TextBox txtLadoDer, TextBox txtLadoIzq, TextBox txtBaseMay, TextBox txtBaseMen, TextBox txtAltura, TextBox txtPerimetro, TextBox txtArea)
        {
            ladoDer = ladoIzq = baseMayor = baseMenor = altura = 0.0f;
            perimetro = area = 0.0f;

            txtLadoDer.Text = "";
            txtLadoIzq.Text = "";
            txtBaseMay.Text = "";
            txtBaseMen.Text = "";
            txtAltura.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            txtLadoDer.Focus();
        }

        public void CerrarFormulario(Form formulario)
        {
            formulario.Close();
        }
    }
}
