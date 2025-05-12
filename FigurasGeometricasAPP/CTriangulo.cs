using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasAPP
{
    internal class CTriangulo
    {
        private float mBase;
        private float mAltura;
        private float mPerimetro;
        private float mArea;
        private const float SF = 5;

        public CTriangulo()
        {
            mBase = 0.0f;
            mAltura = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
        }

        public void LeerDatos(TextBox txtBase, TextBox txtAltura)
        {
            if (string.IsNullOrWhiteSpace(txtBase.Text) || string.IsNullOrWhiteSpace(txtAltura.Text))
            {
                MessageBox.Show("Ingrese valores para la base y la altura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                mBase = float.Parse(txtBase.Text);
                mAltura = float.Parse(txtAltura.Text);

                if (mBase <= 0 || mAltura <= 0)
                {
                    MessageBox.Show("La base y la altura deben ser positivas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void CalcularArea()
        {
            mArea = (mBase * mAltura) / 2;
        }

        public void CalcularPerimetro()
        {
            float lado = (float)Math.Sqrt(Math.Pow(mBase / 2, 2) + Math.Pow(mAltura, 2));
            mPerimetro = mBase + 2 * lado;
        }

        public void MostrarDatos(TextBox txtPerimetro, TextBox txtArea)
        {
            if (mBase > 0 && mAltura > 0)
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

        public void InicializarDatos(TextBox txtBase, TextBox txtAltura, TextBox txtPerimetro, TextBox txtArea)
        {
            mBase = 0.0f;
            mAltura = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
            txtBase.Text = "";
            txtAltura.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtBase.Focus();
        }
        public void CerrarFormulario(Form form)
        {
            form.Close();
        }
    }
}
