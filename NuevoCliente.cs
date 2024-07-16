using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite; // Asegúrate de tener esta biblioteca

namespace Sistema_de_Facturación_local_MPService
{
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear conexión SQLite
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\Asus\\OneDrive\\Datos adjuntos\\Documentos\\Portafolio\\MPS_DB.db;Version=3;"))
                {
                    conn.Open();

                    if(clientTextbox.Text == string.Empty || 
                        addresTextbox.Text == string.Empty || 
                        municipioTextbox.Text == string.Empty || 
                        departmentTexbox.Text == string.Empty ||
                        registerTextbox.Text ==  string.Empty ||
                        giroTextbox.Text == string.Empty ||
                        NITTextbox.Text == string.Empty )
                    {
                        MessageBox.Show("Por favor, llene todos los campos.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Datos guardados correctamente.");
                        string query = "INSERT INTO Clientes (Cliente, Dirección, Municipio, Departamento, Registro, Giro, NIT) VALUES (@Cliente, @Direccion, @Municipio, @Departamento, @Registro, @Giro, @NIT)";
                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            // Añadir parámetros
                            cmd.Parameters.AddWithValue("@Cliente", clientTextbox.Text);
                            cmd.Parameters.AddWithValue("@Direccion", addresTextbox.Text);
                            cmd.Parameters.AddWithValue("@Municipio", municipioTextbox.Text);
                            cmd.Parameters.AddWithValue("@Departamento", departmentTexbox.Text);
                            cmd.Parameters.AddWithValue("@Registro", registerTextbox.Text);
                            cmd.Parameters.AddWithValue("@Giro", giroTextbox.Text);
                            cmd.Parameters.AddWithValue("@NIT", NITTextbox.Text);

                            // Ejecutar comando
                            cmd.ExecuteNonQuery();
                        }
                        clientTextbox.Clear();
                        addresTextbox.Clear();
                        municipioTextbox.Clear();
                        departmentTexbox.Clear();
                        registerTextbox.Clear();
                        giroTextbox.Clear();
                        NITTextbox.Clear();
                    }

                    
                }

                MessageBox.Show("Datos guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario MainForm nuevamente
            MainForm mainForm = new MainForm();
            mainForm.Show();

            // Cerrar el formulario actual
            this.Close();
        }

    }
}
