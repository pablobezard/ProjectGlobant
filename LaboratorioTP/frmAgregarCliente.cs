using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LaboratorioTP
{
    public partial class frmAgregarCliente : Form
    {
        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsClientes cliente = new clsClientes();
            cliente.Name = txtName.Text;
            cliente.Home = txtHome.Text;
            cliente.Phone = txtPhone.Text;

            // Obtener el último idCliente utilizado en la base de datos
            int ultimoIdCliente = cliente.ObtenerUltimoIdCliente();

            // Generar un nuevo idCliente incrementando en 1 el último idCliente utilizado
            int nuevoIdCliente = ultimoIdCliente + 1;

            // Asignar el nuevo idCliente al objeto cliente
            cliente.IdCliente = nuevoIdCliente;

            cliente.Agregar();
        }

    }
}
