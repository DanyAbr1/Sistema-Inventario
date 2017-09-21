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

    public partial class FrmProveedores : Form
    {
        bool UP = false;
        int ID;
        private static FrmProveedores frmInstance = null;

        public static FrmProveedores Instance()
        {
            if (((frmInstance == null)
                        || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FrmProveedores();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            Toolstborrar.Enabled = false;
        }

        private void ToolstGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (Validar())
                {
                    if (UP == true)
                    {


                        Proveedor entidad = new Proveedor();
                        ProveedorBl actualizar = new ProveedorBl();

                        if (ID < 1)
                        {
                            MessageBox.Show("Debe seleccionar un registro valido antes de actualizar." +
                            " Por favor seleccione un registro en la pestaña de busqueda que desea actualizar "
                              + "y vuelva a intentarlo.", "Error de eliminación",
                              MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {

                            entidad.ID_Proveedor = ID;
                            entidad.Nombre_Compañia = TxtCompany.Text;
                            entidad.Contacto = TxtContacto.Text;
                            entidad.Direccion = TxtDireccion.Text;
                            entidad.Telefono = TxtTelefono.Text;
                            entidad.Correo = TxtCorreo.Text;


                            actualizar.ActualizarProveedor(entidad);
                            MessageBox.Show("Registro Actualizado.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UP = false;
                            return;
                        }

                    }


                    if (UP == false)
                    {
                        ProveedorBl Pro = new ProveedorBl();
                        Proveedor entidad = new Proveedor();





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

                        // entidad.ID_Producto = ID;
                        entidad.Nombre_Compañia = TxtCompany.Text;
                        entidad.Contacto = TxtContacto.Text;
                        entidad.Direccion = TxtDireccion.Text;
                        entidad.Telefono = TxtTelefono.Text;
                        entidad.Correo = TxtCorreo.Text;

                        Pro.RegProveedor(entidad);
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
                    if (string.IsNullOrWhiteSpace(TxtCompany.Text)) errorProvider1.SetError(TxtCompany, "Este Campo es requerido");
                    if (string.IsNullOrWhiteSpace(TxtContacto.Text)) errorProvider1.SetError(TxtContacto, "Este Campo es requerido");
                    if (string.IsNullOrWhiteSpace(TxtTelefono.Text)) errorProvider1.SetError(TxtTelefono, "Este Campo es requerido");
                    if (string.IsNullOrWhiteSpace(TxtDireccion.Text)) errorProvider1.SetError(TxtDireccion, "Este Campo es requerido");

                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LblMinimixar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LblCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolstNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(TxtCompany,TxtContacto,TxtCorreo,TxtDireccion,TxtTelefono,txtBusqueda);
            errorProvider1.Clear();
        }
        public bool Validar()
        {
            bool valor = false;
            if (!string.IsNullOrWhiteSpace(TxtCompany.Text) || !string.IsNullOrWhiteSpace(TxtContacto.Text) || !string.IsNullOrWhiteSpace(TxtTelefono.Text) || !string.IsNullOrWhiteSpace(TxtDireccion.Text))
            {
                valor = true;
            }
            return valor;
        }
        public void Limpiar(params TextBox[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Clear();

            }

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PaginarProveedor();
            tabControl1.SelectedIndex = 0;
            txtBusqueda.Clear();
            UP = true;
        }
        public void PaginarProveedor()
        {
            int fila = dgvProveedor.CurrentRow.Index;
            try
            {

                ID = Convert.ToInt32(dgvProveedor.Rows[fila].Cells["ID_Proveedor"].Value);
                TxtCompany.Text = dgvProveedor.Rows[fila].Cells["Nombre_Compañia"].Value.ToString();
                TxtContacto.Text = dgvProveedor.Rows[fila].Cells["Contacto"].Value.ToString();
                TxtDireccion.Text = dgvProveedor.Rows[fila].Cells["Direccion"].Value.ToString();
                TxtTelefono.Text = dgvProveedor.Rows[fila].Cells["Telefono"].Value.ToString();
                TxtCorreo.Text = dgvProveedor.Rows[fila].Cells["Correo"].Value.ToString();

            }
            catch (Exception) { }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ProveedorBl busqueda = new ProveedorBl();

            if (rbNombre_Compañia.Checked == true)
            {
                dgvProveedor.DataSource = busqueda.BusquedaProveedor(txtBusqueda.Text, "Nombre_Compañia");
            }
            else if (rbContacto.Checked == true)
            {
                dgvProveedor.DataSource = busqueda.BusquedaProveedor(txtBusqueda.Text, "Contacto");
            }
            if (txtBusqueda.Text == "")
            {
                dgvProveedor.DataSource = null;
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
