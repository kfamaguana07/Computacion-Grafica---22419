﻿using System;
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
    public partial class FrmRombo : Form
    {
        private CRombo ObjRombo = new CRombo();
        private CPintar ObjPintar = new CPintar();
        private static FrmRombo instancia;
        public FrmRombo()
        {
            InitializeComponent();
        }
        public static FrmRombo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmRombo();
            }
            return instancia;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjRombo.LeerDatos(txtLado, txtAltura);
            ObjRombo.CalcularPerimetro();
            ObjRombo.CalcularArea();
            ObjRombo.MostrarDatos(txtPerimetro, txtArea);
            ObjRombo.DibujarRombo(picCanvas);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ObjRombo.InicializarDatos(txtLado, txtAltura, txtPerimetro, txtArea);
            picCanvas.Image = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ObjRombo.CerrarFormulario(this);

        }

        private void FrmRombo_Load(object sender, EventArgs e)
        {
            ObjRombo.InicializarDatos(txtLado, txtAltura, txtPerimetro, txtArea);
            picCanvas.MouseClick += picCanvas_MouseClick;

          
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (picCanvas.Image == null) return;

            Bitmap bmp = new Bitmap(picCanvas.Image);

            int x = e.X * bmp.Width / picCanvas.Width;
            int y = e.Y * bmp.Height / picCanvas.Height;

            ObjPintar.AsignarCanvas(picCanvas);
            ObjPintar.FloodFill(bmp, x, y, Color.Red, 1);  // animación de 1 ms por píxel
        }

        
    }
}
