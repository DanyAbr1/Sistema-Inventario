using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Facturacion
{
    public partial class FrmProductos : Form
    {
        int ID;
        bool UP = false;
        private static FrmProductos frmInstance = null;

        public static FrmProductos Instance()
        {
            if (((frmInstance == null)
                        || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FrmProductos();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        public FrmProductos()
        {
            InitializeComponent();
        }

        void BuscarProveedor(int Id_Proveedor)
        {

            ProductosBl bc = new ProductosBl();
           // bc.BuscarCombo(Id_Proveedor);
            CbxProveedor.DataSource = bc.BuscarCombo(Id_Proveedor);
            CbxProveedor.DisplayMember = "Nombre_Compañia";
        }

        private void LblCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LblMinimixar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            //LblFecha.Text = DateTime.Now.ToLongDateString();
            DoubleBuffered = true;
            Toolstborrar.Enabled = false;

        }
        public void Limpiar(params TextBox[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Clear();

            }

        }
        //public void LimpiarLbl(params Label[] text)
        //{
        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        text[i].Hide();

        //    }

        //}
        public bool Validar()
        {
            bool valor = false;
            if (!string.IsNullOrWhiteSpace(TxtDescPro.Text) || !string.IsNullOrWhiteSpace(TxtPVenta.Text) || !string.IsNullOrWhiteSpace(TxtPCompra.Text) || !string.IsNullOrWhiteSpace(TxtInventario.Text))
            {
                valor = true;
            }
            return valor;
        }

        private void ToolstNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(txtBusqueda, TxtDescPro, TxtPCompra, TxtPVenta, TxtInventario);
            Toolstborrar.Enabled = false;
            CbxProveedor.DataSource = null;
            errorProvider1.Clear();
            TxtDescPro.Focus();

        }

        public void PaginarProductos()
        {

            int fila = dgvProductos.CurrentRow.Index;
            try
            {

                //ProductosBl pr = new ProductosBl();
               // pr.verProveedor();
                //CbxProveedor.DataSource=pr.verProveedor();
                ID = Convert.ToInt32(dgvProductos.Rows[fila].Cells["ID_Producto"].Value);
                TxtDescPro.Text = dgvProductos.Rows[fila].Cells["Descripcion_Producto"].Value.ToString();
                TxtPCompra.Text = dgvProductos.Rows[fila].Cells["Precio_compra"].Value.ToString();
                TxtPVenta.Text = dgvProductos.Rows[fila].Cells["Precio_Venta"].Value.ToString();
                TxtInventario.Text = dgvProductos.Rows[fila].Cells["Inventario"].Value.ToString();
                BuscarProveedor(int.Parse(dgvProductos.Rows[fila].Cells["ID_Proveedor"].Value.ToString()));
                //CbxProveedor.SelectedValue = dgvProductos.Rows[fila].Cells["ID_Proveedor"].Value.ToString();
                //CbxProveedor.DisplayMember="ID_Proveedor";
        

            }


            catch (Exception) { }
        }
        private void ToolstGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (UP == true)
                    {


                        Productos entidad = new Productos();
                        ProductosBl actualizar = new ProductosBl();


                        if (ID < 1)
                        {
                            MessageBox.Show("Debe seleccionar un registro valido antes de actualizar." +
                            " Por favor seleccione un registro en la pestaña de busqueda que desea actualizar "
                              + "y vuelva a intentarlo.", "Error de eliminación",
                              MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            DateTime Fecha = DateTime.Today;
                            entidad.ID_Producto = ID;
                            entidad.Descripcion_Producto =TxtDescPro.Text;
                            entidad.Precio_Compra = double.Parse( TxtPCompra.Text);
                            entidad.Precio_Venta = double.Parse(TxtPVenta.Text);
                            entidad.Inventario =  Convert.ToInt32(TxtInventario.Text);
                            //string fecha= dateTimePicker1.Value.ToString("yyyy-MM-dd");
                            entidad.Fecha_Entrada = Convert.ToDateTime(Fecha.ToString("yyyy-MM-dd"));
                            //entidad.ID_Proveedor = int.Parse(CbxProveedor.SelectedValue.ToString()); 
                          
                            actualizar.ActualizarProductos(entidad);
                            MessageBox.Show("Registro Actualizado.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UP = false;
                            return;
                        }

                    }


                    if (UP == false)
                    {
                        ProductosBl Pro = new ProductosBl();
                        Productos entidad = new Productos();





                        //if (TxtApellido.Text == string.Empty)
                        //    TxtApellido.Text = null;
                        //if (TxtDireccion.Text == string.Empty)
                        //    TxtDireccion.Text = null;
                        //if (TxtTelefono.Text == string.Empty)
                        //    TxtTelefono.Text = null;
                        //if (TxtApellido.Text == string.Empty)
                        //    TxtApellido.Text = null;

                        //if (txtSaldoActual.Text == string.Empty)
                        //    txtSaldoActual.Text = "0.0";

                        //float SaldoIn = float.Parse(txtSaldoInicial.Text);
                        //float SaldoAct = float.Parse(txtSaldoActual.Text);
                        DateTime Fecha = DateTime.Today;
                       // entidad.ID_Producto = ID;
                        entidad.Descripcion_Producto = TxtDescPro.Text;
                        entidad.Precio_Compra = double.Parse(TxtPCompra.Text);
                        entidad.Precio_Venta = double.Parse(TxtPVenta.Text);
                        entidad.Inventario = Convert.ToInt32(TxtInventario.Text);
                        entidad.ID_Proveedor = int.Parse(CbxProveedor.SelectedValue.ToString());
                        entidad.ID_Proveedor = int.Parse(CbxProveedor.SelectedValue.ToString());
                        entidad.Fecha_Entrada = Convert.ToDateTime(Fecha.ToString("yyyy-MM-dd"));

                        Pro.RegProducto(entidad);
                        //  dgvClientes.Update();
                        // LlenarGrid();
                        MessageBox.Show("Registro agregado con exito.", "Agregado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ToolstNuevo.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Hay campos que son obligatorios que se encuentran vacios.", "Error de validación", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    if (string.IsNullOrWhiteSpace(TxtDescPro.Text)) errorProvider1.SetError(TxtDescPro,"Este Campo es requerido");
                    if (string.IsNullOrWhiteSpace(TxtPCompra.Text)) errorProvider1.SetError(TxtPCompra, "Este Campo es requerido");
                    if (string.IsNullOrWhiteSpace(TxtInventario.Text)) errorProvider1.SetError(TxtInventario, "Este Campo es requerido");
                    if (string.IsNullOrWhiteSpace(TxtPVenta.Text)) errorProvider1.SetError(TxtPVenta, "Este Campo es requerido");

                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Toolstborrar.Enabled = true;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            PaginarProductos();
            tabControl1.SelectedIndex = 0;
            txtBusqueda.Clear();
            UP = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CbxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ProductosBl propd = new ProductosBl();
            //CbxProveedor.DataSource = propd.verProveedor();
            //CbxProveedor.DisplayMember = "Nombre_Compañia";
            //CbxProveedor.ValueMember = "ID_Proveedor";
        }

        private void CbxProveedor_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void CbxProveedor_DropDown(object sender, EventArgs e)
        {
            ProductosBl propd = new ProductosBl();
            CbxProveedor.DataSource = propd.verProveedor();
            CbxProveedor.DisplayMember = "Nombre_Compañia";
            CbxProveedor.ValueMember = "ID_Proveedor";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ProductosBl busqueda = new ProductosBl();

            if (rbDesc.Checked == true)
            {
                dgvProductos.DataSource = busqueda.BusquedaProductos(txtBusqueda.Text, "Descripcion_Producto");
            }
            else if (rbID_Producto.Checked == true)
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
