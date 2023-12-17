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
    public partial class frmListarEmpleados : Form
    {
        public frmListarEmpleados()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsEmpleados objEmpleados = new clsEmpleados();
            objEmpleados.Listar(Grilla);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            clsEmpleados objEmpleados = new clsEmpleados();
            objEmpleados.GenerarReporteEmpleados();
            MessageBox.Show("Reporte generado exitosamente");
        }
    }
}