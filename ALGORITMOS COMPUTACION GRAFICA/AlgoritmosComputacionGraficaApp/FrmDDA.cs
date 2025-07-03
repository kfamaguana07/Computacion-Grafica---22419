using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosComputacionGraficaApp
{
    public partial class FrmDDA : Form
    {
        private CDDA dda;
        private int indiceActual;
        private Timer timer;
        private static FrmDDA instancia;
        public FrmDDA()
        {
            InitializeComponent();
            InicializarTimer();
        }

        public static FrmDDA ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmDDA();
            }
            return instancia;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int x0 = int.Parse(txtXo.Text);
                int y0 = int.Parse(txtYo.Text);
                int x1 = int.Parse(txtXf.Text);
                int y1 = int.Parse(txtYf.Text);

                int ancho = picCanvas.Width;
                int alto = picCanvas.Height;

                dda = new CDDA(x0, y0, x1, y1, ancho, alto);
                indiceActual = 0;
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            timer.Stop();
            dda = null;
            indiceActual = 0;
            picCanvas.Image = null;
            txtPuntos.Items.Clear();
            picCanvas.Invalidate();
            txtXo.Clear();
            txtYo.Clear();
            txtXf.Clear();
            txtYf.Clear();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (dda == null) return;

            if (indiceActual < dda.GetPuntos().Count)
            {
                indiceActual++;
                picCanvas.Invalidate();
                ActualizarListaPuntos();
            }
            else
            {
                timer.Stop();
            }
        }
        private void ActualizarListaPuntos()
        {
            txtPuntos.Items.Clear();
            for (int i = 0; i < indiceActual; i++)
            {
                var punto = dda.GetPuntos()[i];
                txtPuntos.Items.Add($"({punto.X:0.00}, {punto.Y:0.00})");
            }
        }
        private void InicializarTimer()
        {
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void picCanvasPaint(object sender, PaintEventArgs e)
        {
            dda?.Dibujar(e.Graphics, indiceActual - 1);
        }
    }
}
