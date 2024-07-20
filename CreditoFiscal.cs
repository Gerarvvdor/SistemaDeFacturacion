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
            private SQLiteDataAdapter MPProductsAdapter;
            private DataTable ClientNameTable;
            private DataTable ProductsTable;

            public CreditoFiscal()
            {
                InitializeComponent();
                this.WindowState = FormWindowState.Maximized;
                MPdbconnection = new SQLiteConnection("Data Source=C:\\Users\\Asus\\OneDrive\\Datos adjuntos\\Documentos\\Portafolio\\MPS_DB.db;Version=3;");
                this.FormClosing += new FormClosingEventHandler(CreditoFiscal_FormClosing);
            }

            private void CreditoFiscal_Load(object sender, EventArgs e)
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

                    FCclientNameCmbx.SelectedIndexChanged += new EventHandler(labelsAutocomplete);

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
                if (FCclientNameCmbx.SelectedIndex > 0) // Saltar el elemento vacío en el índice 0
                {
                    DataRow selectedRow = ((DataRowView)FCclientNameCmbx.SelectedItem).Row;
                    FCClientLabel.Text = selectedRow["Cliente"].ToString();
                    FCAddressLabel.Text = selectedRow["Dirección"].ToString();
                    FCMunicipioLabel.Text = selectedRow["Municipio"].ToString();
                    FCDepartmentLabell.Text = selectedRow["Departamento"].ToString();
                    FCDateLabel.Text = FCDateTimePicker.Value.ToString("dd/MM/yyyy"); // Suponiendo que deseas la fecha actual
                    FCRegisterClient.Text = selectedRow["Registro"].ToString();
                    FCGiroClient.Text = selectedRow["Giro"].ToString();
                    FCNITclient.Text = selectedRow["NIT"].ToString();
                    FCPayConditions.Text = FCPaymentCondition.Text; // Actualizar con datos apropiados si están disponibles
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
                // Implementación para el evento click de printBillButton
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
                    productsTable.Controls.Clear();
                    productsTable.RowStyles.Clear();
                    productsTable.RowCount = 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al limpiar la tabla de productos: " + ex.Message);
                }
            }

            private void FCaddRowButton_Click(object sender, EventArgs e)
            {
                try
                {
                    if (string.IsNullOrEmpty(cantTextbox.Text) ||
                        string.IsNullOrEmpty(DescripcionTextbox.Text) ||
                        string.IsNullOrEmpty(unitPriceTextbox.Text) ||
                        string.IsNullOrEmpty(VtasNoSujetasTextBox.Text) ||
                        string.IsNullOrEmpty(VentasExentasTextBox.Text))
                    {
                        MessageBox.Show("Por favor, llene todos los campos.");
                        return;
                    }

                    if (!float.TryParse(cantTextbox.Text, out float cantidad) ||
                        !float.TryParse(unitPriceTextbox.Text, out float unitPrice))
                    {
                        MessageBox.Show("Cantidad y Precio Unitario deben ser valores numéricos.");
                        return;
                    }

                    float vGravadas = cantidad * unitPrice;
                    float vtasNoSujetas = float.Parse(VtasNoSujetasTextBox.Text);
                    float vtasExentas = float.Parse(VentasExentasTextBox.Text);

                    using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\Asus\\OneDrive\\Datos adjuntos\\Documentos\\Portafolio\\MPS_DB.db;Version=3;"))
                    {
                        conn.Open();

                        // Insertar el nuevo producto en la base de datos
                        string query = "INSERT INTO Productos (Cantidad, Descripcion, UnitPrice, VtasNoSujetas, VtasExentas, VGravadas) " +
                                       "VALUES (@Cantidad, @Descripcion, @UnitPrice, @VtasNoSujetas, @VtasExentas, @VGravadas)";
                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                            cmd.Parameters.AddWithValue("@Descripcion", DescripcionTextbox.Text);
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
                        if (bigBuyerRadioButton.Checked) { 
                            ivaRetenida = suma * 0.01f;
                        }
                        else
                        {
                            ivaRetenida = 0;
                        }
                        float vtasTotal = subTotal - ivaRetenida;

                        FCsumasLabel.Text = suma.ToString("0.00");
                        FCIVALabel.Text = IVA.ToString("0.00");
                        FCsubTotalLabel.Text = subTotal.ToString("0.00");
                        IVARetenidoLabel.Text = ivaRetenida.ToString("0.00");
                        VtasNoSujetasLabel.Text = vtasNoSujetas.ToString("0.00");
                        VtasExentas.Text = vtasExentas.ToString("0.00");
                        ventasTotalLabel.Text = vtasTotal.ToString("0.00");

                        // Añadir nueva fila al TableLayoutPanel
                        AddRowToProductsTable(cantTextbox.Text, DescripcionTextbox.Text, unitPriceTextbox.Text, VtasNoSujetasTextBox.Text, VentasExentasTextBox.Text, vGravadas);

                        // Limpiar campos de entrada después de agregar
                        cantTextbox.Clear();
                        DescripcionTextbox.Clear();
                        unitPriceTextbox.Clear();
                        VtasNoSujetasTextBox.Clear();
                        VentasExentasTextBox.Clear();
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
                    productsTable.SuspendLayout();

                    // Añadir una nueva fila al final
                    int rowIndex = productsTable.RowCount++;
                    productsTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                    // Crear etiquetas para cada dato
                    Label cantidadLabel = new Label { Text = cantidad, AutoSize = true };
                    Label descripcionLabel = new Label { Text = descripcion, AutoSize = true };
                    Label unitPriceLabel = new Label { Text = unitPrice, AutoSize = true };
                    Label vtasNoSujetasLabel = new Label { Text = vtasNoSujetas, AutoSize = true };
                    Label vtasExentasLabel = new Label { Text = vtasExentas, AutoSize = true };
                    Label vtasGravadasLabel = new Label { Text = vGravadas.ToString("0.00"), AutoSize = true };

                    // Añadir las etiquetas al TableLayoutPanel
                    productsTable.Controls.Add(cantidadLabel, 0, rowIndex);
                    productsTable.Controls.Add(descripcionLabel, 1, rowIndex);
                    productsTable.Controls.Add(unitPriceLabel, 2, rowIndex);
                    productsTable.Controls.Add(vtasNoSujetasLabel, 3, rowIndex);
                    productsTable.Controls.Add(vtasExentasLabel, 4, rowIndex);
                    productsTable.Controls.Add(vtasGravadasLabel, 5, rowIndex);

                    // Asegurar que las etiquetas se posicionen correctamente en la tabla
                    productsTable.SetRow(cantidadLabel, rowIndex);
                    productsTable.SetRow(descripcionLabel, rowIndex);
                    productsTable.SetRow(unitPriceLabel, rowIndex);
                    productsTable.SetRow(vtasNoSujetasLabel, rowIndex);
                    productsTable.SetRow(vtasExentasLabel, rowIndex);
                    productsTable.SetRow(vtasGravadasLabel, rowIndex);

                    // Desplazar la vista hacia la última fila añadida
                    productsTable.ScrollControlIntoView(cantidadLabel);
                }
                finally
                {
                    // Asegurar que se reanude el diseño normal del TableLayoutPanel
                    productsTable.ResumeLayout(true);
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

            private void CreditoFiscal_FormClosing(object sender, FormClosingEventArgs e)
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

        }
    }
