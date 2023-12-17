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
    public partial class frmBuscarEmpleado : Form
    {
        public frmBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 IdEmpleado = Convert.ToInt32(txtCodigo.Text);
            clsEmpleados x = new clsEmpleados();
            x.Buscar(IdEmpleado);

            if (x.IdEmpleado != 0)
            {
                lblNombre.Text = x.EName;
                lblHome.Text = x.EHome.ToString();
                lblPhone.Text = x.EPhone.ToString();
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