using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioTP
{
    public partial class frmConsultarVenta : Form
    {
        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=GlobantClientes.mdb";

        public frmConsultarVenta()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Obtener los valores seleccionados en el ComboBox y el DateTimePicker
            Int32 idEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue);
            DateTime fecha = dtpFecha.Value;

            // Crear una instancia de la clase clsVentas
            clsVentas ventas = new clsVentas();

            // Llamar al método ConsultarVentasPorEmpleadoYFecha para obtener las ventas
            DataTable resultadoVentas = ventas.ConsultarVentasPorEmpleadoYFecha(idEmpleado, fecha);

            // Mostrar la cantidad de filas obtenidas en el resultado
            MessageBox.Show("Número de ventas encontradas: " + resultadoVentas.Rows.Count);

            // Mostrar los resultados en la Grilla
            Grilla.DataSource = resultadoVentas;

            // Opcionalmente, puedes personalizar la apariencia de la Grilla
            // Aquí hay un ejemplo de cómo ajustar automáticamente el tamaño de las columnas:
            Grilla.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Modificar los nombres de las columnas
            Grilla.Columns["saleDate"].HeaderText = "Fecha de Venta";
            Grilla.Columns["ServiceName"].HeaderText = "Nombre del Servicio";
            Grilla.Columns["ClientName"].HeaderText = "Nombre del Cliente";
            Grilla.Columns["EName"].HeaderText = "Nombre del Empleado";
            Grilla.Columns["Importe"].HeaderText = "Importe Total";

        }

        private void frmConsultarVenta_Load(object sender, EventArgs e)
        {
            // Llenar ComboBox de Empleados
            CargarComboBoxEmpleados(cmbEmpleado);
        }

        private void CargarComboBoxEmpleados(ComboBox comboBox)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT IdEmpleado, EName FROM employees";
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        using (OleDbDataAdapter adaptador = new OleDbDataAdapter(comando))
                        {
                            DataTable tablaEmpleados = new DataTable();
                            adaptador.Fill(tablaEmpleados);

                            comboBox.DataSource = tablaEmpleados;
                            comboBox.DisplayMember = "EName";
                            comboBox.ValueMember = "IdEmpleado";
                        }
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los empleados: " + ex.Message);
            }
        }
    }
}
