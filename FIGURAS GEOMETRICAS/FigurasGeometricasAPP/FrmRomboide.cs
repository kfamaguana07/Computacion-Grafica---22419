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
    public partial class FrmRomboide : Form
    {
        private CRomboide objRomboide = new CRomboide();
        private static FrmRomboide instancia;

        public FrmRomboide()
        {
            InitializeComponent();
        }
        public static FrmRomboide ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
                instancia = new FrmRomboide();
            return instancia;
        }
        private void FrmRomboide_Load(object sender, EventArgs e)
        {
            objRomboide.InicializarDatos(txtBase, txtAltura, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objRomboide.LeerDatos(txtBase, txtAltura);
            objRomboide.CalcularArea();
            objRomboide.CalcularPerimetro();
            objRomboide.MostrarDatos(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            objRomboide.InicializarDatos(txtBase, txtAltura, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            objRomboide.CerrarFormulario(this);
        }
    }
}
