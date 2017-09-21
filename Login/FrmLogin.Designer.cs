namespace Facturacion
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.CbxUsuario = new System.Windows.Forms.ComboBox();
            this.LblClave = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblCerrar = new System.Windows.Forms.Label();
            this.LblMinimixar = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.TxtClave);
            this.groupBox1.Controls.Add(this.CbxUsuario);
            this.groupBox1.Controls.Add(this.LblClave);
            this.groupBox1.Controls.Add(this.LblUsuario);
            this.groupBox1.Location = new System.Drawing.Point(17, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Facturacion.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(293, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(75, 87);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(139, 20);
            this.TxtClave.TabIndex = 1;
            this.TxtClave.UseSystemPasswordChar = true;
            this.TxtClave.TextChanged += new System.EventHandler(this.TxtClave_TextChanged);
            this.TxtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClave_KeyPress);
            // 
            // CbxUsuario
            // 
            this.CbxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxUsuario.FormattingEnabled = true;
            this.CbxUsuario.Location = new System.Drawing.Point(75, 34);
            this.CbxUsuario.Name = "CbxUsuario";
            this.CbxUsuario.Size = new System.Drawing.Size(108, 21);
            this.CbxUsuario.TabIndex = 0;
            this.CbxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxUsuario_KeyPress);
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.Font = new System.Drawing.Font("Segoe Marker", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClave.ForeColor = System.Drawing.Color.White;
            this.LblClave.Location = new System.Drawing.Point(6, 87);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(36, 15);
            this.LblClave.TabIndex = 1;
            this.LblClave.Text = "Clave";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Segoe Marker", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.White;
            this.LblUsuario.Location = new System.Drawing.Point(6, 34);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(50, 15);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblCerrar
            // 
            this.LblCerrar.AutoSize = true;
            this.LblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCerrar.ForeColor = System.Drawing.Color.White;
            this.LblCerrar.Location = new System.Drawing.Point(443, 7);
            this.LblCerrar.Name = "LblCerrar";
            this.LblCerrar.Size = new System.Drawing.Size(20, 20);
            this.LblCerrar.TabIndex = 8;
            this.LblCerrar.Text = "X";
            this.LblCerrar.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblMinimixar
            // 
            this.LblMinimixar.AutoSize = true;
            this.LblMinimixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblMinimixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinimixar.ForeColor = System.Drawing.Color.White;
            this.LblMinimixar.Location = new System.Drawing.Point(422, 4);
            this.LblMinimixar.Name = "LblMinimixar";
            this.LblMinimixar.Size = new System.Drawing.Size(19, 25);
            this.LblMinimixar.TabIndex = 9;
            this.LblMinimixar.Text = "-";
            this.LblMinimixar.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(187, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 40);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 8);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnCancelar.BackgroundImage = global::Facturacion.Properties.Resources.x;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCancelar.FlatAppearance.BorderSize = 20;
            this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Location = new System.Drawing.Point(253, 226);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(92, 37);
            this.BtnCancelar.TabIndex = 0;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackgroundImage = global::Facturacion.Properties.Resources.A;
            this.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAceptar.FlatAppearance.BorderSize = 20;
            this.BtnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAceptar.Location = new System.Drawing.Point(127, 226);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(91, 37);
            this.BtnAceptar.TabIndex = 1;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(476, 271);
            this.Controls.Add(this.LblMinimixar);
            this.Controls.Add(this.LblCerrar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.ComboBox CbxUsuario;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblCerrar;
        private System.Windows.Forms.Label LblMinimixar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAceptar;
    }
}

