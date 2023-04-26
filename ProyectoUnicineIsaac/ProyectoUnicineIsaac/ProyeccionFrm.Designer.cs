namespace ProyectoUnicineIsaac
{
    partial class ProyeccionFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.txtSesion = new System.Windows.Forms.TextBox();
            this.btnBuscarSesion = new System.Windows.Forms.Button();
            this.btnBuscarPelicula = new System.Windows.Forms.Button();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sesion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pelicula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Fin";
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(84, 46);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.ReadOnly = true;
            this.txtPelicula.Size = new System.Drawing.Size(122, 20);
            this.txtPelicula.TabIndex = 4;
            // 
            // txtSesion
            // 
            this.txtSesion.Location = new System.Drawing.Point(84, 12);
            this.txtSesion.Name = "txtSesion";
            this.txtSesion.ReadOnly = true;
            this.txtSesion.Size = new System.Drawing.Size(122, 20);
            this.txtSesion.TabIndex = 5;
            // 
            // btnBuscarSesion
            // 
            this.btnBuscarSesion.Location = new System.Drawing.Point(212, 10);
            this.btnBuscarSesion.Name = "btnBuscarSesion";
            this.btnBuscarSesion.Size = new System.Drawing.Size(92, 23);
            this.btnBuscarSesion.TabIndex = 6;
            this.btnBuscarSesion.Text = "Buscar Sesión";
            this.btnBuscarSesion.UseVisualStyleBackColor = true;
            this.btnBuscarSesion.Click += new System.EventHandler(this.btnBuscarSesion_Click);
            // 
            // btnBuscarPelicula
            // 
            this.btnBuscarPelicula.Location = new System.Drawing.Point(212, 44);
            this.btnBuscarPelicula.Name = "btnBuscarPelicula";
            this.btnBuscarPelicula.Size = new System.Drawing.Size(92, 23);
            this.btnBuscarPelicula.TabIndex = 7;
            this.btnBuscarPelicula.Text = "Buscar Película";
            this.btnBuscarPelicula.UseVisualStyleBackColor = true;
            this.btnBuscarPelicula.Click += new System.EventHandler(this.btnBuscarPelicula_Click);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(85, 82);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(101, 20);
            this.dtpInicio.TabIndex = 8;
            // 
            // dtpFin
            // 
            this.dtpFin.CustomFormat = " ";
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(84, 118);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(102, 20);
            this.dtpFin.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(158, 167);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(239, 167);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 11;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(192, 118);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // ProyeccionFrm
            // 
            this.AcceptButton = this.btnCrear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(326, 202);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.btnBuscarPelicula);
            this.Controls.Add(this.btnBuscarSesion);
            this.Controls.Add(this.txtSesion);
            this.Controls.Add(this.txtPelicula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProyeccionFrm";
            this.Text = "Crear Proyección";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.TextBox txtSesion;
        private System.Windows.Forms.Button btnBuscarSesion;
        private System.Windows.Forms.Button btnBuscarPelicula;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnBorrar;
    }
}