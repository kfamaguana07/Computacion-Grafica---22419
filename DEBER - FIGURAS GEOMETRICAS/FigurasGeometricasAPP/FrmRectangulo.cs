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
    public partial class FrmRectangulo : Form
    {
        private CRectangulo ObjRectangulo = new CRectangulo();
        private static FrmRectangulo instancia;
        public FrmRectangulo()
        {
            InitializeComponent();
        }
        public static FrmRectangulo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmRectangulo();
            }
            return instancia;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjRectangulo.LeerDatos(txtBase, txtAltura);
            ObjRectangulo.CalcularPerimetro();
            ObjRectangulo.CalcularArea();
            ObjRectangulo.MostrarDatos(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ObjRectangulo.InicializarDatos(txtBase, txtAltura, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ObjRectangulo.CerrarFormulario(this);
        }

        private void FrmRectangulo_Load(object sender, EventArgs e)
        {
            ObjRectangulo.InicializarDatos(txtBase, txtAltura, txtPerimetro, txtArea);
        }
    }
}
