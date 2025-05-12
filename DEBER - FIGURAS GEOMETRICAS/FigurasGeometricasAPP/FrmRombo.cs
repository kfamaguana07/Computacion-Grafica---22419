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
    public partial class FrmRombo : Form
    {
        private CRombo ObjRombo = new CRombo();
        private static FrmRombo instancia;
        public FrmRombo()
        {
            InitializeComponent();
        }
        public static FrmRombo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmRombo();
            }
            return instancia;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjRombo.LeerDatos(txtLado, txtAltura);
            ObjRombo.CalcularPerimetro();
            ObjRombo.CalcularArea();
            ObjRombo.MostrarDatos(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ObjRombo.InicializarDatos(txtLado, txtAltura, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ObjRombo.CerrarFormulario(this);
        }

        private void FrmRombo_Load(object sender, EventArgs e)
        {
            ObjRombo.InicializarDatos(txtLado, txtAltura, txtPerimetro, txtArea);
        }
    }
}
