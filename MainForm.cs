using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Sistema_de_Facturación_local_MPService
{
    public partial class MainForm : Form
    {
        private SQLiteConnection MPdbconnection;
        private SQLiteDataAdapter MPdataAdapter;
        private DataTable ClientNameTable;

        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            MPdbconnection = new SQLiteConnection("Data Source=C:\\Users\\Asus\\OneDrive\\Datos adjuntos\\Documentos\\Portafolio\\MPS_DB.db;Version=3;");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        
            
            try
            {
                MPdbconnection.Open();

                string query = "SELECT Cliente FROM Clientes";
                MPdataAdapter = new SQLiteDataAdapter(query, MPdbconnection);
                ClientNameTable = new DataTable();

                MPdataAdapter.Fill(ClientNameTable);

                clientNameCmbx.DisplayMember = "Cliente"; 
                clientNameCmbx.DataSource = ClientNameTable;
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

        private void newClientButton_Click(object sender, EventArgs e)
        {
            AddClientForm myNuevoCliente = new AddClientForm();
            myNuevoCliente.Show();
            this.Hide();
        }

        private void deleteClientButtoon_Click(object sender, EventArgs e)
        {
            BorrarCliente myborrarCliente = new BorrarCliente();
            myborrarCliente.Show();
            this.Hide();
        }
    }
}
