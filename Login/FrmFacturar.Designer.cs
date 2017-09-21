namespace Facturacion
{
    partial class FrmFacturar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolstNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolstGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Toolstborrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsImprimir = new System.Windows.Forms.ToolStripButton();
            this.LblMinimixar = new System.Windows.Forms.Label();
            this.LblCerrar = new System.Windows.Forms.Label();
            this.StBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.CbxForamPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarProducto = new System.Windows.Forms.Button();
            this.LbcCantidad = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.LblTotaApagar = new System.Windows.Forms.Label();
            this.dgvDetalleF = new System.Windows.Forms.DataGridView();
            this.Descripcion_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Generales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbConfi = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.StBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleF)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(4);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolstNuevo,
            this.toolStripSeparator2,
            this.ToolstGuardar,
            this.toolStripSeparator3,
            this.Toolstborrar,
            this.toolStripSeparator4,
            this.tsImprimir,
            this.tsbConfi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1083, 37);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolstNuevo
            // 
            this.ToolstNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolstNuevo.Image = ((System.Drawing.Image)(resources.GetObject("ToolstNuevo.Image")));
            this.ToolstNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolstNuevo.Name = "ToolstNuevo";
            this.ToolstNuevo.Size = new System.Drawing.Size(34, 34);
            this.ToolstNuevo.Text = "Nuevo";
            this.ToolstNuevo.Click += new System.EventHandler(this.ToolstNuevo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // ToolstGuardar
            // 
            this.ToolstGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolstGuardar.Image = ((System.Drawing.Image)(resources.GetObject("ToolstGuardar.Image")));
            this.ToolstGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolstGuardar.Name = "ToolstGuardar";
            this.ToolstGuardar.Size = new System.Drawing.Size(34, 34);
            this.ToolstGuardar.Text = "Guardar";
            this.ToolstGuardar.Click += new System.EventHandler(this.ToolstGuardar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // Toolstborrar
            // 
            this.Toolstborrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Toolstborrar.Image = ((System.Drawing.Image)(resources.GetObject("Toolstborrar.Image")));
            this.Toolstborrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Toolstborrar.Name = "Toolstborrar";
            this.Toolstborrar.Size = new System.Drawing.Size(34, 34);
            this.Toolstborrar.Text = "Borrar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 37);
            // 
            // tsImprimir
            // 
            this.tsImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsImprimir.Image")));
            this.tsImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsImprimir.Name = "tsImprimir";
            this.tsImprimir.Size = new System.Drawing.Size(34, 34);
            this.tsImprimir.Text = "Imprimir";
            this.tsImprimir.Click += new System.EventHandler(this.tsImprimir_Click);
            // 
            // LblMinimixar
            // 
            this.LblMinimixar.AutoSize = true;
            this.LblMinimixar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblMinimixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblMinimixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinimixar.ForeColor = System.Drawing.Color.White;
            this.LblMinimixar.Location = new System.Drawing.Point(1031, 6);
            this.LblMinimixar.Name = "LblMinimixar";
            this.LblMinimixar.Size = new System.Drawing.Size(19, 25);
            this.LblMinimixar.TabIndex = 19;
            this.LblMinimixar.Text = "-";
            this.LblMinimixar.Click += new System.EventHandler(this.LblMinimixar_Click);
            // 
            // LblCerrar
            // 
            this.LblCerrar.AutoSize = true;
            this.LblCerrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCerrar.ForeColor = System.Drawing.Color.White;
            this.LblCerrar.Location = new System.Drawing.Point(1052, 9);
            this.LblCerrar.Name = "LblCerrar";
            this.LblCerrar.Size = new System.Drawing.Size(20, 20);
            this.LblCerrar.TabIndex = 18;
            this.LblCerrar.Text = "X";
            this.LblCerrar.Click += new System.EventHandler(this.LblCerrar_Click);
            // 
            // StBar
            // 
            this.StBar.BackColor = System.Drawing.Color.SeaGreen;
            this.StBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.StBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2});
            this.StBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StBar.Location = new System.Drawing.Point(0, 37);
            this.StBar.Name = "StBar";
            this.StBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StBar.Size = new System.Drawing.Size(1083, 24);
            this.StBar.TabIndex = 20;
            this.StBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.SeaGreen;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.GhostWhite;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(139, 19);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripStatusLabel4.ForeColor = System.Drawing.Color.GhostWhite;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 19);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.GhostWhite;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(75, 19);
            this.toolStripStatusLabel3.Text = "Vendedor: ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.GhostWhite;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(139, 19);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBuscarCliente);
            this.groupBox1.Controls.Add(this.CbxForamPago);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 65);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.BackgroundImage = global::Facturacion.Properties.Resources.busqueda;
            this.BtnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscarCliente.Location = new System.Drawing.Point(194, 25);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(33, 28);
            this.BtnBuscarCliente.TabIndex = 4;
            this.BtnBuscarCliente.UseVisualStyleBackColor = true;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // CbxForamPago
            // 
            this.CbxForamPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxForamPago.FormattingEnabled = true;
            this.CbxForamPago.Location = new System.Drawing.Point(338, 24);
            this.CbxForamPago.Name = "CbxForamPago";
            this.CbxForamPago.Size = new System.Drawing.Size(121, 21);
            this.CbxForamPago.TabIndex = 3;
            this.CbxForamPago.DropDown += new System.EventHandler(this.CbxForamPago_DropDown);
            this.CbxForamPago.SelectedIndexChanged += new System.EventHandler(this.CbxForamPago_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(253, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Forma de Pago";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(52, 28);
            this.TxtCliente.Multiline = true;
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.ReadOnly = true;
            this.TxtCliente.Size = new System.Drawing.Size(127, 20);
            this.TxtCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnBuscarProducto);
            this.groupBox2.Controls.Add(this.LbcCantidad);
            this.groupBox2.Controls.Add(this.TxtCantidad);
            this.groupBox2.Controls.Add(this.Cantidad);
            this.groupBox2.Controls.Add(this.TxtProducto);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(565, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 65);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.BackgroundImage = global::Facturacion.Properties.Resources.busqueda;
            this.BtnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscarProducto.Location = new System.Drawing.Point(210, 23);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Size = new System.Drawing.Size(33, 28);
            this.BtnBuscarProducto.TabIndex = 5;
            this.BtnBuscarProducto.UseVisualStyleBackColor = true;
            this.BtnBuscarProducto.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LbcCantidad
            // 
            this.LbcCantidad.AutoSize = true;
            this.LbcCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbcCantidad.ForeColor = System.Drawing.Color.Lime;
            this.LbcCantidad.Location = new System.Drawing.Point(379, 26);
            this.LbcCantidad.Name = "LbcCantidad";
            this.LbcCantidad.Size = new System.Drawing.Size(83, 20);
            this.LbcCantidad.TabIndex = 6;
            this.LbcCantidad.Text = "Disponible";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(319, 27);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(54, 20);
            this.TxtCantidad.TabIndex = 5;
            this.TxtCantidad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cantidad.Location = new System.Drawing.Point(264, 29);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(49, 13);
            this.Cantidad.TabIndex = 2;
            this.Cantidad.Text = "Cantidad";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(62, 27);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.ReadOnly = true;
            this.TxtProducto.Size = new System.Drawing.Size(127, 20);
            this.TxtProducto.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(555, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Precio :";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.ForeColor = System.Drawing.Color.Lime;
            this.LblPrecio.Location = new System.Drawing.Point(614, 180);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(83, 20);
            this.LblPrecio.TabIndex = 26;
            this.LblPrecio.Text = "Disponible";
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.BackgroundImage = global::Facturacion.Properties.Resources.quitar;
            this.BtnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnQuitar.Location = new System.Drawing.Point(958, 164);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(78, 54);
            this.BtnQuitar.TabIndex = 28;
            this.BtnQuitar.UseVisualStyleBackColor = true;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackgroundImage = global::Facturacion.Properties.Resources.agregar;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregar.Location = new System.Drawing.Point(858, 164);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(80, 54);
            this.BtnAgregar.TabIndex = 27;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Lime;
            this.LblTotal.Location = new System.Drawing.Point(769, 180);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(83, 20);
            this.LblTotal.TabIndex = 30;
            this.LblTotal.Text = "Disponible";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(715, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Monto :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(769, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Total a Pagar :";
            // 
            // LblTotaApagar
            // 
            this.LblTotaApagar.AutoSize = true;
            this.LblTotaApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotaApagar.ForeColor = System.Drawing.Color.Lime;
            this.LblTotaApagar.Location = new System.Drawing.Point(900, 481);
            this.LblTotaApagar.Name = "LblTotaApagar";
            this.LblTotaApagar.Size = new System.Drawing.Size(0, 20);
            this.LblTotaApagar.TabIndex = 32;
            // 
            // dgvDetalleF
            // 
            this.dgvDetalleF.AllowUserToAddRows = false;
            this.dgvDetalleF.AllowUserToResizeRows = false;
            this.dgvDetalleF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion_Producto,
            this.Fecha,
            this.Cantidad_Producto,
            this.Precio_Producto,
            this.Generales,
            this.IDProducto});
            this.dgvDetalleF.Location = new System.Drawing.Point(22, 265);
            this.dgvDetalleF.Name = "dgvDetalleF";
            this.dgvDetalleF.ReadOnly = true;
            this.dgvDetalleF.RowHeadersVisible = false;
            this.dgvDetalleF.Size = new System.Drawing.Size(1038, 188);
            this.dgvDetalleF.TabIndex = 33;
            this.dgvDetalleF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleF_CellContentClick);
            this.dgvDetalleF.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleF_CellContentDoubleClick);
            this.dgvDetalleF.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleF_CellDoubleClick);
            // 
            // Descripcion_Producto
            // 
            this.Descripcion_Producto.HeaderText = "Concepto";
            this.Descripcion_Producto.Name = "Descripcion_Producto";
            this.Descripcion_Producto.ReadOnly = true;
            this.Descripcion_Producto.Width = 300;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Catidad";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Cantidad_Producto
            // 
            this.Cantidad_Producto.HeaderText = "Precio";
            this.Cantidad_Producto.Name = "Cantidad_Producto";
            this.Cantidad_Producto.ReadOnly = true;
            this.Cantidad_Producto.Width = 150;
            // 
            // Precio_Producto
            // 
            this.Precio_Producto.HeaderText = "Generales";
            this.Precio_Producto.Name = "Precio_Producto";
            this.Precio_Producto.ReadOnly = true;
            this.Precio_Producto.Width = 150;
            // 
            // Generales
            // 
            this.Generales.HeaderText = "Itbis";
            this.Generales.Name = "Generales";
            this.Generales.ReadOnly = true;
            this.Generales.Width = 200;
            // 
            // IDProducto
            // 
            this.IDProducto.HeaderText = "IdProducto";
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.ReadOnly = true;
            this.IDProducto.Visible = false;
            // 
            // tsbConfi
            // 
            this.tsbConfi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbConfi.Image = ((System.Drawing.Image)(resources.GetObject("tsbConfi.Image")));
            this.tsbConfi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConfi.Name = "tsbConfi";
            this.tsbConfi.Size = new System.Drawing.Size(34, 34);
            this.tsbConfi.Text = "Configurar";
            this.tsbConfi.Click += new System.EventHandler(this.tsbConfi_Click);
            // 
            // FrmFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1083, 527);
            this.Controls.Add(this.dgvDetalleF);
            this.Controls.Add(this.LblTotaApagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnQuitar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StBar);
            this.Controls.Add(this.LblMinimixar);
            this.Controls.Add(this.LblCerrar);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFacturar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFacturar";
            this.Load += new System.EventHandler(this.FrmFacturar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.StBar.ResumeLayout(false);
            this.StBar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ToolstNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ToolstGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Toolstborrar;
        private System.Windows.Forms.Label LblMinimixar;
        private System.Windows.Forms.Label LblCerrar;
        private System.Windows.Forms.StatusStrip StBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.ComboBox CbxForamPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbcCantidad;
        private System.Windows.Forms.Button BtnBuscarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label LblTotaApagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDetalleF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Generales;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsImprimir;
        private System.Windows.Forms.ToolStripButton tsbConfi;
    }
}