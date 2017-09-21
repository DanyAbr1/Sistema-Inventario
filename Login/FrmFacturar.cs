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
using System.Text.RegularExpressions;
using Entidades;

namespace Facturacion
{

    public partial class FrmFacturar : Form
    {
        bool UP = false;
        int ID_Factura=0;
        int Id_Cliente;
        //int Id_Producto;
        int Id_Producto;
        //string Nombre = "";
        bool Validar = false;
        string Usu = "";
        private static FrmFacturar frmInstance = null;

        public static FrmFacturar Instance()
        {
            if (((frmInstance == null)
                        || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FrmFacturar();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        public FrmFacturar()
        {
            InitializeComponent();
        }
        public FrmFacturar(string usu)
        {
            InitializeComponent();
            this.Usu = usu;

        }

        private void FrmFacturar_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            TxtCantidad.Enabled = false;
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text = Usu.ToString();
            //  toolStripStatusLabel4.Text = timer1.Enabled = true;
            
            LbcCantidad.Visible = false;
            LblTotal.Text = "0.00";
            LblPrecio.Visible = false;
            Toolstborrar.Enabled = false;
            LblTotaApagar.Text = "0.00";

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
            toolStripStatusLabel4.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Regex rx = new Regex("^[0-9]+([.|,]+[0-9]+)?$");
            //if (rx.IsMatch(TxtCantidad.Text))



            ProductosBl val = new ProductosBl();

            if (TxtCantidad.Text == "")
            {
                LbcCantidad.Visible = false;
                LblTotal.Text ="0.00";
                //LblTotaApagar.Text = "0.00";
                return;
            }

            try
            {
                bool textval = false;
                ValidarTextboxBl ValiTex = new ValidarTextboxBl();
                textval = ValiTex.SoloNumero(TxtCantidad.Text);
                if (textval)
                {


                    int cant = Convert.ToInt32(TxtCantidad.Text);
                    string pr = TxtProducto.Text;

                    Validar = val.ValidarInvetario(cant, pr);
                    errorProvider1.Clear();
                    if (Validar)
                    {
                        
                        LbcCantidad.Visible = true;
                        LblPrecio.Visible = true;
                        LblTotal.Visible = true;
                        //double can = 0.00;
                        //double it = 0.00;
                        //foreach (DataGridViewRow row in dgvDetalleF.Rows)
                        //{
                           
                        //    can += Convert.ToDouble(row.Cells["Precio_Producto"].Value);
                        //    it += Convert.ToDouble(row.Cells["Generales"].Value);
                        //}
                        //double t = can + it;
                        //LblTotaApagar.Text = t.ToString();
                        LbcCantidad.Text = "Disponible";
                        LbcCantidad.ForeColor = Color.Lime;
                        LblTotal.Text = (float.Parse(TxtCantidad.Text) * float.Parse(LblPrecio.Text)).ToString();
                        //  LblTotal.Text = Convert.ToDouble(LblPrecio.Text*TxtCantidad.Text).ToString();
                    }
                    else
                    {

                        LbcCantidad.Text = "No Disponible";
                        LbcCantidad.ForeColor = Color.Red;
                        LblTotal.Text = "0.00";
                    }
                }
                else
                {
                    //          MessageBox.Show("Solo se permiten numeros","Error de entrada de datos",MessageBoxIcon.Error,MessageBoxButtons.OK.ToString());
                    MessageBox.Show("Solo se permiten numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    TxtCantidad.Clear();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }



        void validar()
        {
            ProductosBl valid = new ProductosBl();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CbxForamPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarClientes frm = new FrmBuscarClientes();
            frm.enviado += new FrmBuscarClientes.enviar(frm_enviado);

            frm.ShowDialog();

        }
        void frm_enviado(DataGridViewRow row)
        {
            TxtCliente.Text = row.Cells["Nombre"].Value.ToString();
            Id_Cliente = int.Parse(row.Cells["ID_Cliente"].Value.ToString());


        }
        void enviarProducto(DataGridViewRow row)
        {
            TxtProducto.Text = row.Cells["Descripcion_Producto"].Value.ToString();
            LblPrecio.Text = row.Cells["Precio_Venta"].Value.ToString();
            Id_Producto = int.Parse(row.Cells["ID_Producto"].Value.ToString());
            TxtCantidad.Enabled = true;

        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto frm = new FrmBuscarProducto();
            frm.Productoenviado += new FrmBuscarProducto.enviar(enviarProducto);
            frm.ShowDialog();
            TxtCantidad.Clear();

        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                    //Validaciones de Los Texbox
            try
            {
                if (string.IsNullOrWhiteSpace(TxtProducto.Text))
                {
                    MessageBox.Show("Debes seleccionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(TxtProducto, "Este Campo es requerido");
                    return;
                }
                if (string.IsNullOrWhiteSpace(TxtCantidad.Text))
                {

                    MessageBox.Show("Debes Indicar la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(TxtCantidad, "Este Campo es requerido");
                    return;
                }
                if (!string.IsNullOrWhiteSpace(TxtCantidad.Text))
                {

                    if (LbcCantidad.Text == "No Disponible")
                    {
                        MessageBox.Show("La cantidad a despachar es mayor que la existencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                }
                FSP_unEvento(TxtProducto.Text, TxtCantidad.Text, LblPrecio.Text, LblTotal.Text, "",Id_Producto);

            }
            catch (Exception)
            {

                throw;
            }

        }
        public void FSP_unEvento(string Producto, string Cant, string Prec, string generales, string i, int IdProd)
        {
            //double itbis = Convert.ToDouble(generales) * 0.18;
            //i = itbis.ToString();
            //// dgvDetalleF.Rows.Add("Por compra de " + Producto, Cant, "1x" + Prec, generales, i,IdProd);

            //if (this.dgvDetalleF.Rows.Count < 1)
            //{
            //    double can = double.Parse(LblTotal.Text);
            //    double it = 0.18;
            //    dgvDetalleF.Rows.Add("Por compra de " + Producto, Cant, Prec, generales, i, IdProd);
            //    LblTotaApagar.Text = (can + it).ToString();
            //    return;
            //}

            //    if (this.dgvDetalleF.RowCount > 0)
            //    {

            //        double can = 0.00;
            //        double it = 0.00;
            //        foreach (DataGridViewRow row in dgvDetalleF.Rows)
            //        {
            //            if (row.Cells["IDProducto"].Value.ToString() == IdProd.ToString() /*&& row.Cells["Fecha"].Value.ToString()==TxtCantidad.Text*/)
            //            {
            //                MessageBox.Show("Ya el producto esta agregado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                return;
            //            }
            //            //if (row.Cells["IDProducto"].Value.ToString() == IdProd.ToString() && row.Cells["Fecha"].Value.ToString() != TxtCantidad.Text)
            //            //{
            //            //    row.Cells["Fecha"].Value = TxtCantidad.Text;
            //            //    row.Cells["Precio_producto"].Value = LblTotal.Text;
            //            //}        
            //            can += Convert.ToDouble(row.Cells["Precio_Producto"].Value);
            //            it += Convert.ToDouble(row.Cells["Generales"].Value);                    
            //        }
            //        dgvDetalleF.Rows.Add("Por compra de " + Producto, Cant, Prec, generales, i, IdProd);
            //        double t = can + it;
            //        LblTotaApagar.Text = t.ToString();
            //    }
            //    if (this.dgvDetalleF.RowCount > 1)
            //    {

            //        double can = 0.00;
            //        double it = 0.00;
            //        foreach (DataGridViewRow row in dgvDetalleF.Rows)
            //        {
            //            if (row.Cells["IDProducto"].Value.ToString() == IdProd.ToString() /*&& row.Cells["Fecha"].Value.ToString() == TxtCantidad.Text*/)
            //            {
            //                MessageBox.Show("Ya el producto esta agregado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                return;
            //            }
            //            //if (row.Cells["IDProducto"].Value.ToString() == IdProd.ToString() && row.Cells["Fecha"].Value.ToString() != TxtCantidad.Text)
            //            //{
            //            //    row.Cells["Fecha"].Value = TxtCantidad.Text;
            //            //    row.Cells["Precio_producto"].Value = LblTotal.Text;
            //            //}
            //            can += Convert.ToDouble(row.Cells["Precio_Producto"].Value);
            //            it += Convert.ToDouble(row.Cells["Generales"].Value);
            //        }
            //        dgvDetalleF.Rows.Add("Por compra de " + Producto, Cant, Prec, generales, i, IdProd);
            //        double t = can + it;
            //        LblTotaApagar.Text = t.ToString();
            //    }
            double itbis = Convert.ToDouble(generales) * 0.18;
            i = itbis.ToString();
            // dgvDetalleF.Rows.Add("Por compra de " + Producto, Cant, "1x" + Prec, generales, i,IdProd);


            if (this.dgvDetalleF.Rows.Count > 0)
            {
                double can = 0.00;
                double it = 0.00;
                foreach (DataGridViewRow row in dgvDetalleF.Rows)
                {
                    if (row.Cells["IDProducto"].Value.ToString() == IdProd.ToString())
                    {
                        MessageBox.Show("Este Producto Ya esta Agregado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    can += Convert.ToDouble(row.Cells["Precio_Producto"].Value);
                    it += Convert.ToDouble(row.Cells["Generales"].Value);
                }
                double t = can + it;
                LblTotaApagar.Text = t.ToString();
            }
            dgvDetalleF.Rows.Add("Por compra de " + Producto, Cant, "1x" + Prec, generales, i, IdProd);
            double can1 = 0.00;
            double it1 = 0.00;
            foreach (DataGridViewRow row in dgvDetalleF.Rows)
            {


                can1 += Convert.ToDouble(row.Cells["Precio_Producto"].Value);
                it1 += Convert.ToDouble(row.Cells["Generales"].Value);
            }
            double t1 = can1 + it1;
            LblTotaApagar.Text = t1.ToString();

            }
        
        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dgvDetalleF.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea quitar este registro de la lista? ", "Quitar Concepto de lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        dgvDetalleF.Rows.RemoveAt(dgvDetalleF.CurrentRow.Index);
                        double can = 0.00;
                        double it = 0.00;
                        foreach (DataGridViewRow row in dgvDetalleF.Rows)
                        {

                            can += Convert.ToDouble(row.Cells["Precio_Producto"].Value);
                            it += Convert.ToDouble(row.Cells["Generales"].Value);
                        }
                        double t = can + it;
                        LblTotaApagar.Text = t.ToString();
                        TxtCantidad.Clear();
                        TxtProducto.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro de la lista", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            catch (Exception)
            {

                throw;
            }
        }

        private void ToolstNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(TxtCliente, TxtProducto, TxtCantidad);
            errorProvider1.Clear();
            Toolstborrar.Enabled = false;
            dgvDetalleF.Rows.Clear();
            LimpiarLbl(LblTotal, LblPrecio);
            LblTotaApagar.Text = "0.00";
            TxtCliente.Focus();
        }
        public void Limpiar(params TextBox[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Clear();

            }

        }
        public void LimpiarLbl(params Label[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Hide();

            }

        }

        private void ToolstGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarT())
                {
                    if (UP == true)
                    {
                        Factura entidad = new Factura();
                        FacturaBl actualizar = new FacturaBl();

                   

                    }


                    if (UP == false)
                    {
                        FacturaBl fac = new FacturaBl();
                        Factura entidad = new Factura();
                        DetalleFacturaBl dtf = new DetalleFacturaBl();
                        DetalleFacturas entidf = new DetalleFacturas();
                        ProductosBl pb = new ProductosBl();
                        Productos pd = new Productos();

                        // entidad.ID_Producto = ID;
                        entidad.Fecha = Convert.ToDateTime(toolStripStatusLabel1.Text);
                        entidad.Forma_Pago = CbxForamPago.Text;
                        entidad.Vendedor = Usu.ToString();
                        entidad.Total = double.Parse(LblTotaApagar.Text);
                        entidad.Id_Cliente = Id_Cliente;
                       
                        fac.RegFactura(entidad);
                        foreach (DataGridViewRow row in dgvDetalleF.Rows)
                        {

                            entidf.Monto = Convert.ToDouble(row.Cells["Precio_Producto"].Value);
                            entidf.Cantidad = Convert.ToInt16(row.Cells["Fecha"].Value);
                            entidf.Itbis = Convert.ToDouble(row.Cells["Generales"].Value);
                            entidf.ID_Producto = Convert.ToInt16(row.Cells["IDProducto"].Value);

                            var dt = fac.ObtenerIDFactura(Id_Cliente,Convert.ToDouble(LblTotaApagar.Text));
                            var Id1= dt.Rows[0]["ID_Factura"];
                            entidf.ID_Factura = Convert.ToInt16(Id1);
                            ID_Factura = Convert.ToInt16(Id1);

                            pd.ID_Producto = Convert.ToInt16(row.Cells["IDProducto"].Value); ;
                            pd.Inventario = Convert.ToInt16(row.Cells["Fecha"].Value);
                            pb.ActualizarInventario(pd);
                            dtf.RegDetalleFactura(entidf);
                            
                        }
                        //  dgvClientes.Update();
                        // LlenarGrid();
                        MessageBox.Show("Registro agregado con exito.", "Agregado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ToolstNuevo.PerformClick();
                        if (MessageBox.Show("¿Desea imprimir la factura? ", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            tsImprimir.PerformClick();
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hay campos que son obligatorios que se encuentran vacios.", "Error de validación", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    if (string.IsNullOrWhiteSpace(TxtProducto.Text)) errorProvider1.SetError(TxtProducto, "Este Campo es requerido");
                    if (string.IsNullOrWhiteSpace(TxtCliente.Text)) errorProvider1.SetError(TxtCliente, "Este Campo es requerido");
                    if (string.IsNullOrWhiteSpace(CbxForamPago.Text)) errorProvider1.SetError(CbxForamPago, "Este Campo es requerido");
                   
                  
                }


            }
            catch (Exception)
            {

                throw;
            }
        
        }
        public bool ValidarT()
        {
            bool valor = false;
            if (!string.IsNullOrWhiteSpace(TxtCliente.Text) && !string.IsNullOrWhiteSpace(TxtProducto.Text))
            {
                valor = true;
            }
            return valor;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDetalleF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // dgvDetalleF.EditMode = dgvDetalleF.CurrentRow.Cells["Fecha"];
            
        }

        private void dgvDetalleF_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgvDetalleF.CurrentRow.Cells["Fecha"].ReadOnly = false;   
            dgvDetalleF.Columns[1].ReadOnly = false;
        }

        private void dgvDetalleF_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                                                                                            
        }

        private void tsImprimir_Click(object sender, EventArgs e)
        {
            if (ID_Factura == 0)
            {
                MessageBox.Show("Debe Procesar una factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FrmImprimirFactura frm = new FrmImprimirFactura(ID_Factura);
            frm.ShowDialog();
        }

        private void CbxForamPago_DropDown(object sender, EventArgs e)
        {
            FormaPagoBl pago = new FormaPagoBl();
            CbxForamPago.DataSource = pago.buscarFormaPago();
            CbxForamPago.DisplayMember = "Descripcion";
        }

        private void tsbConfi_Click(object sender, EventArgs e)
        {
            //double descuento = 0.00;
            //double impuestoItbis = 0.00;
        }
    }
}




