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
    public partial class FrmMenuPrincipal : Form
    {
        string usu = "";
        string per= "";
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        public FrmMenuPrincipal(string usu,string permiso)
            : this()
    {
        this.usu = usu;
        this.per = permiso;
    }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                DoubleBuffered = true;
                MenuBL consulta = new MenuBL();
                DataSet DsMenu = new DataSet();
                DataSet DsSubmenu = new DataSet();

                DsMenu = consulta.MostrarMenu();
                DsSubmenu = consulta.MostrarSubMenu();

                CreateMenu(DsMenu.Tables["MenuOpciones"], DsSubmenu.Tables["SubMenuOpciones"]);
                
                MessageBox.Show("Bienvenido: "+usu+"","Bienvenido",MessageBoxButtons.OK,MessageBoxIcon.Information);
                toolStripStatusLabel1.Text = usu.ToString();
               
              
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CreateMenu(DataTable dtMenus, DataTable dtSubMenus)
        {
            foreach (DataRow row in dtMenus.Rows)
            {


                // Creamos el elemento del menu
                ToolStripMenuItem menuItem = new ToolStripMenuItem();

                // Asignamos el texto que se mostrar
                //
              
                    menuItem.Text = Convert.ToString(row["Nombre"]);

                    if (per == "2" || per == "3") { if (menuItem.Text == "Inventario")  menuItem.Visible = false; };
                    ////menuItem.Text = Convert.ToString(row.SetField<toolStripButton2);
                    //var a= row.Table.Columns["Factuacion"].ToString();
                    //toolStripButton2.Enabled=false;

                    // Instalamos el controlador para el evento Click.

                    menuItem.Click += MenuItemOnClick;

            
                    // Obtenemos su identificador.
                   
                    int idMenu = Convert.ToInt32(row["IdMenu"]);

                    // Seleccionamos los registros de la tabla
                    // Submenu que tengan el mismo identificador
                    // del elemento del menu actual.
                    //

                    DataRow[] rows = dtSubMenus.Select("IdMenu = " + idMenu);

                    foreach (DataRow r in rows)
                    {
                        ToolStripMenuItem subItem = new ToolStripMenuItem();
                        subItem.Text = Convert.ToString(r["Nombre"]);

                        // Controlador para el evento Click.
                        if (per == "2" || per =="3")
                        {
                            if (subItem.Text == "Productos")  subItem.Visible = false;
                            if (subItem.Text == "Usuario") subItem.Visible = false;
                            if (subItem.Text == "Proveedores") subItem.Visible = false;
                            
                        }
                        //
                        subItem.Click += MenuItemOnClick;

                        // Anadimos el submenu a su correspondiente menu
                        menuItem.DropDownItems.Add(subItem);
                    }

                    //// Hacer que el formulario sea padre
                    //this.IsMdiContainer = true;

                    ////Crear el objecto de la clase MenuStrip
                    //MenuStrip MnuStrip = new MenuStrip();

                    ////Colocar el control en el formulario
                    //this.Controls.Add(MnuStrip);


                    //Se lo asignamos al control MenuStrip

                    this.menuStrip1.Items.Add(menuItem);

                    //MnuStrip.Items.Add(menuItem);

                    // El formulario determina la propiedad del objeto creado
                    this.MainMenuStrip = menuStrip1;
                }

                //DsMenu.Tables("MenuOpciones").Clear();
                //DsSubMenu.Tables("SubMenuOpciones").Clear();
            }
        
        private void MenuItemOnClick(object sender, EventArgs e)
        {
            // Referenciamos el control que ha desencadenado el evento
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            if (item.ToString() == "Clientes")
            {
                FrmClientes llamar = null;

                llamar = FrmClientes.Instance();
                llamar.MdiParent = this;
                llamar.Show();
            }
            else if (item.ToString() == "Proveedores") {

                FrmProveedores llamar = null;

                llamar =FrmProveedores.Instance();
                llamar.MdiParent = this;
                llamar.Show();
            }
            else if (item.ToString() == "Usuario") {

                FrmUsuario llamar = null;

                llamar = FrmUsuario.Instance();
                llamar.MdiParent = this;
                llamar.Show();

            }
            else if (item.ToString() == "Reportes Clientes") 
            {
                FrmReporteCliente rep = new FrmReporteCliente();
                rep.ShowDialog();
            }
            else if (item.ToString() == "Reportes de Ventas")
            {
                FrmReporteFactura rep = new FrmReporteFactura();
                rep.ShowDialog();
            }
            else if (item.ToString() == "Reportes Productos")
            {
                FrmReporteProducto rep = new FrmReporteProducto();
                rep.ShowDialog();
            }
            else if (item.ToString() == "Reportes Usuario")
            {
                FrmReporteUsuario rep = new FrmReporteUsuario();
                rep.ShowDialog();
            }
            else if (item.ToString() == "Productos")
            {

                FrmProductos llamar = null;

                llamar = FrmProductos.Instance();
                llamar.MdiParent = this;
                llamar.Show();
            }
            else if (item.ToString() == "Facturar")
            {

                FrmFacturar llamar = null;
                string u = toolStripStatusLabel1.Text;
                llamar = FrmFacturar.Instance();
                llamar = new FrmFacturar(u);
                llamar.MdiParent = this;
                llamar.Show();
            }
            else if (item.ToString() == "Inventario ")
            {
                FrmInventario llamar = null;

                llamar = FrmInventario.Instance();
                llamar = new FrmInventario(usu);
                llamar.MdiParent = this;
                llamar.Show();
            }
            else if (item.ToString() == "Ayuda")
            {
                BtnAyuda.PerformClick();
            }
            else if (item.ToString() == "Salir")
            {
                toolStripButton4.PerformClick();
            }
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmClientes llamar = null;

            llamar = FrmClientes.Instance();
            llamar.MdiParent = this;
            llamar.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (per == "2" || per == "3") 
            {
                MessageBox.Show("Uste no tiene permiso para acceder a este Mantenimiento.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmProductos llamar = null;

            llamar = FrmProductos.Instance();
            llamar.MdiParent = this;
            llamar.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (per == "2" || per == "3")
            {
                MessageBox.Show("Uste no tiene permiso para acceder a este Mantenimiento.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmProveedores llamar = null;

            llamar = FrmProveedores.Instance();
            llamar.MdiParent = this;
            llamar.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            toolStripButton4.PerformClick();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               if (MessageBox.Show("Deseas Salir?","Sistema de Facturacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
               {
                   e.Cancel=false;
                   FrmLogin frm = new FrmLogin();
                   frm.Show();
               }
               else
               {
                    e.Cancel=true;
                    return;
               }
            }
            catch (Exception )
            {
                
            }
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\djgre\Documents\Visual Studio 2013\Projects\SistemaTienda\Ayuda\Ayuda.Pdf");
        }

    }
}
