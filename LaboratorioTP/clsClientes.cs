using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace LaboratorioTP
{
    internal class clsClientes
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private Int32 cantidad;

        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=GlobantClientes.mdb";
        private string Tabla = "customers";


        private Int32 idCus;
        private String nam;
        private String hom;
        private String phon;
        private Int32 idSer;

        public Int32 IdCliente
        {
            get { return idCus; }
            set { idCus = value; }
        }

        public String Name
        {
            get { return nam; }
            set { nam = value; }
        }

        public String Home
        {
            get { return hom; }
            set { hom = value; }
        }

        public String Phone
        {
            get { return phon; }
            set { phon = value; }

        }

        public void Agregar()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO customers (IdCliente, Name, Home, Phone) VALUES (?, ?, ?, ?)";

                // Agregar los parámetros a la consulta
                comando.Parameters.AddWithValue("IdCliente", idCus);
                comando.Parameters.AddWithValue("Name", nam);
                comando.Parameters.AddWithValue("Home", hom);
                comando.Parameters.AddWithValue("Phone", phon);

                comando.ExecuteNonQuery();

                conexion.Close();
                MessageBox.Show("Los datos se han cargado correctamente.", "Carga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }




        public int ObtenerUltimoIdCliente()
        {
            int ultimoIdCliente = 0;

            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT MAX(IdCliente) FROM customers";

                object resultado = comando.ExecuteScalar();
                if (resultado != DBNull.Value)
                {
                    ultimoIdCliente = Convert.ToInt32(resultado);
                }

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return ultimoIdCliente;
        }




        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                Grilla.DataSource = DS.Tables[Tabla];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void Buscar(Int32 IdCliente)

        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                idCus = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == IdCliente)
                        {
                            idCus = DR.GetInt32(0);
                            nam = DR.GetString(1);
                            hom = DR.GetString(2);
                            phon = DR.GetString(3);


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

        public void ReporteClientes()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "customers";

                OleDbDataReader DR = comando.ExecuteReader();

                StreamWriter AD = new StreamWriter("ReportesClientes.csv", false);
                AD.WriteLine("Listado de clientes\n");
                AD.WriteLine("ID;Name;Homa;Phone");

                cantidad = 0;

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {

                        AD.Write(DR.GetInt32(0));
                        AD.Write(";");
                        AD.Write(DR.GetString(1));
                        AD.Write(";");
                        AD.Write(DR.GetString(2));
                        AD.Write(";");
                        AD.WriteLine(DR.GetString(3));
                        cantidad++;


                    }
                    AD.Write("\nCantidad de clientes:;");
                    AD.WriteLine(cantidad);



                    conexion.Close();
                    AD.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

    }
}
