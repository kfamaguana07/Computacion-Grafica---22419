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
    public partial class FrmDiscretizacionCircunferencia : Form
    {
        private CDiscretizacionCircunferencia circulo;
        private Timer timer;
        private int indiceActual;
        private static FrmDiscretizacionCircunferencia instancia;
        public FrmDiscretizacionCircunferencia()
        {
            InitializeComponent();
            InicializarTimer();
        }

        public static FrmDiscretizacionCircunferencia ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmDiscretizacionCircunferencia();
            }
            return instancia;
        }
        private void InicializarTimer()
        {
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int cx = int.Parse(txtCentroX.Text);
                int cy = int.Parse(txtCentroY.Text);
                int radio = int.Parse(txtRadio.Text);

                int ancho = picCanvas.Width;
                int alto = picCanvas.Height;

                circulo = new CDiscretizacionCircunferencia(cx, cy, radio, ancho, alto);
                indiceActual = 0;
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (circulo == null) return;

            if (indiceActual < circulo.GetPuntos().Count)
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
            var puntos = circulo.GetPuntos();

            for (int i = 0; i < indiceActual; i++)
            {
                txtPuntos.Items.Add($"({puntos[i].X}, {puntos[i].Y})");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            timer.Stop();
            circulo = null;
            indiceActual = 0;

            picCanvas.Image = null;
            picCanvas.Invalidate();

            txtCentroX.Clear();
            txtCentroY.Clear();
            txtRadio.Clear();
            txtPuntos.Items.Clear();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            circulo?.Dibujar(e.Graphics, indiceActual);
        }

        private void FrmDiscretizacionCircunferencia_Load(object sender, EventArgs e)
        {

        }
    }
}
