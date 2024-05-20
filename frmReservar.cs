using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryReservasAmbordt
{
    public partial class frmReservar : Form
    {
        public frmReservar()
        {
            InitializeComponent();
        }

        private void btnReservarQuenaquen_Click(object sender, EventArgs e)
        {
            frmReservarQuenaquen quenaquen = new frmReservarQuenaquen();
            quenaquen.ShowDialog();
        }

        private void btnReservarOnas_Click(object sender, EventArgs e)
        {
            frmReservarOnas onas = new frmReservarOnas();
            onas.ShowDialog();
        }

        private void btnReservarTobas_Click(object sender, EventArgs e)
        {
            frmReservarTobas tobas = new frmReservarTobas();
            tobas.ShowDialog();
        }
    }
}
