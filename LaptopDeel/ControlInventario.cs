using System;
using System.Windows.Forms;

namespace LaptopDeel
{
    public partial class ControlInventario : UserControl
    {
        // Declaramos a los hijos
        private ControlInventarioNotebooks vistaNotebooks;
        private ControlInventarioComponentes vistaComponentes;

        public ControlInventario()
        {
            InitializeComponent(); // Esta llamada SÍ se queda
            this.Dock = DockStyle.Fill;

            // Los preparamos
            vistaNotebooks = new ControlInventarioNotebooks();
            vistaComponentes = new ControlInventarioComponentes();
        }

        private void ControlInventario_Load(object sender, EventArgs e)
        {
            MostrarVista(vistaNotebooks); // Arranca mostrando las notebooks
        }

        private void btnVerNotebooks_Click(object sender, EventArgs e)
        {
            MostrarVista(vistaNotebooks);
        }

        private void btnVerComponentes_Click(object sender, EventArgs e)
        {
            MostrarVista(vistaComponentes);
        }

        private void MostrarVista(UserControl vista)
        {
            pnlContenedor.Controls.Clear();
            vista.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(vista);
        }
    }
}