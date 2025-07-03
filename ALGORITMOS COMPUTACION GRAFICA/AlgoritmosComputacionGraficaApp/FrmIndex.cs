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
using CohenSutherlandAPP;

namespace AlgoritmosComputacionGraficaApp
{
    public partial class FrmIndex : Form
    {
        public FrmIndex()
        {
            InitializeComponent();
        }

        private void FrmIndex_Load(object sender, EventArgs e)
        {

        }

        private void btnDDA_Click(object sender, EventArgs e)
        {
            FrmDDA frm = FrmDDA.ObtenerInstancia();
            frm.Show();
        }

        private void btnSplines_Click(object sender, EventArgs e)
        {
            FrmBSplines frm = FrmBSplines.ObtenerInstancia();
            frm.Show();
        }

        private void btnBresenhamLineas_Click(object sender, EventArgs e)
        {
            FrmAlgoritmoBresenham frm = FrmAlgoritmoBresenham.ObtenerInstancia();
            frm.Show();
        }

        private void btnBresenhamCircunferencias_Click(object sender, EventArgs e)
        {
            FrmDiscretizacionCircunferencia frm = FrmDiscretizacionCircunferencia.ObtenerInstancia();
            frm.Show();
        }

        private void btnFloodFill_Click(object sender, EventArgs e)
        {
            FrmRellenoFiguras frm = FrmRellenoFiguras.ObtenerInstancia();
            frm.Show();
        }

        private void btnCohenSutherland_Click(object sender, EventArgs e)
        {
            FrmCohenSutherland frm = FrmCohenSutherland.ObtenerInstancia();
            frm.Show();
        }

        private void btnBresenhamElipses_Click(object sender, EventArgs e)
        {
            FrmBresenhamElipses frm = FrmBresenhamElipses.ObtenerInstancia();
            frm.Show();
        }

        private void btnRellenoScaline_Click(object sender, EventArgs e)
        {
            FrmScanline frm = FrmScanline.ObtenerInstancia();
            frm.Show();
        }

        private void btnSutherlandHodgman_Click(object sender, EventArgs e)
        {
            FrmSutherlandHodgman frm = FrmSutherlandHodgman.ObtenerInstancia();
            frm.Show();
        }

        private void btnCurvasBézier_Click(object sender, EventArgs e)
        {
            FrmBézier frm = FrmBézier.ObtenerInstancia();
            frm.Show();
        }
    }
}

