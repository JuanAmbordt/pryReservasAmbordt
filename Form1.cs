namespace pryReservasAmbordt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            frmReservar reservar = new frmReservar();
            reservar.ShowDialog();
        }

        private void btnMostrarReservas_Click(object sender, EventArgs e)
        {
            frmReservas reservas = new frmReservas();
            reservas.ShowDialog();
        }
    }
}
