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
    public partial class FrmOctagono : Form
    {
        private COctagono objOctagono = new COctagono();
        private static FrmOctagono instancia;
        public FrmOctagono()
        {
            InitializeComponent();
        }
        public static FrmOctagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
                instancia = new FrmOctagono();
            return instancia;
        }
        private void FrmOctagono_Load(object sender, EventArgs e)
        {
            objOctagono.Inicializar(txtRadio, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objOctagono.Leer(txtRadio);
            objOctagono.CalcularPerimetro();
            objOctagono.CalcularArea();
            objOctagono.Mostrar(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            objOctagono.Inicializar(txtRadio, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            objOctagono.Salir(this);
        }
    }
}
