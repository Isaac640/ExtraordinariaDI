namespace ProyectoUnicineIsaac
{
    partial class ListaSesionesFrm
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
            this.mnsSesion = new System.Windows.Forms.MenuStrip();
            this.sesionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvSesiones = new System.Windows.Forms.ListView();
            this.Salas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comienzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Finaliza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aforo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsSesion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCrearSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVerSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSesion.SuspendLayout();
            this.cmsSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsSesion
            // 
            this.mnsSesion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionesToolStripMenuItem,
            this.informeToolStripMenuItem});
            this.mnsSesion.Location = new System.Drawing.Point(0, 0);
            this.mnsSesion.Name = "mnsSesion";
            this.mnsSesion.Size = new System.Drawing.Size(483, 24);
            this.mnsSesion.TabIndex = 0;
            this.mnsSesion.Text = "menuStrip1";
            // 
            // sesionesToolStripMenuItem
            // 
            this.sesionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearSesionToolStripMenuItem});
            this.sesionesToolStripMenuItem.Name = "sesionesToolStripMenuItem";
            this.sesionesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.sesionesToolStripMenuItem.Text = "Sesiones";
            // 
            // crearSesionToolStripMenuItem
            // 
            this.crearSesionToolStripMenuItem.Name = "crearSesionToolStripMenuItem";
            this.crearSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearSesionToolStripMenuItem.Text = "Crear Sesion";
            this.crearSesionToolStripMenuItem.Click += new System.EventHandler(this.tsmCrearSesion_Click);
            // 
            // informeToolStripMenuItem
            // 
            this.informeToolStripMenuItem.Name = "informeToolStripMenuItem";
            this.informeToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.informeToolStripMenuItem.Text = "Informe";
            // 
            // lvSesiones
            // 
            this.lvSesiones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Salas,
            this.Dia,
            this.Comienzo,
            this.Finaliza,
            this.Precio,
            this.Aforo});
            this.lvSesiones.ContextMenuStrip = this.cmsSesion;
            this.lvSesiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSesiones.HideSelection = false;
            this.lvSesiones.Location = new System.Drawing.Point(0, 24);
            this.lvSesiones.MultiSelect = false;
            this.lvSesiones.Name = "lvSesiones";
            this.lvSesiones.Size = new System.Drawing.Size(483, 354);
            this.lvSesiones.TabIndex = 1;
            this.lvSesiones.UseCompatibleStateImageBehavior = false;
            this.lvSesiones.View = System.Windows.Forms.View.Details;
            // 
            // Salas
            // 
            this.Salas.Text = "Salas";
            this.Salas.Width = 62;
            // 
            // Dia
            // 
            this.Dia.Text = "Dias";
            this.Dia.Width = 64;
            // 
            // Comienzo
            // 
            this.Comienzo.Text = "Hora Comienzo";
            this.Comienzo.Width = 100;
            // 
            // Finaliza
            // 
            this.Finaliza.Text = "Hora fin";
            this.Finaliza.Width = 88;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.Width = 73;
            // 
            // Aforo
            // 
            this.Aforo.Text = "Aforo";
            this.Aforo.Width = 77;
            // 
            // cmsSesion
            // 
            this.cmsSesion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCrearSesion,
            this.tsmVerSesion,
            this.tsmEliminarSesion});
            this.cmsSesion.Name = "cmsSesion";
            this.cmsSesion.Size = new System.Drawing.Size(118, 70);
            this.cmsSesion.Opening += new System.ComponentModel.CancelEventHandler(this.cmsSesion_Opening);
            // 
            // tsmCrearSesion
            // 
            this.tsmCrearSesion.Name = "tsmCrearSesion";
            this.tsmCrearSesion.Size = new System.Drawing.Size(180, 22);
            this.tsmCrearSesion.Text = "Crear";
            this.tsmCrearSesion.Click += new System.EventHandler(this.tsmCrearSesion_Click);
            // 
            // tsmVerSesion
            // 
            this.tsmVerSesion.Name = "tsmVerSesion";
            this.tsmVerSesion.Size = new System.Drawing.Size(180, 22);
            this.tsmVerSesion.Text = "Ver";
            this.tsmVerSesion.Click += new System.EventHandler(this.tsmVerSesion_Click);
            // 
            // tsmEliminarSesion
            // 
            this.tsmEliminarSesion.Name = "tsmEliminarSesion";
            this.tsmEliminarSesion.Size = new System.Drawing.Size(180, 22);
            this.tsmEliminarSesion.Text = "Eliminar";
            this.tsmEliminarSesion.Click += new System.EventHandler(this.tsmEliminarSesion_Click);
            // 
            // ListaSesionesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 378);
            this.Controls.Add(this.lvSesiones);
            this.Controls.Add(this.mnsSesion);
            this.MainMenuStrip = this.mnsSesion;
            this.Name = "ListaSesionesFrm";
            this.Text = "ListaSesionesFrm";
            this.mnsSesion.ResumeLayout(false);
            this.mnsSesion.PerformLayout();
            this.cmsSesion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsSesion;
        private System.Windows.Forms.ToolStripMenuItem sesionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem;
        private System.Windows.Forms.ListView lvSesiones;
        private System.Windows.Forms.ColumnHeader Salas;
        private System.Windows.Forms.ColumnHeader Dia;
        private System.Windows.Forms.ColumnHeader Comienzo;
        private System.Windows.Forms.ColumnHeader Finaliza;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Aforo;
        private System.Windows.Forms.ContextMenuStrip cmsSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmCrearSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmVerSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarSesion;
    }
}