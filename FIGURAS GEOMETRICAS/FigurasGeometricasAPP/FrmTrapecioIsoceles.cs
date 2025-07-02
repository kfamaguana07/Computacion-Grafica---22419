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
    public partial class FrmTrapecioIsoceles : Form
    {
        private CTrapecioIsoceles objTrapecio = new CTrapecioIsoceles();
        private static FrmTrapecioIsoceles instancia;
        public FrmTrapecioIsoceles()
        {
            InitializeComponent();
        }
        public static FrmTrapecioIsoceles ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmTrapecioIsoceles();
            }
            return instancia;
        }

        private void grbEntrada_Enter(object sender, EventArgs e)
        {

        }

        private void FrmTrapecioIsoceles_Load(object sender, EventArgs e)
        {
            objTrapecio.InicializarDatos(txtBaseMay, txtBaseMen, txtAltura, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objTrapecio.LeerDatos(txtBaseMay, txtBaseMen, txtAltura);
            objTrapecio.CalcularPerimetro();
            objTrapecio.CalcularArea();
            objTrapecio.MostrarDatos(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            objTrapecio.InicializarDatos(txtBaseMay, txtBaseMen, txtAltura, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            objTrapecio.CerrarFormulario(this);
        }

        private void lblTriangulo_Click(object sender, EventArgs e)
        {

        }
    }
}
