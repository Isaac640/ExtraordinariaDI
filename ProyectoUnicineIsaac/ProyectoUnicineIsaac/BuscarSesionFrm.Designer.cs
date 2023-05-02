namespace ProyectoUnicineIsaac
{
    partial class BuscarSesionFrm
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
            this.lvSesiones = new System.Windows.Forms.ListView();
            this.Sala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comienzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aforo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsBuscarSesion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsBuscarSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSesiones
            // 
            this.lvSesiones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sala,
            this.Dia,
            this.Comienzo,
            this.Aforo});
            this.lvSesiones.ContextMenuStrip = this.cmsBuscarSesion;
            this.lvSesiones.FullRowSelect = true;
            this.lvSesiones.HideSelection = false;
            this.lvSesiones.Location = new System.Drawing.Point(12, 12);
            this.lvSesiones.Name = "lvSesiones";
            this.lvSesiones.Size = new System.Drawing.Size(409, 241);
            this.lvSesiones.TabIndex = 0;
            this.lvSesiones.UseCompatibleStateImageBehavior = false;
            this.lvSesiones.View = System.Windows.Forms.View.Details;
            // 
            // Sala
            // 
            this.Sala.Text = "Sala";
            this.Sala.Width = 63;
            // 
            // Dia
            // 
            this.Dia.Text = "Dia";
            this.Dia.Width = 79;
            // 
            // Comienzo
            // 
            this.Comienzo.Text = "Comienzo";
            this.Comienzo.Width = 132;
            // 
            // Aforo
            // 
            this.Aforo.Text = "Aforo";
            this.Aforo.Width = 66;
            // 
            // cmsBuscarSesion
            // 
            this.cmsBuscarSesion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.cmsBuscarSesion.Name = "cmsBuscarSesion";
            this.cmsBuscarSesion.Size = new System.Drawing.Size(117, 26);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(346, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Haga clic derecho para agregar la sesión que busque";
            // 
            // BuscarSesionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lvSesiones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BuscarSesionFrm";
            this.Text = "Buscar Sesión";
            this.cmsBuscarSesion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSesiones;
        private System.Windows.Forms.ContextMenuStrip cmsBuscarSesion;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ColumnHeader Sala;
        private System.Windows.Forms.ColumnHeader Dia;
        private System.Windows.Forms.ColumnHeader Comienzo;
        private System.Windows.Forms.ColumnHeader Aforo;
        private System.Windows.Forms.Label label1;
    }
}