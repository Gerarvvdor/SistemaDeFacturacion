using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Sistema_de_Facturación_local_MPService
{
    public partial class CreditoFiscal : Form
    {
        private SQLiteConnection MPdbconnection;
        private SQLiteDataAdapter MPdataAdapter;
        private DataTable ClientNameTable;

        public CreditoFiscal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            MPdbconnection = new SQLiteConnection("Data Source=C:\\Users\\Asus\\OneDrive\\Datos adjuntos\\Documentos\\Portafolio\\MPS_DB.db;Version=3;");
        }

        private void CreditoFiscal_Load(object sender, EventArgs e)
        {
            try
            {
                MPdbconnection.Open();

                string query = "SELECT * FROM Clientes";
                MPdataAdapter = new SQLiteDataAdapter(query, MPdbconnection);
                ClientNameTable = new DataTable();

                MPdataAdapter.Fill(ClientNameTable);

                DataRow emptyRow = ClientNameTable.NewRow();
                emptyRow["Cliente"] = "";
                ClientNameTable.Rows.InsertAt(emptyRow, 0);

                FCclientNameCmbx.DisplayMember = "Cliente";
                FCclientNameCmbx.DataSource = ClientNameTable;

                FCClientLabel.Text = string.Empty;
                FCAddressLabel.Text = string.Empty;
                FCMunicipioLabel.Text = string.Empty;
                FCDepartmentLabell.Text = string.Empty;
                FCDateLabel.Text = string.Empty;
                FCRegisterClient.Text = string.Empty;
                FCGiroClient.Text = string.Empty;
                FCNITclient.Text = string.Empty;
                FCPayConditions.Text = string.Empty;

                FCclientNameCmbx.SelectedIndexChanged += new EventHandler(FCclientNameCmbx_SelectedIndexChanged);
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

        private void FCclientNameCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the label text to the selected item in the ComboBox
            if (FCclientNameCmbx.SelectedIndex > 0) // Skip the empty item at index 0
            {
                DataRow selectedRow = ((DataRowView)FCclientNameCmbx.SelectedItem).Row;
                FCClientLabel.Text = selectedRow["Cliente"].ToString();
                FCAddressLabel.Text = selectedRow["Dirección"].ToString();
                FCMunicipioLabel.Text = selectedRow["Municipio"].ToString();
                FCDepartmentLabell.Text = selectedRow["Departamento"].ToString();
                FCDateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Assuming you want the current date
                FCRegisterClient.Text = selectedRow["Registro"].ToString();
                FCGiroClient.Text = selectedRow["Giro"].ToString();
                FCNITclient.Text = selectedRow["NIT"].ToString();
                FCPayConditions.Text = "Some default pay condition"; // Update with appropriate data if available
            }
            else
            {
                FCClientLabel.Text = string.Empty;
                FCAddressLabel.Text = string.Empty;
                FCMunicipioLabel.Text = string.Empty;
                FCDepartmentLabell.Text = string.Empty;
                FCDateLabel.Text = string.Empty;
                FCRegisterClient.Text = string.Empty;
                FCGiroClient.Text = string.Empty;
                FCNITclient.Text = string.Empty;
                FCPayConditions.Text = string.Empty;
            }
        }

        private void printBillButton_Click(object sender, EventArgs e)
        {
            // Implementation for printBillButton click event
        }

        private void fiscalCreditCancelButton_Click(object sender, EventArgs e)
        {
            MainForm myMainForm = new MainForm();
            myMainForm.Show();
            this.Hide();
        }

        private void FCaddRowButton_Click(object sender, EventArgs e)
        {
            // Crear una nueva fila justo debajo de la primera fila existente
            int newRow = productsTable.RowCount;

            // Añadir una nueva fila justo debajo de la primera fila
            productsTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            productsTable.RowCount++;

            // Añadir controles a la nueva fila (ejemplo con TextBox en cada columna)
            for (int i = 0; i < productsTable.ColumnCount; i++)
            {
                TextBox newTextBox = new TextBox();
                productsTable.Controls.Add(newTextBox, i, newRow);
            }
        }

        private void FCdeleteRowButton_Click(object sender, EventArgs e)
        {
            // Obtener el número total de filas
            int totalRows = productsTable.RowCount;

            // Asegurarse de no eliminar la fila de encabezado
            if (totalRows > 1)
            {
                // Remover la última fila
                int lastRowIndex = totalRows - 1;

                // Remover controles de la última fila
                for (int i = 0; i < productsTable.ColumnCount; i++)
                {
                    var control = productsTable.GetControlFromPosition(i, lastRowIndex);
                    productsTable.Controls.Remove(control);
                }

                // Eliminar la última fila
                productsTable.RowStyles.RemoveAt(lastRowIndex);
                productsTable.RowCount--;
            }
        }
    }
}
