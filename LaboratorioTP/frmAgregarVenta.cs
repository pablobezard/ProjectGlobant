using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LaboratorioTP
{
    public partial class frmAgregarVenta : Form
    {
        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=GlobantClientes.mdb";

        public frmAgregarVenta()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener los valores seleccionados en los combobox y el control DateTimePicker
            Int32 idCliente = Convert.ToInt32(cmbCliente.SelectedValue);
            Int32 idEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue);
            Int32 idServicio = Convert.ToInt32(cmbServicio.SelectedValue);
            DateTime fechaVenta = dtpFecha.Value;

            // Obtener el valor del importe del control TextBox (suponiendo que se llame txtImporte)
            decimal importe = decimal.Parse(txtImporte.Text);

            // Crear una instancia de la clase clsVentas
            clsVentas ventas = new clsVentas();

            // Asignar los valores a las propiedades de la clase clsVentas
            ventas.IdCliente = idCliente;
            ventas.IdEmpleado = idEmpleado;
            ventas.IdServicio = idServicio;
            ventas.SaleDate = fechaVenta;
            ventas.Importe = importe;

            // Llamar al método AgregarVenta para agregar la venta en la base de datos
            ventas.AgregarVenta();
        }

        private void frmAgregarVenta_Load(object sender, EventArgs e)
        {
            // Llenar ComboBox de Clientes
            CargarComboBoxClientes(cmbCliente);

            // Llenar ComboBox de Empleados
            CargarComboBoxEmpleados(cmbEmpleado);

            // Llenar ComboBox de Servicios
            CargarComboBoxServicios(cmbServicio);
        }

        private void CargarComboBoxClientes(ComboBox comboBox)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT IdCliente, Name FROM customers";
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        using (OleDbDataAdapter adaptador = new OleDbDataAdapter(comando))
                        {
                            DataTable tablaClientes = new DataTable();
                            adaptador.Fill(tablaClientes);

                            comboBox.DataSource = tablaClientes;
                            comboBox.DisplayMember = "Name";
                            comboBox.ValueMember = "IdCliente";
                        }
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
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

        private void CargarComboBoxServicios(ComboBox comboBox)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT IdServicio, ServiceName FROM service";
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        using (OleDbDataAdapter adaptador = new OleDbDataAdapter(comando))
                        {
                            DataTable tablaServicios = new DataTable();
                            adaptador.Fill(tablaServicios);

                            comboBox.DataSource = tablaServicios;
                            comboBox.DisplayMember = "ServiceName";
                            comboBox.ValueMember = "IdServicio";
                        }
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los servicios: " + ex.Message);
            }
        }
    }
}
