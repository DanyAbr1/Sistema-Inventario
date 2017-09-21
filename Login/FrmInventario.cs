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
using Entidades;

namespace Facturacion
{
    public partial class FrmInventario : Form
    {
        string usu="";
        private static FrmInventario frmInstance = null;

        public static FrmInventario Instance()
        {
            if (((frmInstance == null)
                        || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FrmInventario();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        public FrmInventario()
        {
            InitializeComponent();
        }
        public FrmInventario(string u)
            :this()
        {
            this.usu = u;
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            LblUsuario.Text=usu;

        }

        private void LblCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LblMinimixar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string rdb = "";
            ProductosBl pro = new ProductosBl();
            if (rbSi.Checked == true)
            {
                rdb = "Si";
            }
            if (rbNo.Checked == true)
            {
                rdb = "No";
            }
            dgvInventario.DataSource = pro.buscarInventario(TxtProducto.Text,dtpFrom.Value.ToString("yyyy-MM-dd"),dtpTo.Value.ToString("yyyy-MM-dd"), rdb, cbxProveedor.Text);
            
        }
        public bool Validar()
        {
            bool valor = false;
            if (!string.IsNullOrWhiteSpace(dtpFrom.Text) && !string.IsNullOrWhiteSpace(dtpTo.Text))
            {
                valor = true;
            }
            return valor;
        }

        private void ToolstGuardar_Click(object sender, EventArgs e)
        {
            ProductosBl pro = new ProductosBl();
            Productos entidad = new Productos();
            try
            {
                if (Validar())
                {

                }
                else
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cbxProveedor_DropDown(object sender, EventArgs e)
        {
            ProductosBl pro = new ProductosBl();
            cbxProveedor.DataSource = pro.verProveedor();
            cbxProveedor.DisplayMember = "Nombre_Compañia";
        }
    }
}
