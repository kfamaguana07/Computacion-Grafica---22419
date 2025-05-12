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
    public partial class FrmHeptagono : Form
    {
        private CHeptagono objHeptagono = new CHeptagono();
        private static FrmHeptagono instancia;
        public FrmHeptagono()
        {
            InitializeComponent();
        }
        public static FrmHeptagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
                instancia = new FrmHeptagono();
            return instancia;
        }
        private void FrmHeptagono_Load(object sender, EventArgs e)
        {
            objHeptagono.Inicializar(txtRadio, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objHeptagono.Leer(txtRadio);
            objHeptagono.CalcularPerimetro();
            objHeptagono.CalcularArea();
            objHeptagono.Mostrar(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            objHeptagono.Inicializar(txtRadio, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            objHeptagono.Salir(this);
        }
    }
}
