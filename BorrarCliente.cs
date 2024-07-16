using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Sistema_de_Facturación_local_MPService
{
    public partial class BorrarCliente : Form
    {
        private SQLiteConnection MPdbconnection;
        private SQLiteDataAdapter MPdataAdapter;
        private DataTable MPClientesTable;

        public BorrarCliente()
        {
            InitializeComponent();
            // Inicializa la conexión a la base de datos SQLite
            MPdbconnection = new SQLiteConnection("Data Source=C:\\Users\\Asus\\OneDrive\\Datos adjuntos\\Documentos\\Portafolio\\MPS_DB.db;Version=3;");
        }

        private void BorrarCliente_Load(object sender, EventArgs e)
        {
            loadDatafromDB();
        }

        private void loadDatafromDB()
        {
            try
            {
                MPdbconnection.Open();

                string query = "SELECT * FROM Clientes";
                MPdataAdapter = new SQLiteDataAdapter(query, MPdbconnection);
                MPClientesTable = new DataTable();

                MPdataAdapter.Fill(MPClientesTable);
                dataGridView1.DataSource = MPClientesTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la base de datos: " + ex.Message);
            }
            finally
            {
                MPdbconnection.Close();
            }
        }

        private void BtnEliminarClick_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada para eliminar
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtiene el ID del cliente que se va a eliminar (suponiendo que tienes una columna llamada "ID" en tu DataGridView)
                int idCliente = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                try
                {
                    MPdbconnection.Open();

                    // Ejecuta una consulta DELETE en la base de datos
                    string query = "DELETE FROM Clientes WHERE ID = @ID";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, MPdbconnection))
                    {
                        cmd.Parameters.AddWithValue("@ID", idCliente);
                        cmd.ExecuteNonQuery();
                    }

                    // Elimina la fila del DataTable
                    foreach (DataRow row in MPClientesTable.Rows)
                    {
                        if (Convert.ToInt32(row["ID"]) == idCliente)
                        {
                            row.Delete();
                            break;
                        }
                    }

                    // Actualiza el DataGridView
                    MPClientesTable.AcceptChanges();
                    dataGridView1.DataSource = MPClientesTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                }
                finally
                {
                    MPdbconnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }
    }
}
