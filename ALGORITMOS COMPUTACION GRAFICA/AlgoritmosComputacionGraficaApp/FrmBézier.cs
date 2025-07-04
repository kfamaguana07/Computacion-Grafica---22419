﻿using System;
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
    public partial class FrmBézier : Form
    {
        private CBézier bezier = new CBézier();
        private int draggingIndex = -1;
        private bool isDragging = false;
        private static FrmBézier instancia;
        public FrmBézier()
        {
            InitializeComponent();
        }
        public static FrmBézier ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmBézier();
            }
            return instancia;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            bezier.Clear();
            picCanvas.Invalidate();
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !isDragging)
            {
                bezier.AddPoint(e.Location);
                picCanvas.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                bezier.RemovePointAt(e.Location);
                picCanvas.Invalidate();
            }

            if (bezier.ControlPoints.Count < 4)
            {
               
            }
            else
            {
                
            }
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            bezier.Draw(e.Graphics);
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            draggingIndex = bezier.GetPointIndexAt(e.Location);
            if (draggingIndex != -1)
                isDragging = true;
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && draggingIndex != -1)
            {
                bezier.MovePoint(draggingIndex, e.Location);
                picCanvas.Invalidate();
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            draggingIndex = -1;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
