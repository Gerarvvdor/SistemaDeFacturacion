using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Facturación_local_MPService
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
