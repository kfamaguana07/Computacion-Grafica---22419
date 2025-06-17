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
    public partial class FrmCuadrado : Form
    {
        private CCuadrado ObjCuadrado = new CCuadrado();
        private static FrmCuadrado instancia;
        private CPintar ObjPintar = new CPintar();

        public FrmCuadrado()
        {
            InitializeComponent();
        }
        public static FrmCuadrado ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmCuadrado();
            }
            return instancia;
        }

        private void grbEntrada_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjCuadrado.LeerDatos(txtLado);
            ObjCuadrado.CalcularPerimetro();
            ObjCuadrado.CalcularArea();
            ObjCuadrado.MostrarDatos(txtPerimetro, txtArea);
            ObjCuadrado.DibujarCuadrado(picCanvas); // Dibuja el círculo
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ObjCuadrado.InicializarDatos(txtLado, txtPerimetro, txtArea);
            picCanvas.Image = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ObjCuadrado.CerrarFormulario(this);
        }

        private void FrmCuadrado_Load(object sender, EventArgs e)
        {
            ObjCuadrado.InicializarDatos(txtLado, txtPerimetro, txtArea);
            picCanvas.MouseClick += picCanvas_MouseClick;
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (picCanvas.Image != null)
            {
                Bitmap bmp = new Bitmap(picCanvas.Image);
                ObjPintar.FloodFill(bmp, e.X, e.Y, Color.Red);
                picCanvas.Image = bmp;
            }
        }
    }
}
