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

    public partial class FrmCirculo : Form
    {
        private CCirculo ObjCirculo = new CCirculo();
        private static FrmCirculo instancia;
        private CPintar ObjPintar = new CPintar();


        public FrmCirculo()
        {
            InitializeComponent();
        }
        public static FrmCirculo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmCirculo();
            }
            return instancia;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjCirculo.LeerDatos(txtRadio);
            ObjCirculo.CalcularPerimetro();
            ObjCirculo.CalcularArea();
            ObjCirculo.MostrarDatos(txtPerimetro, txtArea);
            ObjCirculo.DibujarCirculo(picCanvas); // Dibuja el círculo
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ObjCirculo.InicializarDatos(txtRadio, txtPerimetro, txtArea);
            picCanvas.Image = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ObjCirculo.CerrarFormulario(this);
        }

        private void FrmCirculo_Load(object sender, EventArgs e)
        {
            ObjCirculo.InicializarDatos(txtRadio, txtPerimetro, txtArea);
            picCanvas.MouseClick += picCanvas_MouseClick;
        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (picCanvas.Image != null)
            {
                Bitmap original = new Bitmap(picCanvas.Image);

                int x = e.X * original.Width / picCanvas.Width;
                int y = e.Y * original.Height / picCanvas.Height;

                if (x >= 0 && x < original.Width && y >= 0 && y < original.Height)
                {
                    ObjPintar.FloodFill(original, x, y, Color.Red);
                    picCanvas.Image = original;
                }
            }
        }
    }
}
