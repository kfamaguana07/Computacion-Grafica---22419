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
   
    public partial class FrmSutherlandHodgman : Form
    {
        private List<PointF> poligono = new List<PointF>();
        private List<PointF> poligonoRecortado = null;
        private RectangleF ventanaRecorte;
        private static FrmSutherlandHodgman instancia;

        private Bitmap bmp;
        public FrmSutherlandHodgman()
        {
            InitializeComponent();
            bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = bmp;

            // Definimos la ventana de recorte fija (por ejemplo un rectángulo centrado)
            int margin = 50;
            ventanaRecorte = new RectangleF(margin, margin, picCanvas.Width - 2 * margin, picCanvas.Height - 2 * margin);

            picCanvas.MouseClick += picCanvas_MouseClick;
            btnRecortar.Click += btnRecortar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            picCanvas.Paint += PicCanvas_Paint;
        }

        public static FrmSutherlandHodgman ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmSutherlandHodgman();
            }
            return instancia;
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            poligono.Add(new PointF(e.X, e.Y));
            poligonoRecortado = null; // Limpiamos resultado previo
            picCanvas.Invalidate();
        }

        private void btnRecortar_Click(object sender, EventArgs e)
        {
            if (poligono.Count < 3)
            {
                MessageBox.Show("Agrega al menos 3 puntos para formar un polígono.");
                return;
            }

            CSutherlandHodgman alg = new CSutherlandHodgman();
            poligonoRecortado = alg.RecortarPoligono(poligono, ventanaRecorte);
            picCanvas.Invalidate();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            poligono.Clear();
            poligonoRecortado = null;
            picCanvas.Invalidate();
        }

        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            // Dibujar ventana de recorte
            using (Pen penVentana = new Pen(Color.Blue, 2))
            {
                g.DrawRectangle(penVentana, Rectangle.Round(ventanaRecorte));
            }

            // Dibujar polígono original
            if (poligono.Count > 1)
            {
                using (Pen penOriginal = new Pen(Color.Black, 2))
                {
                    g.DrawPolygon(penOriginal, poligono.ToArray());
                }
            }

            // Dibujar polígono recortado
            if (poligonoRecortado != null && poligonoRecortado.Count > 1)
            {
                using (Pen penRecortado = new Pen(Color.Red, 2))
                {
                    g.DrawPolygon(penRecortado, poligonoRecortado.ToArray());
                }
            }
        }
    }
}
