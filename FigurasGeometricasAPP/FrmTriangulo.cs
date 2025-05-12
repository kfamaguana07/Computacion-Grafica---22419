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
    public partial class FrmTriangulo : Form
    {
        private CTriangulo ObjTriangulo = new CTriangulo();
        private static FrmTriangulo instancia;
        public FrmTriangulo()
        {
            InitializeComponent();
        }
        public static FrmTriangulo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmTriangulo();
            }
            return instancia;
        }
        private void lblTriangulo_Click(object sender, EventArgs e)
        {

        }

        private void FrmTriangulo_Load(object sender, EventArgs e)
        {
            ObjTriangulo.InicializarDatos(txtBase, txtAltura, txtPerimetro, txtArea);

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjTriangulo.LeerDatos(txtBase, txtAltura);
            ObjTriangulo.CalcularPerimetro();
            ObjTriangulo.CalcularArea();
            ObjTriangulo.MostrarDatos(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ObjTriangulo.InicializarDatos(txtBase, txtAltura, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ObjTriangulo.CerrarFormulario(this);
        }
    }
}
