using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;

namespace LaboratorioTP
{
    public partial class frmGraficoVentas : Form
    {

        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=GlobantClientes.mdb";
        private Chart chartVentas; // Declaración del control chartVentas

        public frmGraficoVentas()
        {
            InitializeComponent();
            InitializeChart(); // Inicialización del control chartVentas
        }

        private void InitializeChart()
        {
            chartVentas = new Chart();
            chartVentas.Size = new Size(400, 300);
            chartVentas.Location = new Point(10, 10);

            // Configurar el gráfico
            chartVentas.Series.Clear();
            chartVentas.ChartAreas.Clear();

            ChartArea area = new ChartArea();
            chartVentas.ChartAreas.Add(area);

            Series series = new Series("Ventas");
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.Date;
            chartVentas.Series.Add(series);

            // Agregar el control chartVentas al formulario
            Controls.Add(chartVentas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Realizar cálculos y mostrar el gráfico en el PictureBox

            // Obtener las fechas mínima y máxima de la tabla de ventas
            DateTime fechaMinima = ObtenerFechaMinima();
            DateTime fechaMaxima = ObtenerFechaMaxima();

            // Calcular el total de ventas por día entre las fechas mínima y máxima
            Dictionary<DateTime, int> ventasPorDia = CalcularVentasPorDia(fechaMinima, fechaMaxima);

            // Mostrar el gráfico en el PictureBox
            MostrarGrafico(ventasPorDia);

            // Mostrar las fechas mínima y máxima en el Label
            lblFechas.Text = "Fecha mínima: " + fechaMinima.ToString("dd/MM/yyyy") +
                " - Fecha máxima: " + fechaMaxima.ToString("dd/MM/yyyy");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Generar previsualización e impresión del gráfico

            // Obtener las fechas mínima y máxima de la tabla de ventas
            DateTime fechaMinima = ObtenerFechaMinima();
            DateTime fechaMaxima = ObtenerFechaMaxima();

            // Calcular el total de ventas por día entre las fechas mínima y máxima
            Dictionary<DateTime, int> ventasPorDia = CalcularVentasPorDia(fechaMinima, fechaMaxima);

            // Generar el reporte con las fechas mínima y máxima
            GenerarReporte(ventasPorDia, fechaMinima, fechaMaxima);
        }

        private DateTime ObtenerFechaMinima()
        {
            DateTime fechaMinima = DateTime.MaxValue;

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT MIN(saleDate) FROM sale";
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        object resultado = comando.ExecuteScalar();
                        if (resultado != DBNull.Value)
                        {
                            fechaMinima = Convert.ToDateTime(resultado);
                        }
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la fecha mínima: " + ex.Message);
            }

            return fechaMinima;
        }

        private DateTime ObtenerFechaMaxima()
        {
            DateTime fechaMaxima = DateTime.MinValue;

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT MAX(saleDate) FROM sale";
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        object resultado = comando.ExecuteScalar();
                        if (resultado != DBNull.Value)
                        {
                            fechaMaxima = Convert.ToDateTime(resultado);
                        }
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la fecha máxima: " + ex.Message);
            }

            return fechaMaxima;
        }

        private Dictionary<DateTime, int> CalcularVentasPorDia(DateTime fechaInicio, DateTime fechaFin)
        {
            Dictionary<DateTime, int> ventasPorDia = new Dictionary<DateTime, int>();

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT saleDate, COUNT(*) AS TotalVentas " +
                        "FROM sale " +
                        "WHERE saleDate >= ? AND saleDate <= ? " +
                        "GROUP BY saleDate";
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("fechaInicio", fechaInicio);
                        comando.Parameters.AddWithValue("fechaFin", fechaFin);

                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime fecha = reader.GetDateTime(0);
                                int totalVentas = reader.GetInt32(1);
                                ventasPorDia.Add(fecha, totalVentas);
                            }
                        }
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular las ventas por día: " + ex.Message);
            }

            return ventasPorDia;
        }

        private void MostrarGrafico(Dictionary<DateTime, int> ventasPorDia)
        {
            // Configurar el gráfico
            chartVentas.Series.Clear();
            chartVentas.ChartAreas.Clear();

            ChartArea area = new ChartArea();
            chartVentas.ChartAreas.Add(area);

            Series series = new Series("Ventas");
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.Date;
            chartVentas.Series.Add(series);

            // Agregar los datos al gráfico
            foreach (KeyValuePair<DateTime, int> venta in ventasPorDia)
            {
                series.Points.AddXY(venta.Key, venta.Value);
            }
        }

        private void GenerarReporte(Dictionary<DateTime, int> ventasPorDia, DateTime fechaMinima, DateTime fechaMaxima)
        {
            // Crear el documento para impresión
            PrintDocument documento = new PrintDocument();
            documento.PrintPage += (sender, e) =>
            {
                // Obtener el gráfico como una imagen
                using (MemoryStream ms = new MemoryStream())
                {
                    chartVentas.SaveImage(ms, ChartImageFormat.Png);
                    Image imagen = Image.FromStream(ms);

                    // Dibujar la imagen en el documento
                    e.Graphics.DrawImage(imagen, e.MarginBounds);
                }

                // Agregar la información de las fechas mínima y máxima
                string textoFechas = "Fecha mínima: " + fechaMinima.ToString("dd/MM/yyyy") +
                    " - Fecha máxima: " + fechaMaxima.ToString("dd/MM/yyyy");
                e.Graphics.DrawString(textoFechas, Font, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom + 10);
            };

            // Mostrar la previsualización e imprimir el documento
            PrintPreviewDialog dialogo = new PrintPreviewDialog();
            dialogo.Document = documento;
            dialogo.ShowDialog();

            // Si se desea imprimir directamente sin previsualización, descomentar la siguiente línea
            //documento.Print();
        }
    }
}
