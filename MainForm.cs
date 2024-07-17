using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Sistema_de_Facturación_local_MPService
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
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

        private void fiscalCreditButton_Click(object sender, EventArgs e)
        {
            CreditoFiscal myCreditoFiscal = new CreditoFiscal();
            myCreditoFiscal.Show();
            this.Hide();
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            Factura myFactura = new Factura();
            myFactura.Show();
            this.Hide();
        }
    }
}
