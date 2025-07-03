using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosGraficosApp
{
    public partial class FrmAlgoritmoBresenham : Form
    {
        private CAlgoritmoBresenham bresenham;
        private int indiceActual;
        private Timer timer;
        private static FrmAlgoritmoBresenham instancia;

        public FrmAlgoritmoBresenham()
        {
            InitializeComponent();
            InicializarTimer();
        }
        public static FrmAlgoritmoBresenham ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmAlgoritmoBresenham();
            }
            return instancia;
        }

        private void picCanvasPaint(object sender, PaintEventArgs e)
        {
            bresenham?.Dibujar(e.Graphics, indiceActual - 1);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int x0 = int.Parse(txtXo.Text);
                int y0 = int.Parse(txtYo.Text);
                int x1 = int.Parse(txtXf.Text);
                int y1 = int.Parse(txtYf.Text);
                int altura = picCanvas.Height;
                int ancho = picCanvas.Width;
                bresenham = new CAlgoritmoBresenham(x0, y0, x1, y1, altura, ancho);
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
            bresenham = null;
            indiceActual = 0;
            picCanvas.Image = null;
            txtPuntos.Items.Clear();
            picCanvas.Invalidate();

            // Limpiar todos los TextBox que usas para ingresar puntos
            txtXo.Clear();
            txtYo.Clear();
            txtXf.Clear();
            txtYf.Clear();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (bresenham == null)
                return;

            if (indiceActual < bresenham.GetPuntos().Count)
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

            var puntos = bresenham?.GetPuntos();
            if (puntos == null)
                return;

            for (int i = 0; i < indiceActual; i++)
            {
                var punto = puntos[i];
                txtPuntos.Items.Add($"({punto.X}, {punto.Y})");
            }
        }

        private void InicializarTimer()
        {
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private void FrmAlgoritmoBresenham_Load(object sender, EventArgs e)
        {

        }
    }
}
