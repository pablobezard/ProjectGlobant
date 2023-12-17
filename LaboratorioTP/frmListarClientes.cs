using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioTP
{
    public partial class frmListarClientes : Form
    {
        public frmListarClientes()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsClientes objClientes = new clsClientes();
            objClientes.Listar(Grilla);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            clsClientes objCliente = new clsClientes();
            objCliente.ReporteClientes();
            MessageBox.Show("Reporte generado exitosamente");
        }
    }
}
