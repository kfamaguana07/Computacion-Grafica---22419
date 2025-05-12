using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasAPP
{
    internal class CRombo
    {
        private float mLado;
        private float mAltura;
        private float mPerimetro;
        private float mArea;

        public CRombo()
        {
            mLado = 0.0f;
            mAltura = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
        }

        public void LeerDatos(TextBox txtLado, TextBox txtAltura)
        {
            if (string.IsNullOrWhiteSpace(txtLado.Text) || string.IsNullOrWhiteSpace(txtAltura.Text))
            {
                MessageBox.Show("Ingrese valores para el lado y la altura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                mLado = float.Parse(txtLado.Text);
                mAltura = float.Parse(txtAltura.Text);

                if (mLado <= 0 || mAltura <= 0)
                {
                    MessageBox.Show("El lado y la altura deben ser positivos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mLado = 0;
                    mAltura = 0;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mLado = 0;
                mAltura = 0;
            }
        }

        public void CalcularArea()
        {
            mArea = mLado * mAltura;
        }

        public void CalcularPerimetro()
        {
            mPerimetro = 4 * mLado;
        }

        public void MostrarDatos(TextBox txtPerimetro, TextBox txtArea)
        {
            if (mLado > 0 && mAltura > 0)
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

        public void InicializarDatos(TextBox txtLado, TextBox txtAltura, TextBox txtPerimetro, TextBox txtArea)
        {
            mLado = 0.0f;
            mAltura = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
            txtLado.Text = "";
            txtAltura.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtLado.Focus();
        }

        public void CerrarFormulario(Form form)
        {
            form.Close();
        }
    }
}
