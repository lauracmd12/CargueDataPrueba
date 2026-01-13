using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargarData
{
    public partial class Form1 : Form
    {
        string[] contenidoArchivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string Documento = txtBuscarDocumento.Text;
            //string[] documentosList = Documento.Split(';');
            //lblResultadoConsulta.Text = documentosList.ToString();

            dataClientes.DataSource = BuscarDocumento(Documento);
        }

        private void btnSeleccionarArchivo_Click_1(object sender, EventArgs e)
        {
            lblEstado.Text = "Leyendo archivo....";
            lblEstado.Visible = true;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "D:\\CARPETA DE  DESCARGAS";    // Directorio inicial
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";  // Filtro de archivos
            openFileDialog1.FilterIndex = 1;  // Primera opción seleccionada
            openFileDialog1.RestoreDirectory = true;
            string archivoSeleccionado = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                archivoSeleccionado = openFileDialog1.FileName;
            }
            lblArchivoCargar.Text = "Archivo: " + archivoSeleccionado.Replace("C:\\Users\\User\\Downloads\\", "");

            contenidoArchivo = System.IO.File.ReadAllLines(archivoSeleccionado);
            btnCargarDatos.Visible = true;
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            if (ListaMeses.SelectedItems.Count > 0)
            {
                string Mes = ListaMeses.SelectedItem.ToString();
                DialogResult result = MessageBox.Show("se eliminara la información del MES: "+Mes+", desea continuar?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    lblEstado.Text = "Inicia eliminado de informacion....";
                    lblEstado.Refresh();
                    Application.DoEvents();
                    EliminaDataMes(Mes);
                    lblEstado.Text = "Se elimina informacion, Empieza procesado del archivo....";
                    lblEstado.Refresh();
                    Application.DoEvents();
                    List<string> ListaDatos = contenidoArchivo.ToList();
                    ListaDatos.RemoveAt(0);
                    contenidoArchivo = ListaDatos.ToArray();
                    int CantidadTotal = contenidoArchivo.Count();
                    DataTable tablaCargar = new DataTable();
                    tablaCargar.Columns.Add("TIPO_DOC", typeof(string));
                    tablaCargar.Columns.Add("NUM_DOC", typeof(string));
                    tablaCargar.Columns.Add("P_APELLIDO", typeof(string));
                    tablaCargar.Columns.Add("S_APELLIDO", typeof(string));
                    tablaCargar.Columns.Add("P_NOMBRE", typeof(string));
                    tablaCargar.Columns.Add("S_NOMBRE", typeof(string));
                    tablaCargar.Columns.Add("F_NAC", typeof(string));
                    tablaCargar.Columns.Add("SEXO", typeof(string));
                    tablaCargar.Columns.Add("TIPO_AFILIADO", typeof(string));
                    tablaCargar.Columns.Add("ESTADO", typeof(string));
                    tablaCargar.Columns.Add("DEPARTAMENTO", typeof(string));
                    tablaCargar.Columns.Add("MUNICIPIO", typeof(string));
                    tablaCargar.Columns.Add("F_INICIO", typeof(string));
                    tablaCargar.Columns.Add("DIRECCION", typeof(string));
                    tablaCargar.Columns.Add("TELEFONO", typeof(string));
                    tablaCargar.Columns.Add("CELULAR", typeof(string));
                    tablaCargar.Columns.Add("CORREO", typeof(string));
                    tablaCargar.Columns.Add("ZONA", typeof(string));
                    tablaCargar.Columns.Add("PRESTADOR_MED", typeof(string));
                    tablaCargar.Columns.Add("REGIMEN", typeof(string));
                    int Conteo = 0;
                    foreach (string linea in contenidoArchivo)
                    {
                        try
                        {
                            Conteo++;
                            var columnas = linea.Split(';');
                            DataRow Registro = tablaCargar.NewRow();
                            Registro["TIPO_DOC"] = columnas[0].Replace("\"", "");
                            Registro["NUM_DOC"] = columnas[1].Replace("\"", "");
                            Registro["P_APELLIDO"] = columnas[2].Replace("\"", "");
                            Registro["S_APELLIDO"] = columnas[3].Replace("\"", "");
                            Registro["P_NOMBRE"] = columnas[4].Replace("\"", "");
                            Registro["S_NOMBRE"] = columnas[5].Replace("\"", "");
                            Registro["F_NAC"] = columnas[6].Replace("\"", "");
                            Registro["SEXO"] = columnas[7].Replace("\"", "");
                            Registro["TIPO_AFILIADO"] = columnas[8].Replace("\"", "");
                            Registro["ESTADO"] = columnas[9].Replace("\"", "");
                            Registro["DEPARTAMENTO"] = columnas[10].Replace("\"", "");
                            Registro["MUNICIPIO"] = columnas[11].Replace("\"", "");
                            Registro["F_INICIO"] = columnas[12].Replace("\"", "");
                            Registro["DIRECCION"] = columnas[13].Replace("\"", "");
                            Registro["TELEFONO"] = columnas[14].Replace("\"", "");
                            Registro["CELULAR"] = columnas[15].Replace("\"", "");
                            Registro["CORREO"] = columnas[16].Replace("\"", "");
                            Registro["ZONA"] = columnas[17].Replace("\"", "");
                            Registro["PRESTADOR_MED"] = columnas[18].Replace("\"", "");
                            Registro["REGIMEN"] = columnas[19].Replace("\"", "");
                            tablaCargar.Rows.Add(Registro);
                            if (tablaCargar.Rows.Count == 100000 || Conteo == CantidadTotal)
                            {
                                InsertarData(tablaCargar, CantidadTotal, Conteo);
                                tablaCargar.Clear();
                            }
                        }
                        catch (Exception ex)
                        {
                            lblEstado.Text = "Se genero un error en la insercion registros procesados: " + Conteo + "........ Error: " + ex.Message;
                            lblEstado.Refresh();
                            Application.DoEvents();
                        }
                    }
                    lblEstado.Text = "inicia actualizacion del mes ";
                    lblEstado.Refresh();
                    Application.DoEvents();
                    ActualizarData(Mes);

                }
                else
                {
                    // El usuario seleccionó "No", cancelar la operación
                    MessageBox.Show("La operación de eliminación ha sido cancelada.", "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione el mes a actualizar");
            }
            lblEstado.Text = "ESTADO: finaliza proceso archivo cargado exitosamente";
            lblEstado.Refresh();
            Application.DoEvents();
        }

        private void InsertarData(DataTable tabla, int cantidadTotal, int conteo)
        {
            string connectionString = "Data Source=.;Initial Catalog=Regimen;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                    {
                        bulkCopy.DestinationTableName = "BaseEPS";
                        bulkCopy.ColumnMappings.Add("TIPO_DOC", "TIPO_DOC");
                        bulkCopy.ColumnMappings.Add("NUM_DOC", "NUM_DOC");
                        bulkCopy.ColumnMappings.Add("P_APELLIDO", "P_APELLIDO");
                        bulkCopy.ColumnMappings.Add("S_APELLIDO", "S_APELLIDO");
                        bulkCopy.ColumnMappings.Add("P_NOMBRE", "P_NOMBRE");
                        bulkCopy.ColumnMappings.Add("S_NOMBRE", "S_NOMBRE");
                        bulkCopy.ColumnMappings.Add("F_NAC", "F_NAC");
                        bulkCopy.ColumnMappings.Add("SEXO", "SEXO");
                        bulkCopy.ColumnMappings.Add("TIPO_AFILIADO", "TIPO_AFILIADO");
                        bulkCopy.ColumnMappings.Add("ESTADO", "ESTADO");
                        bulkCopy.ColumnMappings.Add("DEPARTAMENTO", "DEPARTAMENTO");
                        bulkCopy.ColumnMappings.Add("MUNICIPIO", "MUNICIPIO");
                        bulkCopy.ColumnMappings.Add("F_INICIO", "F_INICIO");
                        bulkCopy.ColumnMappings.Add("DIRECCION", "DIRECCION");
                        bulkCopy.ColumnMappings.Add("TELEFONO", "TELEFONO");
                        bulkCopy.ColumnMappings.Add("CELULAR", "CELULAR");
                        bulkCopy.ColumnMappings.Add("CORREO", "CORREO");
                        bulkCopy.ColumnMappings.Add("ZONA", "ZONA");
                        bulkCopy.ColumnMappings.Add("PRESTADOR_MED", "PRESTADOR_MED");
                        bulkCopy.ColumnMappings.Add("REGIMEN", "REGIMEN");
                        bulkCopy.BulkCopyTimeout = 4200;
                        bulkCopy.WriteToServer(tabla);
                        lblEstado.Text = "se cargaron exitosamente " + conteo.ToString("N0")
                            + " registros de " + cantidadTotal.ToString("N0");
                        lblEstado.Refresh();
                        Application.DoEvents();
                    }

                    Console.WriteLine("Inserción masiva completada exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error durante la inserción masiva: " + ex.Message);
                }
            }
        }

        private void ActualizarData(string mes)
        {
            
            string connectionString = "Data Source=.;Initial Catalog=Regimen;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("EActualizaDataMes", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Mes", mes);
                        cmd.CommandTimeout = 4200;
                        cmd.ExecuteReader();
                        lblEstado.Text = "finaliza actualizacion del mes ";
                        lblEstado.Refresh();
                        Application.DoEvents();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    lblEstado.Text = "actualizacion del mes Error: " + ex.Message;
                    lblEstado.Refresh();
                    Application.DoEvents();
                }
            }
        }

        private void EliminaDataMes(string mes)
        {
            string connectionString = "Data Source=.;Initial Catalog=Regimen;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("EliminarDataMes", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Mes", mes);
                        cmd.ExecuteReader();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public DataTable BuscarDocumento(string documento) 
        {
            DataTable listaDevuelta = new DataTable();
            string connectionString = "Data Source=.;Initial Catalog=Regimen;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("BuscarDocumento", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Documento", documento);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            listaDevuelta.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return listaDevuelta;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
