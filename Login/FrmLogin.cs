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
    public partial class FrmLogin : Form
    {
        DatLogin ds = new DatLogin();
        DatLoginTableAdapters.UsuarioTableAdapter consulta = new DatLoginTableAdapters.UsuarioTableAdapter();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                consulta.Fill(ds.Usuario);
                CbxUsuario.DataSource = ds.Usuario;
                CbxUsuario.DisplayMember = "Usuario";
                

       
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            MenuBL ClaseValidaUsuario = new MenuBL();
            
              
                        UsuarioBl Ub= new UsuarioBl();
                        DataTable dtpermiso = Ub.BuscarNivelUsuario(CbxUsuario.Text);
                        string permiso= dtpermiso.Rows[0]["Nivel"].ToString();
                    
            try
            {
                bool valida = false;

                valida = ClaseValidaUsuario.VerificarAcceso(CbxUsuario.Text, TxtClave.Text);

                if (valida)
                {
                   
                    string usu = CbxUsuario.Text;
                    FrmMenuPrincipal menu = new FrmMenuPrincipal(usu, permiso);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Clave de acceso errada", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtClave.Text = "";
                    TxtClave.Focus();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void TxtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    e.Handled = true;
                    BtnAceptar.PerformClick();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CbxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    e.Handled = true;
                    TxtClave.Focus();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtClave_TextChanged(object sender, EventArgs e)
        {

        }

    }

}
