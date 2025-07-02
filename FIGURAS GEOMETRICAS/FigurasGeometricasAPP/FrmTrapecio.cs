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
    public partial class FrmTrapecio : Form
    {
        private CTrapecio ObjTrapecio = new CTrapecio();
        private static FrmTrapecio instancia;
        public FrmTrapecio()
        {
            InitializeComponent();
        }
        public static FrmTrapecio ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmTrapecio();
            }
            return instancia;
        }
        private void FrmTrapecio_Load(object sender, EventArgs e)
        {
            ObjTrapecio.InicializarDatos(txtLadoDer, txtLadoIzq, txtBaseMay, txtBaseMen, txtAltura, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjTrapecio.LeerDatos(txtLadoDer, txtLadoIzq, txtBaseMay, txtBaseMen, txtAltura);
            ObjTrapecio.CalcularPerimetro();
            ObjTrapecio.CalcularArea();
            ObjTrapecio.MostrarDatos(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ObjTrapecio.InicializarDatos(txtLadoDer, txtLadoIzq, txtBaseMay, txtBaseMen, txtAltura, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ObjTrapecio.CerrarFormulario(this);
        }
    }
}
