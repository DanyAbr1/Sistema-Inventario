namespace Facturacion
{
    partial class FrmBuscarClientes
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
            this.LblCerrar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbContacto = new System.Windows.Forms.RadioButton();
            this.rbNombre_Compañia = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdDocumento = new System.Windows.Forms.RadioButton();
            this.RdNombre = new System.Windows.Forms.RadioButton();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCerrar
            // 
            this.LblCerrar.AutoSize = true;
            this.LblCerrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCerrar.ForeColor = System.Drawing.Color.White;
            this.LblCerrar.Location = new System.Drawing.Point(602, 5);
            this.LblCerrar.Name = "LblCerrar";
            this.LblCerrar.Size = new System.Drawing.Size(20, 20);
            this.LblCerrar.TabIndex = 20;
            this.LblCerrar.Text = "X";
            this.LblCerrar.Click += new System.EventHandler(this.LblCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 29);
            this.panel1.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbContacto);
            this.groupBox3.Controls.Add(this.rbNombre_Compañia);
            this.groupBox3.Location = new System.Drawing.Point(-121, -33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(10, 10);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "&Filtro";
            // 
            // rbContacto
            // 
            this.rbContacto.AutoSize = true;
            this.rbContacto.Location = new System.Drawing.Point(103, 19);
            this.rbContacto.Name = "rbContacto";
            this.rbContacto.Size = new System.Drawing.Size(68, 17);
            this.rbContacto.TabIndex = 3;
            this.rbContacto.TabStop = true;
            this.rbContacto.Text = "Contacto";
            this.rbContacto.UseVisualStyleBackColor = true;
            // 
            // rbNombre_Compañia
            // 
            this.rbNombre_Compañia.AutoSize = true;
            this.rbNombre_Compañia.Location = new System.Drawing.Point(6, 19);
            this.rbNombre_Compañia.Name = "rbNombre_Compañia";
            this.rbNombre_Compañia.Size = new System.Drawing.Size(72, 17);
            this.rbNombre_Compañia.TabIndex = 2;
            this.rbNombre_Compañia.TabStop = true;
            this.rbNombre_Compañia.Text = "Compañia";
            this.rbNombre_Compañia.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnBuscar);
            this.groupBox4.Controls.Add(this.txtBusqueda);
            this.groupBox4.Location = new System.Drawing.Point(218, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 49);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "&Control de busqueda";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::Facturacion.Properties.Resources.busqueda;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.Location = new System.Drawing.Point(215, 17);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(36, 23);
            this.BtnBuscar.TabIndex = 29;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(6, 19);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(204, 20);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdDocumento);
            this.groupBox1.Controls.Add(this.RdNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 59);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Filtro";
            // 
            // RdDocumento
            // 
            this.RdDocumento.AutoSize = true;
            this.RdDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RdDocumento.Location = new System.Drawing.Point(103, 19);
            this.RdDocumento.Name = "RdDocumento";
            this.RdDocumento.Size = new System.Drawing.Size(80, 17);
            this.RdDocumento.TabIndex = 3;
            this.RdDocumento.TabStop = true;
            this.RdDocumento.Text = "Documento";
            this.RdDocumento.UseVisualStyleBackColor = true;
            // 
            // RdNombre
            // 
            this.RdNombre.AutoSize = true;
            this.RdNombre.Checked = true;
            this.RdNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RdNombre.Location = new System.Drawing.Point(6, 19);
            this.RdNombre.Name = "RdNombre";
            this.RdNombre.Size = new System.Drawing.Size(62, 17);
            this.RdNombre.TabIndex = 2;
            this.RdNombre.TabStop = true;
            this.RdNombre.Text = "Nombre";
            this.RdNombre.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvClientes.Location = new System.Drawing.Point(12, 110);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(605, 119);
            this.dgvClientes.TabIndex = 28;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // FrmBuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(629, 241);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.LblCerrar);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarClientes";
            this.Load += new System.EventHandler(this.FrmBuscarClientes_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbContacto;
        private System.Windows.Forms.RadioButton rbNombre_Compañia;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdDocumento;
        private System.Windows.Forms.RadioButton RdNombre;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button BtnBuscar;
    }
}