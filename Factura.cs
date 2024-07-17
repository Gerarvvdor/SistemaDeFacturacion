using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Facturación_local_MPService
{
    public partial class Factura : Form
    {
        private SQLiteConnection MPdbconnection;
        private SQLiteDataAdapter MPdataAdapter;
        private DataTable ClientNameTable;
        public Factura()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            MPdbconnection = new SQLiteConnection("Data Source=C:\\Users\\Asus\\OneDrive\\Datos adjuntos\\Documentos\\Portafolio\\MPS_DB.db;Version=3;");

        }

        private void fiscalCreditCancelButton_Click(object sender, EventArgs e)
        {
            MainForm myMainForm = new MainForm();
            myMainForm.Show();
            this.Hide();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            try
            {
                MPdbconnection.Open();

                string query = "SELECT Cliente FROM Clientes";
                MPdataAdapter = new SQLiteDataAdapter(query, MPdbconnection);
                ClientNameTable = new DataTable();

                MPdataAdapter.Fill(ClientNameTable);

                BillClientNameCmbx.DisplayMember = "Cliente";
                BillClientNameCmbx.DataSource = ClientNameTable;
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
    }
}
