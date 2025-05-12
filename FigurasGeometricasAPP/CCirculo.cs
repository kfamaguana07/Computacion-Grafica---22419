using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasAPP
{
    internal class CCirculo
    {
        private float mRadio;
        private float mPerimetro;
        private float mArea;

        public CCirculo()
        {
            mRadio = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
        }

        public void LeerDatos(TextBox txtRadio)
        {
            if (string.IsNullOrWhiteSpace(txtRadio.Text))
            {
                MessageBox.Show("Ingrese un valor para el radio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                mRadio = float.Parse(txtRadio.Text);

                if (mRadio <= 0)
                {
                    MessageBox.Show("El radio debe ser positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mRadio = 0;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mRadio = 0;
            }
        }

        public void CalcularArea()
        {
            mArea = (float)Math.PI * (mRadio * mRadio);
        }

        public void CalcularPerimetro()
        {
            mPerimetro = 2 * (float)Math.PI * mRadio;
        }

        public void MostrarDatos(TextBox txtPerimetro, TextBox txtArea)
        {
            if (mRadio > 0)
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

        public void InicializarDatos(TextBox txtRadio, TextBox txtPerimetro, TextBox txtArea)
        {
            mRadio = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
            txtRadio.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtRadio.Focus();
        }

        public void CerrarFormulario(Form form)
        {
            form.Close();
        }
    }
}
