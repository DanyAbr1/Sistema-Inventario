using Logica;
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

namespace Facturacion
{
    public partial class FrmClientes : Form
    {
        int ID;
        bool UP = false;
        private static FrmClientes frmInstance = null;

        public static FrmClientes Instance()
        {
            if (((frmInstance == null)
                        || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FrmClientes();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void LblMinimixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LblCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void PaginarClientes()
        {
            int fila = dgvClientes.CurrentRow.Index;
            try
            {
                
                ID = Convert.ToInt32(dgvClientes.Rows[fila].Cells["ID_Cliente"].Value);
                TxtNombre.Text = dgvClientes.Rows[fila].Cells["Nombre"].Value.ToString();
                TxtApellido.Text = dgvClientes.Rows[fila].Cells["Apellido"].Value.ToString();
                TxtDireccion.Text = dgvClientes.Rows[fila].Cells["Direccion"].Value.ToString();
                TxtTelefono.Text = dgvClientes.Rows[fila].Cells["Telefono"].Value.ToString();
                TxtDocumento.Text = dgvClientes.Rows[fila].Cells["Documento"].Value.ToString();
               
            }


            catch (Exception) { }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (UP == true)
                    {


                        Clientes entidad = new Clientes();
                        ClientesBl actualizar = new ClientesBl();

                        if (ID < 1)
                        {
                            MessageBox.Show("Debe seleccionar un registro valido antes de actualizar." +
                            " Por favor seleccione un registro en la pestaña de busqueda que desea actualizar "
                              + "y vuelva a intentarlo.", "Error de eliminación",
                              MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {

                            entidad.ID_Cliente = ID;
                            entidad.Nombre = TxtNombre.Text;
                            entidad.Apellido = TxtApellido.Text;
                            entidad.Direccion = TxtDireccion.Text;
                            entidad.Documento = TxtDocumento.Text;
                            entidad.Telefono = TxtTelefono.Text;


                            actualizar.ActualizarClientes(entidad);
                            MessageBox.Show("Registro Actualizado.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UP = false;
                            return;
                        }

                    }


                    if (UP == false)
                    {
                        ClientesBl Pro = new ClientesBl();
                        Clientes entidad = new Clientes();





                        if (TxtApellido.Text == string.Empty)
                            TxtApellido.Text = null;
                        if (TxtDireccion.Text == string.Empty)
                            TxtDireccion.Text = null;
                        if (TxtTelefono.Text == string.Empty)
                            TxtTelefono.Text = null;
                        //if (TxtApellido.Text == string.Empty)
                        //    TxtApellido.Text = null;

                        //if (txtSaldoActual.Text == string.Empty)
                        //    txtSaldoActual.Text = "0.0";

                        //float SaldoIn = float.Parse(txtSaldoInicial.Text);
                        //float SaldoAct = float.Parse(txtSaldoActual.Text);

                        // entidad.ID_Producto = ID;
                        entidad.Nombre = TxtNombre.Text;
                        entidad.Apellido = TxtApellido.Text;
                        entidad.Direccion = TxtDireccion.Text;
                        entidad.Documento = TxtDocumento.Text;
                        entidad.Telefono = TxtTelefono.Text;
                        entidad.Estado = "Y";

                        Pro.RegClientes(entidad);
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
                    if (string.IsNullOrWhiteSpace(TxtNombre.Text)) errorProvider1.SetError(TxtNombre, "Este Campo es requerido");
                    if (string.IsNullOrWhiteSpace(TxtDocumento.Text)) errorProvider1.SetError(TxtDocumento, "Este Campo es requerido");
                    
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

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PaginarClientes();
            tabControl1.SelectedIndex = 0;
            txtBusqueda.Clear();
            UP = true;
            Toolstborrar.Enabled = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Limpiar(TxtNombre, TxtApellido, TxtDireccion, TxtTelefono, TxtDocumento);
            errorProvider1.Clear();
            Toolstborrar.Enabled = false;
            TxtNombre.Focus();
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
            

        private void Toolstborrar_Click(object sender, EventArgs e)
        {
            ClientesBl Cambiar = new ClientesBl();
            Clientes entidades = new Clientes();
            try
            {
                if (MessageBox.Show("Esta Seguro de que quiere Borrar este registro?", "Borrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    entidades.ID_Cliente = ID;
                    entidades.Estado = "N";
                    Cambiar.EliminarClientes(entidades);
                    ToolstNuevo.PerformClick();
                    MessageBox.Show("Registro Borrado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Validar()
        {
            bool valor = false;
            if (!string.IsNullOrWhiteSpace(TxtNombre.Text) && !string.IsNullOrWhiteSpace(TxtDocumento.Text) )
            {
                valor = true;
            }
            return valor;
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
     
            Toolstborrar.Enabled = false;
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientesBl busqueda = new ClientesBl();

            if (rbNombre.Checked == true)
            {
                dgvClientes.DataSource = busqueda.BusquedaClientes(txtBusqueda.Text, "Nombre");
            }
            else if (rbDocumento.Checked == true)
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
