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
    public partial class frmAgregarEmpleado : Form
    {
        public frmAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsEmpleados empleado = new clsEmpleados();
            empleado.EName = txtName.Text;
            empleado.EHome = txtHome.Text;
            empleado.EPhone = txtPhone.Text;

            // Obtener el último IdEmpleado utilizado en la base de datos
            int ultimoIdEmpleado = empleado.ObtenerUltimoIdEmpleado();

            // Generar un nuevo IdEmpleado incrementando en 1 el último IdEmpleado utilizado
            int nuevoIdEmpleado = ultimoIdEmpleado + 1;

            // Asignar el nuevo IdEmpleado al objeto empleado
            empleado.IdEmpleado = nuevoIdEmpleado;

            empleado.Agregar();
        }
    }
}
