using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasAPP
{
    internal class CRectangulo
    {
        private float mBase;
        private float mAltura;
        private float mPerimetro;
        private float mArea;

        public CRectangulo()
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
                    mBase = 0;
                    mAltura = 0;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mBase = 0;
                mAltura = 0;
            }
        }

        public void CalcularArea()
        {
            mArea = mBase * mAltura;
        }

        public void CalcularPerimetro()
        {
            mPerimetro = 2 * (mBase + mAltura);
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
