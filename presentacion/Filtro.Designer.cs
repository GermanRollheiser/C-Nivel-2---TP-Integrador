namespace presentacion
{
    partial class frmFiltro
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
            this.gbxCampo = new helper.ColoredGroupBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.gbxCriterio = new helper.ColoredGroupBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.gbxBuscar = new helper.ColoredGroupBox();
            this.txtBuscarAvanzado = new System.Windows.Forms.TextBox();
            this.lblBuscarAvanzado = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxCampo.SuspendLayout();
            this.gbxCriterio.SuspendLayout();
            this.gbxBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCampo
            // 
            this.gbxCampo.BorderColor = System.Drawing.Color.Black;
            this.gbxCampo.Controls.Add(this.cboCampo);
            this.gbxCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCampo.Location = new System.Drawing.Point(13, 45);
            this.gbxCampo.Name = "gbxCampo";
            this.gbxCampo.Size = new System.Drawing.Size(276, 45);
            this.gbxCampo.TabIndex = 1;
            this.gbxCampo.TabStop = false;
            this.gbxCampo.Text = "Campo";
            // 
            // cboCampo
            // 
            this.cboCampo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(6, 17);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(264, 23);
            this.cboCampo.TabIndex = 0;
            this.cboCampo.TabStop = false;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // gbxCriterio
            // 
            this.gbxCriterio.BorderColor = System.Drawing.Color.Black;
            this.gbxCriterio.Controls.Add(this.cboCriterio);
            this.gbxCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCriterio.Location = new System.Drawing.Point(13, 136);
            this.gbxCriterio.Name = "gbxCriterio";
            this.gbxCriterio.Size = new System.Drawing.Size(276, 45);
            this.gbxCriterio.TabIndex = 2;
            this.gbxCriterio.TabStop = false;
            this.gbxCriterio.Text = "Criterio";
            // 
            // cboCriterio
            // 
            this.cboCriterio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(6, 17);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(264, 23);
            this.cboCriterio.TabIndex = 0;
            this.cboCriterio.TabStop = false;
            // 
            // gbxBuscar
            // 
            this.gbxBuscar.BorderColor = System.Drawing.Color.Black;
            this.gbxBuscar.Controls.Add(this.txtBuscarAvanzado);
            this.gbxBuscar.Controls.Add(this.lblBuscarAvanzado);
            this.gbxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBuscar.Location = new System.Drawing.Point(13, 227);
            this.gbxBuscar.Name = "gbxBuscar";
            this.gbxBuscar.Size = new System.Drawing.Size(276, 45);
            this.gbxBuscar.TabIndex = 3;
            this.gbxBuscar.TabStop = false;
            this.gbxBuscar.Text = "Buscar";
            // 
            // txtBuscarAvanzado
            // 
            this.txtBuscarAvanzado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBuscarAvanzado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarAvanzado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarAvanzado.Location = new System.Drawing.Point(6, 18);
            this.txtBuscarAvanzado.MaxLength = 50;
            this.txtBuscarAvanzado.Name = "txtBuscarAvanzado";
            this.txtBuscarAvanzado.Size = new System.Drawing.Size(236, 13);
            this.txtBuscarAvanzado.TabIndex = 1;
            this.txtBuscarAvanzado.TabStop = false;
            // 
            // lblBuscarAvanzado
            // 
            this.lblBuscarAvanzado.Image = global::presentacion.Properties.Resources.Search;
            this.lblBuscarAvanzado.Location = new System.Drawing.Point(248, 19);
            this.lblBuscarAvanzado.Name = "lblBuscarAvanzado";
            this.lblBuscarAvanzado.Size = new System.Drawing.Size(22, 13);
            this.lblBuscarAvanzado.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Location = new System.Drawing.Point(15, 327);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(128, 23);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.TabStop = false;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(160, 326);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(302, 395);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.gbxBuscar);
            this.Controls.Add(this.gbxCriterio);
            this.Controls.Add(this.gbxCampo);
            this.Location = new System.Drawing.Point(203, 303);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(318, 434);
            this.MinimumSize = new System.Drawing.Size(318, 434);
            this.Name = "frmFiltro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Busqueda avanzada";
            this.Load += new System.EventHandler(this.frmFiltro_Load);
            this.gbxCampo.ResumeLayout(false);
            this.gbxCriterio.ResumeLayout(false);
            this.gbxBuscar.ResumeLayout(false);
            this.gbxBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private helper.ColoredGroupBox gbxCampo;
        private helper.ColoredGroupBox gbxCriterio;
        private helper.ColoredGroupBox gbxBuscar;
        private System.Windows.Forms.Label lblBuscarAvanzado;
        private System.Windows.Forms.Button btnFiltrar;
        public System.Windows.Forms.TextBox txtBuscarAvanzado;
        public System.Windows.Forms.ComboBox cboCampo;
        public System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Button btnCancelar;
    }
}