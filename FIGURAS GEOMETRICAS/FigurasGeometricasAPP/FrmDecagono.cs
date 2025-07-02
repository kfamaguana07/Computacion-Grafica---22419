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
    public partial class FrmDecagono : Form
    {
        private CDecagono objDecagono = new CDecagono();
        private static FrmDecagono instancia;
        public FrmDecagono()
        {
            InitializeComponent();
        }
        public static FrmDecagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
                instancia = new FrmDecagono();
            return instancia;
        }
        private void FrmDecagono_Load(object sender, EventArgs e)
        {
            objDecagono.Inicializar(txtRadio, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objDecagono.Leer(txtRadio);
            objDecagono.CalcularPerimetro();
            objDecagono.CalcularArea();
            objDecagono.Mostrar(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            objDecagono.Inicializar(txtRadio, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            objDecagono.Salir(this);
        }
    }
}
