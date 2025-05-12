using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasAPP
{
    public partial class FrmElipse : Form
    {
        private CElipse objElipse = new CElipse();
        private static FrmElipse instancia;
        public FrmElipse()
        {
            InitializeComponent();
        }
        public static FrmElipse ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmElipse();
            }
            return instancia;
        }
        private void FrmElipse_Load(object sender, EventArgs e)
        {
            objElipse.InicializarDatos(txtEjeMay, txtEjeMen, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objElipse.LeerDatos(txtEjeMay, txtEjeMen);
            objElipse.CalcularArea();
            objElipse.CalcularPerimetro();
            objElipse.MostrarDatos(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            objElipse.InicializarDatos(txtEjeMay, txtEjeMen, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            objElipse.CerrarFormulario(this);
        }
    }
}
