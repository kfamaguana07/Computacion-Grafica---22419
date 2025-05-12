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
    public partial class FrmPentagono : Form
    {
        private CPentagono objPentagono = new CPentagono();
        private static FrmPentagono instancia;
        public FrmPentagono()
        {
            InitializeComponent();
        }
        public static FrmPentagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
                instancia = new FrmPentagono();
            return instancia;
        }
        private void FrmPentagono_Load(object sender, EventArgs e)
        {
            objPentagono.Inicializar(txtRadio, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objPentagono.Leer(txtRadio);
            objPentagono.CalcularPerimetro();
            objPentagono.CalcularArea();
            objPentagono.Mostrar(txtPerimetro, txtArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            objPentagono.Inicializar(txtRadio, txtPerimetro, txtArea);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            objPentagono.Salir(this);
        }
    }
}
