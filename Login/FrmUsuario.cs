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
    public partial class FrmUsuario : Form
    {
        bool UP = false;
        int ID;
        private static FrmUsuario frmInstance = null;

        public static FrmUsuario Instance()
        {
            if (((frmInstance == null)
                        || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FrmUsuario();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void ToolstGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (UP == true)
                    {


                        Usuario entidad = new Usuario();
                        UsuarioBl actualizar = new UsuarioBl();

                        if (ID < 1)
                        {
                            MessageBox.Show("Debe seleccionar un registro valido antes de actualizar." +
                            " Por favor seleccione un registro en la pestaña de busqueda que desea actualizar "
                              + "y vuelva a intentarlo.", "Error de eliminación",
                              MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {

                            entidad.ID_Usuario = ID;
                            entidad.NUsuario = TxtUsuario.Text;
                            entidad.Clave = TxtClave.Text;
                            entidad.Nivel = CbxPrivilegio.Text;

                            actualizar.ActualizarUsuario(entidad);
                            MessageBox.Show("Registro Actualizado.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UP = false;
                            return;
                        }

                    }


                    if (UP == false)
                    {
                        UsuarioBl Pro = new UsuarioBl();
                        Usuario entidad = new Usuario();





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
                        entidad.ID_Usuario = ID;
                        entidad.NUsuario = TxtUsuario.Text;
                        entidad.Clave = TxtClave.Text;
                        entidad.Nivel = CbxPrivilegio.Text;
                        entidad.Estado = "Y";

                        Pro.RegUsuario(entidad);
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
                    if (string.IsNullOrWhiteSpace(TxtUsuario.Text)) errorProvider1.SetError(TxtUsuario, "Este Campo es requerido");
                    if (string.IsNullOrWhiteSpace(TxtClave.Text)) errorProvider1.SetError(TxtClave, "Este Campo es requerido");
                    if (string.IsNullOrWhiteSpace(CbxPrivilegio.Text)) errorProvider1.SetError(CbxPrivilegio, "Este Campo es requerido");

                }


            }
            catch (Exception)
            {

                throw;
            }
        }
        public void PaginarClientes()
        {
            int fila = dgvUsuario.CurrentRow.Index;
            try
            {

                ID = Convert.ToInt32(dgvUsuario.Rows[fila].Cells["ID_Usuario"].Value);
                TxtUsuario.Text = dgvUsuario.Rows[fila].Cells["Usuario"].Value.ToString();
                TxtClave.Text = dgvUsuario.Rows[fila].Cells["Clave"].Value.ToString();
                CbxPrivilegio.Text = dgvUsuario.Rows[fila].Cells["Nivel"].Value.ToString();


            }
            catch (Exception) { }
        }
        public void Limpiar(params TextBox[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Clear();

            }

        }
        public bool Validar()
        {
            bool valor = false;
            if (!string.IsNullOrWhiteSpace(TxtUsuario.Text) && !string.IsNullOrWhiteSpace(TxtClave.Text) && !string.IsNullOrWhiteSpace(CbxPrivilegio.Text))
            {
                valor = true;
            }
            return valor;
        }

        private void ToolstNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(TxtUsuario, TxtClave);
            errorProvider1.Clear();
            Toolstborrar.Enabled = false;
            TxtUsuario.Focus();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            //if (e.KeyChar == '\r')
            //{
            //    e.Handled = true;
            //    BtnBuscarPerformClick();
            //}
            if (txtBusqueda.Text == "")
            {
                dgvUsuario.DataSource = null;
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

        private void Toolstborrar_Click(object sender, EventArgs e)
        {
            UsuarioBl Cambiar = new UsuarioBl();
            Usuario entidades = new Usuario();
            try
            {
                if (MessageBox.Show("Esta Seguro de que quiere Borrar este registro?", "Borrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    entidades.ID_Usuario = ID;
                    entidades.Estado = "N";
                    Cambiar.EliminarUsuario(entidades);
                    ToolstNuevo.PerformClick();
                    MessageBox.Show("Registro Borrado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            UsuarioBl busqueda = new UsuarioBl();

            if (rbUsuario.Checked == true)
            {
                dgvUsuario.DataSource = busqueda.BusquedaUsuario(txtBusqueda.Text, "Usuario");
            }
            else if (rbID_Usuario.Checked == true)
            {
                dgvUsuario.DataSource = busqueda.BusquedaUsuario(txtBusqueda.Text, "ID_Usuario");
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

        private void CbxPrivilegio_DropDown(object sender, EventArgs e)
        {
            UsuarioBl Usub = new UsuarioBl();
            Toolstborrar.Enabled = true;
            CbxPrivilegio.DataSource = Usub.ObtenerNivelUsuario();
            CbxPrivilegio.DisplayMember = "Descripcion";
        }
       
    
    }
}
    
  