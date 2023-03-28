namespace UTR_E1.Formularios_y_controles
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbOtros = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSituacion = new System.Windows.Forms.ComboBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chkDeportes = new System.Windows.Forms.CheckBox();
            this.chkMusica = new System.Windows.Forms.CheckBox();
            this.chkLectura = new System.Windows.Forms.CheckBox();
            this.chkOtras = new System.Windows.Forms.CheckBox();
            this.txtAficionesOtros = new System.Windows.Forms.TextBox();
            this.grpAficiones = new System.Windows.Forms.GroupBox();
            this.grpAficiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nacimiento";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(98, 52);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(192, 20);
            this.dtpNacimiento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo";
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Checked = true;
            this.rbHombre.Location = new System.Drawing.Point(98, 90);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(62, 17);
            this.rbHombre.TabIndex = 6;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            this.rbHombre.CheckedChanged += new System.EventHandler(this.rbHombre_CheckedChanged);
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(166, 90);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(51, 17);
            this.rbMujer.TabIndex = 7;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            this.rbMujer.CheckedChanged += new System.EventHandler(this.rbHombre_CheckedChanged);
            // 
            // rbOtros
            // 
            this.rbOtros.AutoSize = true;
            this.rbOtros.Location = new System.Drawing.Point(223, 90);
            this.rbOtros.Name = "rbOtros";
            this.rbOtros.Size = new System.Drawing.Size(50, 17);
            this.rbOtros.TabIndex = 8;
            this.rbOtros.Text = "Otros";
            this.rbOtros.UseVisualStyleBackColor = true;
            this.rbOtros.CheckedChanged += new System.EventHandler(this.rbHombre_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Situación";
            // 
            // cmbSituacion
            // 
            this.cmbSituacion.FormattingEnabled = true;
            this.cmbSituacion.Items.AddRange(new object[] {
            "Becario",
            "Empleado",
            "Excedencia",
            "Jubilado"});
            this.cmbSituacion.Location = new System.Drawing.Point(70, 278);
            this.cmbSituacion.Name = "cmbSituacion";
            this.cmbSituacion.Size = new System.Drawing.Size(192, 21);
            this.cmbSituacion.TabIndex = 11;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(187, 322);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 12;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(270, 322);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chkDeportes
            // 
            this.chkDeportes.AutoSize = true;
            this.chkDeportes.Location = new System.Drawing.Point(17, 19);
            this.chkDeportes.Name = "chkDeportes";
            this.chkDeportes.Size = new System.Drawing.Size(69, 17);
            this.chkDeportes.TabIndex = 0;
            this.chkDeportes.Text = "Deportes";
            this.chkDeportes.UseVisualStyleBackColor = true;
            this.chkDeportes.CheckedChanged += new System.EventHandler(this.chkDeportes_CheckedChanged);
            // 
            // chkMusica
            // 
            this.chkMusica.AutoSize = true;
            this.chkMusica.Location = new System.Drawing.Point(93, 19);
            this.chkMusica.Name = "chkMusica";
            this.chkMusica.Size = new System.Drawing.Size(60, 17);
            this.chkMusica.TabIndex = 1;
            this.chkMusica.Text = "Musica";
            this.chkMusica.UseVisualStyleBackColor = true;
            this.chkMusica.CheckedChanged += new System.EventHandler(this.chkMusica_CheckedChanged);
            // 
            // chkLectura
            // 
            this.chkLectura.AutoSize = true;
            this.chkLectura.Location = new System.Drawing.Point(160, 19);
            this.chkLectura.Name = "chkLectura";
            this.chkLectura.Size = new System.Drawing.Size(62, 17);
            this.chkLectura.TabIndex = 2;
            this.chkLectura.Text = "Lectura";
            this.chkLectura.UseVisualStyleBackColor = true;
            this.chkLectura.CheckedChanged += new System.EventHandler(this.chkLectura_CheckedChanged);
            // 
            // chkOtras
            // 
            this.chkOtras.AutoSize = true;
            this.chkOtras.Location = new System.Drawing.Point(229, 19);
            this.chkOtras.Name = "chkOtras";
            this.chkOtras.Size = new System.Drawing.Size(51, 17);
            this.chkOtras.TabIndex = 3;
            this.chkOtras.Text = "Otras";
            this.chkOtras.UseVisualStyleBackColor = true;
            this.chkOtras.CheckedChanged += new System.EventHandler(this.chkOtras_CheckedChanged);
            // 
            // txtAficionesOtros
            // 
            this.txtAficionesOtros.Location = new System.Drawing.Point(17, 43);
            this.txtAficionesOtros.Multiline = true;
            this.txtAficionesOtros.Name = "txtAficionesOtros";
            this.txtAficionesOtros.ReadOnly = true;
            this.txtAficionesOtros.Size = new System.Drawing.Size(299, 87);
            this.txtAficionesOtros.TabIndex = 4;
            // 
            // grpAficiones
            // 
            this.grpAficiones.Controls.Add(this.txtAficionesOtros);
            this.grpAficiones.Controls.Add(this.chkDeportes);
            this.grpAficiones.Controls.Add(this.chkOtras);
            this.grpAficiones.Controls.Add(this.chkMusica);
            this.grpAficiones.Controls.Add(this.chkLectura);
            this.grpAficiones.Location = new System.Drawing.Point(15, 124);
            this.grpAficiones.Name = "grpAficiones";
            this.grpAficiones.Size = new System.Drawing.Size(330, 142);
            this.grpAficiones.TabIndex = 14;
            this.grpAficiones.TabStop = false;
            this.grpAficiones.Text = "Aficiones";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 357);
            this.Controls.Add(this.grpAficiones);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.cmbSituacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbOtros);
            this.Controls.Add(this.rbMujer);
            this.Controls.Add(this.rbHombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha Socio";
            this.grpAficiones.ResumeLayout(false);
            this.grpAficiones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbOtros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSituacion;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chkDeportes;
        private System.Windows.Forms.CheckBox chkMusica;
        private System.Windows.Forms.CheckBox chkLectura;
        private System.Windows.Forms.CheckBox chkOtras;
        private System.Windows.Forms.TextBox txtAficionesOtros;
        private System.Windows.Forms.GroupBox grpAficiones;
    }
}

