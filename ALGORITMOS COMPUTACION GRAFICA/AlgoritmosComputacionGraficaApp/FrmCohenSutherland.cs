using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgoritmosGraficosApp;

namespace CohenSutherlandAPP
{
    public partial class FrmCohenSutherland : Form
    {
        private Point punto1, punto2;
        private bool dibujar = false;
        private static FrmCohenSutherland instancia;


        public FrmCohenSutherland()
        {
            InitializeComponent();
            picCanvas.Paint += picCanvas_Paint;
        }

        public static FrmCohenSutherland ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmCohenSutherland();
            }
            return instancia;
        }
        private void btnRecortar_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = int.Parse(txtX1.Text);
                int y1 = int.Parse(txtY1.Text);
                int x2 = int.Parse(txtX2.Text);
                int y2 = int.Parse(txtY2.Text);

                punto1 = new Point(x1, y1);
                punto2 = new Point(x2, y2);

                dibujar = true;
                picCanvas.Invalidate(); // Redibuja el PictureBox
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese coordenadas válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtX1.Clear();
            txtY1.Clear();
            txtX2.Clear();
            txtY2.Clear();
            dibujar = false;
            picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            // Ventana de recorte
            int xmin = 100, ymin = 100, xmax = 300, ymax = 200;
            Rectangle ventana = new Rectangle(xmin, ymin, xmax - xmin, ymax - ymin);
            g.DrawRectangle(Pens.Black, ventana);

            if (dibujar)
            {
                g.DrawLine(Pens.Gray, punto1, punto2);

                Point p1 = punto1;
                Point p2 = punto2;

                var cs = new CCohenSutherland(xmin, ymin, xmax, ymax);

                if (cs.Clip(ref p1, ref p2))
                {
                    g.DrawLine(new Pen(Color.Red, 2), p1, p2);
                }
            }
        }

    }
}
