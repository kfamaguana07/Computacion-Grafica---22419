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
    }
}

