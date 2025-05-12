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
    public partial class FrmCuadrado : Form
    {
        private CCuadrado ObjCuadrado = new CCuadrado();
        private static FrmCuadrado instancia;
        public FrmCuadrado()
        {
            InitializeComponent();
        }
        public static FrmCuadrado ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmCuadrado();
            }
            return instancia;
        }

        private void grbEntrada_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjCuadrado.LeerDatos(txtLado);
            ObjCuadrado.CalcularPerimetro();
            ObjCuadrado.CalcularArea();
            ObjCuadrado.MostrarDatos(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ObjCuadrado.InicializarDatos(txtLado, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ObjCuadrado.CerrarFormulario(this);
        }

        private void FrmCuadrado_Load(object sender, EventArgs e)
        {
            ObjCuadrado.InicializarDatos(txtLado, txtPerimetro, txtArea);
        }
    }
}
