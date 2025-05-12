using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasAPP
{
    internal class CCuadrado
    {
        private float mLado;
        private float mPerimetro;
        private float mArea;

        public CCuadrado()
        {
            mLado = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
        }

        public void LeerDatos(TextBox txtLado)
        {
            if (string.IsNullOrWhiteSpace(txtLado.Text))
            {
                MessageBox.Show("Ingrese un valor para el lado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                mLado = float.Parse(txtLado.Text);

                if (mLado <= 0)
                {
                    MessageBox.Show("El valor del lado debe ser positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mLado = 0;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mLado = 0;
            }
        }

        public void CalcularArea()
        {
            mArea = mLado * mLado;
        }

        public void CalcularPerimetro()
        {
            mPerimetro = 4 * mLado;
        }

        public void MostrarDatos(TextBox txtPerimetro, TextBox txtArea)
        {
            if (mLado > 0)
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

        public void InicializarDatos(TextBox txtLado, TextBox txtPerimetro, TextBox txtArea)
        {
            mLado = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
            txtLado.Text = "";
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
