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
    public partial class FrmBSplines : Form
    {
        private CSplines bspline = new CSplines();
        private int draggingIndex = -1;
        private bool isDragging = false;
        private static FrmBSplines instancia;
        public FrmBSplines()
        {
            InitializeComponent();
        }
        public static FrmBSplines ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmBSplines();
            }
            return instancia;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && !isDragging)
            {
                bspline.AddPoint(e.Location);
                picCanvas.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                bspline.RemovePointAt(e.Location);
                picCanvas.Invalidate();
            }
            if (bspline.ControlPoints.Count < 4)
            {
                
            }
            else
            {
                
            }
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            draggingIndex = bspline.GetPointIndexAt(e.Location);
            if (draggingIndex != -1)
                isDragging = true;
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && draggingIndex != -1)
            {
                bspline.MovePoint(draggingIndex, e.Location);
                picCanvas.Invalidate();
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            draggingIndex = -1;
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            bspline.Draw(e.Graphics);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            bspline.Clear();
            picCanvas.Invalidate();
        }
    }
}
