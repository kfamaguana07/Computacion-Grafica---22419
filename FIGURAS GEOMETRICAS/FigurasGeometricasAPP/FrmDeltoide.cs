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
    public partial class FrmDeltoide : Form
    {
        private CDeltoide objDeltoide = new CDeltoide();
        private static FrmDeltoide instancia;
        public FrmDeltoide()
        {
            InitializeComponent();
        }
        public static FrmDeltoide ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmDeltoide();
            }
            return instancia;
        }
        private void FrmDeltoide_Load(object sender, EventArgs e)
        {
            objDeltoide.InicializarDatos(txtLado1, txtLado2, txtAngulo, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objDeltoide.LeerDatos(txtLado1, txtLado2, txtAngulo);
            objDeltoide.CalcularArea();
            objDeltoide.CalcularPerimetro();
            objDeltoide.MostrarDatos(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            objDeltoide.InicializarDatos(txtLado1, txtLado2, txtAngulo, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            objDeltoide.CerrarFormulario(this);
        }
    }
}
