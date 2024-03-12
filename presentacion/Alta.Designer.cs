namespace presentacion
{
    partial class frmAlta
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
            this.gbxCodigo = new helper.ColoredGroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.pnlAlta = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbxAlta = new System.Windows.Forms.PictureBox();
            this.gbxPrecio = new helper.ColoredGroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.gbxImagen = new helper.ColoredGroupBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.gbxCategoria = new helper.ColoredGroupBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.gbxMarca = new helper.ColoredGroupBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.gbxDescripcion = new helper.ColoredGroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.gbxNombre = new helper.ColoredGroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Imagen = new System.Windows.Forms.ToolTip(this.components);
            this.gbxCodigo.SuspendLayout();
            this.pnlAlta.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlta)).BeginInit();
            this.gbxPrecio.SuspendLayout();
            this.gbxImagen.SuspendLayout();
            this.gbxCategoria.SuspendLayout();
            this.gbxMarca.SuspendLayout();
            this.gbxDescripcion.SuspendLayout();
            this.gbxNombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCodigo
            // 
            this.gbxCodigo.BorderColor = System.Drawing.Color.Black;
            this.gbxCodigo.Controls.Add(this.txtCodigo);
            this.gbxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCodigo.Location = new System.Drawing.Point(19, 14);
            this.gbxCodigo.Name = "gbxCodigo";
            this.gbxCodigo.Size = new System.Drawing.Size(276, 45);
            this.gbxCodigo.TabIndex = 0;
            this.gbxCodigo.TabStop = false;
            this.gbxCodigo.Text = "Código del artículo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Location = new System.Drawing.Point(6, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(264, 14);
            this.txtCodigo.TabIndex = 0;
            // 
            // pnlAlta
            // 
            this.pnlAlta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlta.Controls.Add(this.pnlBotones);
            this.pnlAlta.Controls.Add(this.pbxAlta);
            this.pnlAlta.Controls.Add(this.gbxPrecio);
            this.pnlAlta.Controls.Add(this.gbxImagen);
            this.pnlAlta.Controls.Add(this.gbxCategoria);
            this.pnlAlta.Controls.Add(this.gbxMarca);
            this.pnlAlta.Controls.Add(this.gbxDescripcion);
            this.pnlAlta.Controls.Add(this.gbxNombre);
            this.pnlAlta.Controls.Add(this.gbxCodigo);
            this.pnlAlta.Location = new System.Drawing.Point(12, 12);
            this.pnlAlta.Name = "pnlAlta";
            this.pnlAlta.Size = new System.Drawing.Size(745, 572);
            this.pnlAlta.TabIndex = 1;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnAceptar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Location = new System.Drawing.Point(19, 487);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(276, 66);
            this.pnlBotones.TabIndex = 10;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(0, 22);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(128, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(148, 22);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbxAlta
            // 
            this.pbxAlta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxAlta.Location = new System.Drawing.Point(312, 19);
            this.pbxAlta.Name = "pbxAlta";
            this.pbxAlta.Size = new System.Drawing.Size(414, 452);
            this.pbxAlta.TabIndex = 7;
            this.pbxAlta.TabStop = false;
            this.Imagen.SetToolTip(this.pbxAlta, "Haga click para agregar una imagen local");
            // 
            // gbxPrecio
            // 
            this.gbxPrecio.BorderColor = System.Drawing.Color.Black;
            this.gbxPrecio.Controls.Add(this.txtPrecio);
            this.gbxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPrecio.Location = new System.Drawing.Point(19, 422);
            this.gbxPrecio.Name = "gbxPrecio";
            this.gbxPrecio.Size = new System.Drawing.Size(276, 45);
            this.gbxPrecio.TabIndex = 6;
            this.gbxPrecio.TabStop = false;
            this.gbxPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Location = new System.Drawing.Point(7, 19);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(264, 14);
            this.txtPrecio.TabIndex = 0;
            // 
            // gbxImagen
            // 
            this.gbxImagen.BorderColor = System.Drawing.Color.Black;
            this.gbxImagen.Controls.Add(this.txtImagen);
            this.gbxImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxImagen.Location = new System.Drawing.Point(19, 354);
            this.gbxImagen.Name = "gbxImagen";
            this.gbxImagen.Size = new System.Drawing.Size(276, 45);
            this.gbxImagen.TabIndex = 5;
            this.gbxImagen.TabStop = false;
            this.gbxImagen.Text = "Imagen";
            // 
            // txtImagen
            // 
            this.txtImagen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtImagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImagen.Location = new System.Drawing.Point(7, 18);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(264, 14);
            this.txtImagen.TabIndex = 0;
            // 
            // gbxCategoria
            // 
            this.gbxCategoria.BorderColor = System.Drawing.Color.Black;
            this.gbxCategoria.Controls.Add(this.cboCategoria);
            this.gbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCategoria.Location = new System.Drawing.Point(19, 286);
            this.gbxCategoria.Name = "gbxCategoria";
            this.gbxCategoria.Size = new System.Drawing.Size(276, 45);
            this.gbxCategoria.TabIndex = 4;
            this.gbxCategoria.TabStop = false;
            this.gbxCategoria.Text = "Categoría";
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(6, 17);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(264, 23);
            this.cboCategoria.TabIndex = 0;
            // 
            // gbxMarca
            // 
            this.gbxMarca.BorderColor = System.Drawing.Color.Black;
            this.gbxMarca.Controls.Add(this.cboMarca);
            this.gbxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMarca.Location = new System.Drawing.Point(19, 218);
            this.gbxMarca.Name = "gbxMarca";
            this.gbxMarca.Size = new System.Drawing.Size(276, 45);
            this.gbxMarca.TabIndex = 3;
            this.gbxMarca.TabStop = false;
            this.gbxMarca.Text = "Marca";
            // 
            // cboMarca
            // 
            this.cboMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(6, 17);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(264, 23);
            this.cboMarca.TabIndex = 0;
            // 
            // gbxDescripcion
            // 
            this.gbxDescripcion.BorderColor = System.Drawing.Color.Black;
            this.gbxDescripcion.Controls.Add(this.txtDescripcion);
            this.gbxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDescripcion.Location = new System.Drawing.Point(19, 150);
            this.gbxDescripcion.Name = "gbxDescripcion";
            this.gbxDescripcion.Size = new System.Drawing.Size(276, 45);
            this.gbxDescripcion.TabIndex = 2;
            this.gbxDescripcion.TabStop = false;
            this.gbxDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Location = new System.Drawing.Point(6, 21);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(264, 14);
            this.txtDescripcion.TabIndex = 0;
            // 
            // gbxNombre
            // 
            this.gbxNombre.BorderColor = System.Drawing.Color.Black;
            this.gbxNombre.Controls.Add(this.txtNombre);
            this.gbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNombre.Location = new System.Drawing.Point(19, 82);
            this.gbxNombre.Name = "gbxNombre";
            this.gbxNombre.Size = new System.Drawing.Size(276, 45);
            this.gbxNombre.TabIndex = 1;
            this.gbxNombre.TabStop = false;
            this.gbxNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(7, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(264, 14);
            this.txtNombre.TabIndex = 0;
            // 
            // frmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(769, 596);
            this.Controls.Add(this.pnlAlta);
            this.Name = "frmAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo artículo";
            this.gbxCodigo.ResumeLayout(false);
            this.gbxCodigo.PerformLayout();
            this.pnlAlta.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlta)).EndInit();
            this.gbxPrecio.ResumeLayout(false);
            this.gbxPrecio.PerformLayout();
            this.gbxImagen.ResumeLayout(false);
            this.gbxImagen.PerformLayout();
            this.gbxCategoria.ResumeLayout(false);
            this.gbxMarca.ResumeLayout(false);
            this.gbxDescripcion.ResumeLayout(false);
            this.gbxDescripcion.PerformLayout();
            this.gbxNombre.ResumeLayout(false);
            this.gbxNombre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private helper.ColoredGroupBox gbxCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Panel pnlAlta;
        private helper.ColoredGroupBox gbxNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private helper.ColoredGroupBox gbxPrecio;
        private helper.ColoredGroupBox gbxImagen;
        private helper.ColoredGroupBox gbxCategoria;
        private helper.ColoredGroupBox gbxMarca;
        private helper.ColoredGroupBox gbxDescripcion;
        private System.Windows.Forms.PictureBox pbxAlta;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.ToolTip Imagen;
    }
}