using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasAPP
{
    internal class CTrapezoide
    {
        private float lado1, lado2, lado3, lado4, altura;
        private float perimetro, area;

        public CTrapezoide()
        {
            lado1 = lado2 = lado3 = lado4 = altura = 0.0f;
            perimetro = area = 0.0f;
        }

        public void LeerDatos(TextBox txtLado1, TextBox txtLado2, TextBox txtLado3, TextBox txtLado4, TextBox txtAltura)
        {
            try
            {
                lado1 = float.Parse(txtLado1.Text);
                lado2 = float.Parse(txtLado2.Text);
                lado3 = float.Parse(txtLado3.Text);
                lado4 = float.Parse(txtLado4.Text);
                altura = float.Parse(txtAltura.Text);

                if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0 || lado4 <= 0 || altura <= 0)
                {
                    MessageBox.Show("Todos los valores deben ser positivos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lado1 = lado2 = lado3 = lado4 = altura = 0;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CalcularPerimetro()
        {
            perimetro = lado1 + lado2 + lado3 + lado4;
        }

        public void CalcularArea()
        {
            // Suposición: lado1 y lado3 son las bases paralelas
            area = ((lado1 + lado3) * altura) / 2;
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

        public void InicializarDatos(TextBox txtLado1, TextBox txtLado2, TextBox txtLado3, TextBox txtLado4, TextBox txtAltura, TextBox txtPerimetro, TextBox txtArea)
        {
            lado1 = lado2 = lado3 = lado4 = altura = 0.0f;
            perimetro = area = 0.0f;

            txtLado1.Text = "";
            txtLado2.Text = "";
            txtLado3.Text = "";
            txtLado4.Text = "";
            txtAltura.Text = "";
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
