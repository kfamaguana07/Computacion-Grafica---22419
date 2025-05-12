using System;
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
    public partial class FrmIndex : Form
    {
        public FrmIndex()
        {
            InitializeComponent();
        }
        private void OpenForm(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cuadrilaterosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuadrado frm = FrmCuadrado.ObtenerInstancia();
            frm.Show();
        }

        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPentagono frm = FrmPentagono.ObtenerInstancia();
            frm.Show();
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectangulo frm = FrmRectangulo.ObtenerInstancia();
            frm.Show();
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRombo frm = FrmRombo.ObtenerInstancia();
            frm.Show();
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRomboide frm = FrmRomboide.ObtenerInstancia();
            frm.Show();
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapecio frm = FrmTrapecio.ObtenerInstancia();
            frm.Show();
        }

        private void trapecioisoscelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapecioIsoceles frm = FrmTrapecioIsoceles.ObtenerInstancia();
            frm.Show();
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapezoide frm = FrmTrapezoide.ObtenerInstancia();
            frm.Show();
        }

        private void deltoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeltoide frm = FrmDeltoide.ObtenerInstancia();
            frm.Show();
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCirculo frm = FrmCirculo.ObtenerInstancia();
            frm.Show();
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmElipse frm = FrmElipse.ObtenerInstancia();
            frm.Show();
        }

        private void ovaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOvalo frm = FrmOvalo.ObtenerInstancia();
            frm.Show();
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangulo frm = FrmTriangulo.ObtenerInstancia();
            frm.Show();
        }

        private void hexagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHexagono frm = FrmHexagono.ObtenerInstancia();
            frm.Show();
        }

        private void heptagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHeptagono frm = FrmHeptagono.ObtenerInstancia();
            frm.Show();
        }

        private void octagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOctagono frm = FrmOctagono.ObtenerInstancia();
            frm.Show();
        }

        private void eneagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEneagono frm = FrmEneagono.ObtenerInstancia();
            frm.Show();
        }

        private void decagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDecagono frm = FrmDecagono.ObtenerInstancia();
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
