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
    public partial class FrmTrapezoide : Form
    {
        private CTrapezoide ObjTrapezoide = new CTrapezoide();
        private static FrmTrapezoide instancia;

        public FrmTrapezoide()
        {
            InitializeComponent();
        }
        public static FrmTrapezoide ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmTrapezoide();
            }
            return instancia;
        }
        private void FrmTrapezoide_Load(object sender, EventArgs e)
        {
            ObjTrapezoide.InicializarDatos(txtLado1, txtLado2, txtLado3, txtLado4, txtAltura, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjTrapezoide.LeerDatos(txtLado1, txtLado2, txtLado3, txtLado4, txtAltura);
            ObjTrapezoide.CalcularPerimetro();
            ObjTrapezoide.CalcularArea();
            ObjTrapezoide.MostrarDatos(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ObjTrapezoide.InicializarDatos(txtLado1, txtLado2, txtLado3, txtLado4, txtAltura, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ObjTrapezoide.CerrarFormulario(this);
        }
    }
}
