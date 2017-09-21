using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Facturacion
{
    public partial class FrmBuscarClientes : Form
    {
        public FrmBuscarClientes()
        {
            InitializeComponent();
        }

        private void FrmBuscarClientes_Load(object sender, EventArgs e)
        {
            RdNombre.Checked = true;
        }

        private void LblMinimixar_Click(object sender, EventArgs e)
        {

        }

        private void LblCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public delegate void enviar(DataGridViewRow row);
        public event enviar enviado;
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
           
        }
      
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enviado(dgvClientes.CurrentRow);
            this.Dispose();
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ClientesBl busqueda = new ClientesBl();

            if (RdNombre.Checked == true)
            {
                dgvClientes.DataSource = busqueda.BusquedaClientes(txtBusqueda.Text, "Nombre");
            }
            else if (RdDocumento.Checked == true)
            {
                dgvClientes.DataSource = busqueda.BusquedaClientes(txtBusqueda.Text, "Documento");
            }
            if (txtBusqueda.Text == "")
            {
                dgvClientes.DataSource = null;
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    e.Handled = true;
                    BtnBuscar.PerformClick();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }
}
