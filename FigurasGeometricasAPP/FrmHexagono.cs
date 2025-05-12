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
    public partial class FrmHexagono : Form
    {
        private CHexagono objHexagono = new CHexagono();
        private static FrmHexagono instancia;
        public FrmHexagono()
        {
            InitializeComponent();
        }
        public static FrmHexagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
                instancia = new FrmHexagono();
            return instancia;
        }
        private void FrmHexagono_Load(object sender, EventArgs e)
        {
            objHexagono.Inicializar(txtRadio, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objHexagono.Leer(txtRadio);
            objHexagono.CalcularPerimetro();
            objHexagono.CalcularArea();
            objHexagono.Mostrar(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            objHexagono.Inicializar(txtRadio, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            objHexagono.Salir(this);
        }
    }
}
