using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Sistema_de_Facturación_local_MPService
{
    public partial class Factura : Form
    {
        private SQLiteConnection MPdbconnection;
        private SQLiteDataAdapter MPdataAdapter;
        private SQLiteDataAdapter MPProductsAdapter;
        private DataTable ClientNameTable;
        private DataTable ProductsTable;

        public Factura()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            MPdbconnection = new SQLiteConnection("Data Source=C:\\Users\\Asus\\OneDrive\\Datos adjuntos\\Documentos\\Portafolio\\MPS_DB.db;Version=3;");
            this.FormClosing += new FormClosingEventHandler(Factura_FormClosing);
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            try
            {
                MPdbconnection.Open();

                string query = "SELECT * FROM Clientes";
                string productQuery = "SELECT * FROM Productos";
                MPdataAdapter = new SQLiteDataAdapter(query, MPdbconnection);
                MPProductsAdapter = new SQLiteDataAdapter(productQuery, MPdbconnection);
                ClientNameTable = new DataTable();
                ProductsTable = new DataTable();

                MPdataAdapter.Fill(ClientNameTable);
                MPProductsAdapter.Fill(ProductsTable);

                DataRow emptyRow = ClientNameTable.NewRow();
                emptyRow["Cliente"] = "";
                ClientNameTable.Rows.InsertAt(emptyRow, 0);

                BillClientNameCmbx.DisplayMember = "Cliente";
                BillClientNameCmbx.DataSource = ClientNameTable;

                BillClientLabel.Text = string.Empty;
                BillMunicipioLabel.Text = string.Empty;
                BillDepartmentLabell.Text = string.Empty;
                BillDateLabel.Text = string.Empty;
                BillNITclient.Text = string.Empty;
                BillPayConditions.Text = string.Empty;

                BillClientNameCmbx.SelectedIndexChanged += new EventHandler(labelsAutocomplete);

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
        private void labelsAutocomplete(object sender, EventArgs e)
        {
            // Actualizar el texto de las etiquetas según el elemento seleccionado en el ComboBox
            if (BillClientNameCmbx.SelectedIndex > 0) // Saltar el elemento vacío en el índice 0
            {
                DataRow selectedRow = ((DataRowView)BillClientNameCmbx.SelectedItem).Row;
                BillClientLabel.Text = selectedRow["Cliente"].ToString();
                BillMunicipioLabel.Text = selectedRow["Municipio"].ToString();
                BillDepartmentLabell.Text = selectedRow["Departamento"].ToString();
                BillDateLabel.Text = BillDateTimePicker.Value.ToString("dd/MM/yyyy"); // Suponiendo que deseas la fecha actual
                BillNITclient.Text = selectedRow["NIT"].ToString();
                BillPayConditions.Text = BillPaymentCondition.Text; // Actualizar con datos apropiados si están disponibles
            }
            else
            {
                BillClientLabel.Text = string.Empty;
                BillMunicipioLabel.Text = string.Empty;
                BillDepartmentLabell.Text = string.Empty;
                BillDateLabel.Text = string.Empty;
                BillNITclient.Text = string.Empty;
                BillPayConditions.Text = string.Empty;
            }
        }

        private void fiscalCreditCancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClearProductsTable(); // Limpia la tabla de productos

                // Mostrar el formulario principal
                MainForm myMainForm = new MainForm();
                myMainForm.Show();

                // Ocultar el formulario actual
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar la tabla de productos o al mostrar el formulario principal: " + ex.Message);
            }
        }
        private void ClearProductsTable()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\Asus\\OneDrive\\Datos adjuntos\\Documentos\\Portafolio\\MPS_DB.db;Version=3;"))
                {
                    conn.Open();
                    string query = "DELETE FROM Productos";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                // Limpiar visualmente la tabla de productos
                billTableProducts.Controls.Clear();
                billTableProducts.RowStyles.Clear();
                billTableProducts.RowCount = 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al limpiar la tabla de productos: " + ex.Message);
            }
        }
        private void BilladdRowButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(billCantTextbox.Text) ||
                    string.IsNullOrEmpty(BillDescripcionTextbox.Text) ||
                    string.IsNullOrEmpty(BillUnitPriceTextbox.Text) ||
                    string.IsNullOrEmpty(BillVtasNoSujetasTextBox.Text) ||
                    string.IsNullOrEmpty(BillVentasExentasTextBox.Text))
                {
                    MessageBox.Show("Por favor, llene todos los campos.");
                    return;
                }

                if (!float.TryParse(billCantTextbox.Text, out float cantidad) ||
                    !float.TryParse(BillUnitPriceTextbox.Text, out float unitPrice))
                {
                    MessageBox.Show("Cantidad y Precio Unitario deben ser valores numéricos.");
                    return;
                }

                float vGravadas = cantidad * unitPrice;
                float vtasNoSujetas = float.Parse(BillVtasNoSujetasTextBox.Text);
                float vtasExentas = float.Parse(BillVentasExentasTextBox.Text);

                using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\Asus\\OneDrive\\Datos adjuntos\\Documentos\\Portafolio\\MPS_DB.db;Version=3;"))
                {
                    conn.Open();

                    // Insertar el nuevo producto en la base de datos
                    string query = "INSERT INTO Productos (Cantidad, Descripcion, UnitPrice, VtasNoSujetas, VtasExentas, VGravadas) " +
                                   "VALUES (@Cantidad, @Descripcion, @UnitPrice, @VtasNoSujetas, @VtasExentas, @VGravadas)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@Descripcion", BillDescripcionTextbox.Text);
                        cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        cmd.Parameters.AddWithValue("@VtasNoSujetas", vtasNoSujetas);
                        cmd.Parameters.AddWithValue("@VtasExentas", vtasExentas);
                        cmd.Parameters.AddWithValue("@VGravadas", vGravadas);
                        cmd.ExecuteNonQuery();
                    }

                    // Calcular la suma de VGravadas actualizada
                    float suma = 0;
                    string sumQuery = "SELECT SUM(VGravadas) FROM Productos";
                    using (SQLiteCommand sumCmd = new SQLiteCommand(sumQuery, conn))
                    {
                        object result = sumCmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            suma = Convert.ToSingle(result);
                        }
                    }

                    float IVA = suma * 0.13f;
                    float subTotal = suma + IVA;
                    float ivaRetenida = 0 /*suma * 0.01f*/;
                    if (bigBuyerRadioButton.Checked)
                    {
                        ivaRetenida = suma * 0.01f;
                    }
                    else
                    {
                        ivaRetenida = 0;
                    }
                    float vtasTotal = subTotal - ivaRetenida;

                    BillSumas.Text = suma.ToString("0.00");
                    BillIVARetenido.Text = ivaRetenida.ToString("0.00");
                    BillVtasNoSujetas.Text = vtasNoSujetas.ToString("0.00");
                    BillVtasExentas.Text = vtasExentas.ToString("0.00");
                    BillVtasTotal.Text = vtasTotal.ToString("0.00");

                    // Añadir nueva fila al TableLayoutPanel
                    AddRowToProductsTable(billCantTextbox.Text, BillDescripcionTextbox.Text, BillUnitPriceTextbox.Text, BillVtasNoSujetasTextBox.Text, BillVentasExentasTextBox.Text, vGravadas);

                    // Limpiar campos de entrada después de agregar
                    billCantTextbox.Clear();
                    BillDescripcionTextbox.Clear();
                    BillUnitPriceTextbox.Clear();
                    BillVtasNoSujetasTextBox.Clear();
                    BillVentasExentasTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddRowToProductsTable(string cantidad, string descripcion, string unitPrice, string vtasNoSujetas, string vtasExentas, float vGravadas)
        {
            try
            {
                // Asegurar que el TableLayoutPanel esté visible para la modificación
                billTableProducts.SuspendLayout();

                // Añadir una nueva fila al final
                int rowIndex = billTableProducts.RowCount++;
                billTableProducts.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                // Crear etiquetas para cada dato
                Label cantidadLabel = new Label { Text = cantidad, AutoSize = true };
                Label descripcionLabel = new Label { Text = descripcion, AutoSize = true };
                Label unitPriceLabel = new Label { Text = unitPrice, AutoSize = true };
                Label vtasNoSujetasLabel = new Label { Text = vtasNoSujetas, AutoSize = true };
                Label vtasExentasLabel = new Label { Text = vtasExentas, AutoSize = true };
                Label vtasGravadasLabel = new Label { Text = vGravadas.ToString("0.00"), AutoSize = true };

                // Añadir las etiquetas al TableLayoutPanel
                billTableProducts.Controls.Add(cantidadLabel, 0, rowIndex);
                billTableProducts.Controls.Add(descripcionLabel, 1, rowIndex);
                billTableProducts.Controls.Add(unitPriceLabel, 2, rowIndex);
                billTableProducts.Controls.Add(vtasNoSujetasLabel, 3, rowIndex);
                billTableProducts.Controls.Add(vtasExentasLabel, 4, rowIndex);
                billTableProducts.Controls.Add(vtasGravadasLabel, 5, rowIndex);

                // Asegurar que las etiquetas se posicionen correctamente en la tabla
                billTableProducts.SetRow(cantidadLabel, rowIndex);
                billTableProducts.SetRow(descripcionLabel, rowIndex);
                billTableProducts.SetRow(unitPriceLabel, rowIndex);
                billTableProducts.SetRow(vtasNoSujetasLabel, rowIndex);
                billTableProducts.SetRow(vtasExentasLabel, rowIndex);
                billTableProducts.SetRow(vtasGravadasLabel, rowIndex);

                // Desplazar la vista hacia la última fila añadida
                billTableProducts.ScrollControlIntoView(cantidadLabel);
            }
            finally
            {
                // Asegurar que se reanude el diseño normal del TableLayoutPanel
                billTableProducts.ResumeLayout(true);
            }
        }

        private void BilldeleteRowButton_Click(object sender, EventArgs e)
        {
            // Obtener el número total de filas
            int totalRows = billTableProducts.RowCount;

            // Asegurarse de no eliminar la fila de encabezado
            if (totalRows > 1)
            {
                // Remover la última fila
                int lastRowIndex = totalRows - 1;

                // Remover controles de la última fila
                for (int i = 0; i < billTableProducts.ColumnCount; i++)
                {
                    var control = billTableProducts.GetControlFromPosition(i, lastRowIndex);
                    billTableProducts.Controls.Remove(control);
                }

                // Eliminar la última fila
                billTableProducts.RowStyles.RemoveAt(lastRowIndex);
                billTableProducts.RowCount--;
            }
        }
        

        private void Factura_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\Asus\\OneDrive\\Datos adjuntos\\Documentos\\Portafolio\\MPS_DB.db;Version=3;"))
                {
                    conn.Open();
                    string query = "DELETE FROM Productos";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar la tabla de productos: " + ex.Message);
            }
        }

        private void BillprintBillButton_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
        }

        private void ImprimirCréditoFiscal(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
