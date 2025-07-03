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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlgoritmosComputacionGraficaApp
{
    public partial class FrmBresenhamElipses : Form
    {
        private CBresenhamElipses elipse;
        private Timer timer;
        private int indiceActual;
        private static FrmBresenhamElipses instancia;
        public FrmBresenhamElipses()
        {
            InitializeComponent();
            InicializarTimer();
            picCanvas.Paint += picCanvas_Paint;

        }
        public static FrmBresenhamElipses ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmBresenhamElipses();
            }
            return instancia;
        }

        private void InicializarTimer()
        {
            timer = new Timer();
            timer.Interval = 30; // velocidad animación (ms)
            timer.Tick += Timer_Tick;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int cx = int.Parse(txtCentroX.Text);
                int cy = int.Parse(txtCentroY.Text);
                int rx = int.Parse(txtRadioX.Text);
                int ry = int.Parse(txtRadioY.Text);  // cambia textBox1 a txtRadioY

                elipse = new CBresenhamElipses(cx, cy, rx, ry, picCanvas.Width, picCanvas.Height);
                indiceActual = 0;

                timer.Start();
            }
            catch
            {
                MessageBox.Show("Ingrese valores numéricos válidos.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            timer.Stop();
            elipse = null;
            indiceActual = 0;

            txtCentroX.Clear();
            txtCentroY.Clear();
            txtRadioX.Clear();
            txtRadioY.Clear();
            txtPuntos.Items.Clear();

            picCanvas.Image = null;
            picCanvas.Invalidate();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (elipse == null) return;

            if (indiceActual < elipse.GetPuntos().Count)
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
                var p = elipse.GetPuntos()[i];
                txtPuntos.Items.Add($"({p.X}, {p.Y})");
            }
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            elipse?.Dibujar(e.Graphics, indiceActual);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
