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
    public partial class FrmEneagono : Form
    {
        private CEneagono objEneagono = new CEneagono();
        private static FrmEneagono instancia;
        public FrmEneagono()
        {
            InitializeComponent();
        }
        public static FrmEneagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
                instancia = new FrmEneagono();
            return instancia;
        }
        private void FrmEneagono_Load(object sender, EventArgs e)
        {
            objEneagono.Inicializar(txtRadio, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objEneagono.Leer(txtRadio);
            objEneagono.CalcularPerimetro();
            objEneagono.CalcularArea();
            objEneagono.Mostrar(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            objEneagono.Inicializar(txtRadio, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            objEneagono.Salir(this);
        }
    }
}
