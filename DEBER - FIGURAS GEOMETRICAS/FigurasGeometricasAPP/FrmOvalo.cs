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
    public partial class FrmOvalo : Form
    {
        private COvalo objOvalo = new COvalo();
        private static FrmOvalo instancia;
        public FrmOvalo()
        {
            InitializeComponent();
        }
        public static FrmOvalo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmOvalo();
            }
            return instancia;
        }
        private void FrmOvalo_Load(object sender, EventArgs e)
        {
            objOvalo.InicializarDatos(txtAncho, txtAlto, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objOvalo.LeerDatos(txtAncho, txtAlto);
            objOvalo.CalcularArea();
            objOvalo.CalcularPerimetro();
            objOvalo.MostrarDatos(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            objOvalo.InicializarDatos(txtAncho, txtAlto, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            objOvalo.CerrarFormulario(this);
        }
    }
}
