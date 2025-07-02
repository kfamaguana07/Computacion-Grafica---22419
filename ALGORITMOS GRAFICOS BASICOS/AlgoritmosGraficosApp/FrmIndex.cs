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
    public partial class FrmIndex : Form
    {
        public FrmIndex()
        {
            InitializeComponent();
        }

        private void FrmIndex_Load(object sender, EventArgs e)
        {

        }

        private void lineasRectasDDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlgoritmoDDA frm = FrmAlgoritmoDDA.ObtenerInstancia();
            frm.Show();
        }

        private void lineasRectasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlgoritmoBresenham frm = FrmAlgoritmoBresenham.ObtenerInstancia();
            frm.Show();
        }

        private void circunferenciasBresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDiscretizacionCircunferencia frm = FrmDiscretizacionCircunferencia.ObtenerInstancia();
            frm.Show();
        }

        private void rellenoFigurasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRellenoFiguras frm = FrmRellenoFiguras.ObtenerInstancia();
            frm.Show();
        }
    }
}
