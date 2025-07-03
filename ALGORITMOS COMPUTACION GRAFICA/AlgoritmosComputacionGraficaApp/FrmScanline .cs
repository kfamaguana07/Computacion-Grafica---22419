using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CohenSutherlandAPP;

namespace AlgoritmosComputacionGraficaApp
{
    public partial class FrmScanline : Form
    {
        private List<Point> vertices = new List<Point>();
        private Bitmap bmp;
        private CScanline scanline;
        private static FrmScanline instancia;
        public FrmScanline()
        {
            InitializeComponent();
            bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = bmp;
        }

        public static FrmScanline ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmScanline();
            }
            return instancia;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnRellenar_Click(object sender, EventArgs e)
        {
            if (vertices.Count < 3)
            {
                MessageBox.Show("Debe agregar al menos 3 puntos para formar un polígono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            scanline = new CScanline();
            scanline.Rellenar(bmp, vertices.ToArray(), Color.Red);
            picCanvas.Invalidate();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            vertices.Clear();
            bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = bmp;
            picCanvas.Invalidate();
        }

        private void FrmScanline_Load(object sender, EventArgs e)
        {

        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            vertices.Add(new Point(e.X, e.Y));
            DibujarPoligono();
        }

        private void DibujarPoligono()
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                // Dibuja puntos
                foreach (var p in vertices)
                {
                    g.FillEllipse(Brushes.Black, p.X - 3, p.Y - 3, 6, 6);
                }

                // Dibuja líneas solo si hay al menos 2 puntos
                if (vertices.Count > 1)
                {
                    g.DrawPolygon(Pens.Black, vertices.ToArray());
                }
            }
            picCanvas.Invalidate();
        }
    }
}
