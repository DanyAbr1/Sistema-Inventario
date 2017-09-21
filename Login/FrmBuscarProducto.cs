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
    public partial class FrmBuscarProducto : Form
    {
        public FrmBuscarProducto()
        {
            InitializeComponent();
        }

        private void FrmBuscarProducto_Load(object sender, EventArgs e)
        {
            RdDesc.Checked = true;
        }

        private void LblCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
        }
        public delegate void enviar(DataGridViewRow row);
        public event enviar Productoenviado;
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Productoenviado(dgvProductos.CurrentRow);
            this.Dispose();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ProductosBl busqueda = new ProductosBl();

            if (RdDesc.Checked == true)
            {
                dgvProductos.DataSource = busqueda.BusquedaProductos(txtBusqueda.Text, "Descripcion_Producto");
            }
            else if (RdID_Producto.Checked == true)
            {
                dgvProductos.DataSource = busqueda.BusquedaProductos(txtBusqueda.Text, "ID_Producto");
            }
            if (txtBusqueda.Text == "")
            {
                dgvProductos.DataSource = null;
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
