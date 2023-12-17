using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LaboratorioTP
{
    internal class clsVentas
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=GlobantClientes.mdb";
        private string tablaVentas = "sale";

        private Int32 idVenta;
        private Int32 idServicio;
        private Int32 idCliente;
        private Int32 idEmpleado;
        private DateTime saleDate;
        private decimal importe;

        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        public Int32 IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        public Int32 IdServicio
        {
            get { return idServicio; }
            set { idServicio = value; }
        }

        public Int32 IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public Int32 IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }

        public DateTime SaleDate
        {
            get { return saleDate; }
            set { saleDate = value; }
        }

        public void AgregarVenta()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO sale (IdServicio, IdCliente, IdEmpleado, saleDate, Importe) VALUES (?, ?, ?, ?, ?)";

                // Agregar los parámetros a la consulta
                comando.Parameters.AddWithValue("IdServicio", idServicio);
                comando.Parameters.AddWithValue("IdCliente", idCliente);
                comando.Parameters.AddWithValue("IdEmpleado", idEmpleado);
                comando.Parameters.AddWithValue("saleDate", saleDate);
                comando.Parameters.AddWithValue("Importe", importe);

                comando.ExecuteNonQuery();

                MessageBox.Show("Venta agregada exitosamente.");

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Asegure instanciar cada Instancia");
            }
        }

        public void ListarVentas(DataGridView grilla)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM sale";

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, tablaVentas);

                grilla.DataSource = DS.Tables[tablaVentas];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se listaron ventas");
            }
        }

        public DataTable ConsultarVentasPorEmpleadoYFecha(Int32 idEmpleado, DateTime fecha)
        {
            DataTable tablaResultado = new DataTable();

            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT sale.saleDate, service.ServiceName, customers.Name AS ClientName, employees.EName, sale.Importe " +
                                      "FROM (((sale " +
                                      "INNER JOIN employees ON sale.IdEmpleado = employees.IdEmpleado) " +
                                      "INNER JOIN customers ON sale.IdCliente = customers.IdCliente) " +
                                      "INNER JOIN service ON sale.IdServicio = service.IdServicio) " +
                                      "WHERE sale.IdEmpleado = ? AND sale.saleDate >= ? AND sale.saleDate < ?";

                // Agregar los parámetros a la consulta
                comando.Parameters.AddWithValue("IdEmpleado", idEmpleado);
                comando.Parameters.AddWithValue("saleDate", fecha.Date);
                comando.Parameters.AddWithValue("saleDate2", fecha.Date.AddDays(1));

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaResultado);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar ventas");
            }
            finally
            {
                conexion.Close();
            }

            return tablaResultado;
        }
    }
}
