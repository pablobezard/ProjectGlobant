namespace LaboratorioTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCliente Ventana = new frmAgregarCliente();
            Ventana.ShowDialog();
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarClientes Ventana = new frmListarClientes();
            Ventana.ShowDialog();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCliente Ventana = new frmBuscarCliente();
            Ventana.ShowDialog();
        }

        private void agregarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarVenta Ventana = new frmAgregarVenta();
            Ventana.ShowDialog();
        }

        private void consultarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarVenta Ventana = new frmConsultarVenta();
            Ventana.ShowDialog();
        }

        private void graficoDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGraficoVentas Ventana = new frmGraficoVentas();
            Ventana.ShowDialog();
        }

        private void agregarNuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarEmpleado Ventana = new frmAgregarEmpleado();
            Ventana.ShowDialog();
        }

        private void listarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarEmpleados Ventana = new frmListarEmpleados();
            Ventana.ShowDialog();
        }

        private void buscarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleado Ventana = new frmBuscarEmpleado();
            Ventana.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe Ventana = new frmAcercaDe();
            Ventana.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}