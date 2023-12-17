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
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Int32 IdCliente = Convert.ToInt32(txtCodigo.Text);
            clsClientes x = new clsClientes();
            x.Buscar(IdCliente);
            if (x.IdCliente != 0)
            {
                lblNombre.Text = x.Name;
                lblHome.Text = x.Home.ToString();
                lblPhone.Text = x.Phone.ToString();
            }
            else
            {
                lblNombre.Text = "";
                lblHome.Text = "";
                lblPhone.Text = "";
                MessageBox.Show("Dato no encontrado");
            }

        }
    }
}
