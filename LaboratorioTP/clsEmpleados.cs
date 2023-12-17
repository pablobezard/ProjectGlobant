using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace LaboratorioTP
{
    internal class clsEmpleados
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private Int32 cantidad;

        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=GlobantClientes.mdb";
        private string Tabla = "employees";

        private Int32 idEmp;
        private String eName;
        private String eHome;
        private String ePhone;

        public Int32 IdEmpleado
        {
            get { return idEmp; }
            set { idEmp = value; }
        }

        public String EName
        {
            get { return eName; }
            set { eName = value; }
        }

        public String EHome
        {
            get { return eHome; }
            set { eHome = value; }
        }

        public String EPhone
        {
            get { return ePhone; }
            set { ePhone = value; }

        }

        public void Agregar()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO employees (IdEmpleado, EName, EHome, EPhone) VALUES (?, ?, ?, ?)";

                // Agregar los parámetros a la consulta
                comando.Parameters.AddWithValue("IdEmpleado", idEmp);
                comando.Parameters.AddWithValue("EName", eName);
                comando.Parameters.AddWithValue("EHome", eHome);
                comando.Parameters.AddWithValue("EPhone", ePhone);

                comando.ExecuteNonQuery();

                conexion.Close();
                MessageBox.Show("Los datos se han cargado correctamente.", "Carga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public int ObtenerUltimoIdEmpleado()
        {
            int ultimoIdEmpleado = 0;

            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT MAX(IdEmpleado) FROM employees";

                object resultado = comando.ExecuteScalar();
                if (resultado != DBNull.Value)
                {
                    ultimoIdEmpleado = Convert.ToInt32(resultado);
                }

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return ultimoIdEmpleado;
        }

        public void Listar(DataGridView grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet dataSet = new DataSet();
                adaptador.Fill(dataSet, Tabla);

                grilla.DataSource = dataSet.Tables[Tabla];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Buscar(Int32 idEmpleado)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader dataReader = comando.ExecuteReader();
                idEmp = 0;

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if (dataReader.GetInt32(0) == idEmpleado)
                        {
                            idEmp = dataReader.GetInt32(0);
                            eName = dataReader.GetString(1);
                            eHome = dataReader.GetString(2);
                            ePhone = dataReader.GetString(3);
                        }
                    }
                }

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void GenerarReporteEmpleados()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "employees";

                OleDbDataReader dataReader = comando.ExecuteReader();

                StreamWriter streamWriter = new StreamWriter("ReporteEmpleados.csv", false);
                streamWriter.WriteLine("Listado de empleados\n");
                streamWriter.WriteLine("ID;Nombre;Domicilio;Teléfono");

                cantidad = 0;

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        streamWriter.Write(dataReader.GetInt32(0));
                        streamWriter.Write(";");
                        streamWriter.Write(dataReader.GetString(1));
                        streamWriter.Write(";");
                        streamWriter.Write(dataReader.GetString(2));
                        streamWriter.Write(";");
                        streamWriter.WriteLine(dataReader.GetString(3));
                        cantidad++;
                    }

                    streamWriter.Write("\nCantidad de empleados:;");
                    streamWriter.WriteLine(cantidad);

                    conexion.Close();
                    streamWriter.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
