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
    public partial class FrmCirculo : Form
    {
        private CCirculo ObjCirculo = new CCirculo();
        private static FrmCirculo instancia;

        public FrmCirculo()
        {
            InitializeComponent();
        }
        public static FrmCirculo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmCirculo();
            }
            return instancia;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjCirculo.LeerDatos(txtRadio);
            ObjCirculo.CalcularPerimetro();
            ObjCirculo.CalcularArea();
            ObjCirculo.MostrarDatos(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ObjCirculo.InicializarDatos(txtRadio, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ObjCirculo.CerrarFormulario(this);
        }

        private void FrmCirculo_Load(object sender, EventArgs e)
        {
            ObjCirculo.InicializarDatos(txtRadio, txtPerimetro, txtArea);
        }
    }
}
