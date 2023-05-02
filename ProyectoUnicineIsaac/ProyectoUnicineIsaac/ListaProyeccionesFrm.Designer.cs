namespace ProyectoUnicineIsaac
{
    partial class ListaProyeccionesFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.proyeccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearProyecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCartelera = new System.Windows.Forms.ToolStripMenuItem();
            this.lvProyecciones = new System.Windows.Forms.ListView();
            this.Sesión = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pelicula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsProyeccion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCrearProyeccion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVerProyeccion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarProyeccion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.cmsProyeccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proyeccionesToolStripMenuItem,
            this.tsmCartelera});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(432, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proyeccionesToolStripMenuItem
            // 
            this.proyeccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearProyecciónToolStripMenuItem});
            this.proyeccionesToolStripMenuItem.Name = "proyeccionesToolStripMenuItem";
            this.proyeccionesToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.proyeccionesToolStripMenuItem.Text = "Proyecciones";
            // 
            // crearProyecciónToolStripMenuItem
            // 
            this.crearProyecciónToolStripMenuItem.Name = "crearProyecciónToolStripMenuItem";
            this.crearProyecciónToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.crearProyecciónToolStripMenuItem.Text = "Crear Proyección";
            this.crearProyecciónToolStripMenuItem.Click += new System.EventHandler(this.tsmCrearProyeccion_Click);
            // 
            // tsmCartelera
            // 
            this.tsmCartelera.Name = "tsmCartelera";
            this.tsmCartelera.Size = new System.Drawing.Size(66, 20);
            this.tsmCartelera.Text = "Cartelera";
            this.tsmCartelera.Click += new System.EventHandler(this.tsmCartelera_Click);
            // 
            // lvProyecciones
            // 
            this.lvProyecciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sesión,
            this.Pelicula,
            this.Inicio,
            this.Fin});
            this.lvProyecciones.ContextMenuStrip = this.cmsProyeccion;
            this.lvProyecciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProyecciones.FullRowSelect = true;
            this.lvProyecciones.HideSelection = false;
            this.lvProyecciones.Location = new System.Drawing.Point(0, 24);
            this.lvProyecciones.MultiSelect = false;
            this.lvProyecciones.Name = "lvProyecciones";
            this.lvProyecciones.Size = new System.Drawing.Size(432, 330);
            this.lvProyecciones.TabIndex = 1;
            this.lvProyecciones.UseCompatibleStateImageBehavior = false;
            this.lvProyecciones.View = System.Windows.Forms.View.Details;
            // 
            // Sesión
            // 
            this.Sesión.Text = "Nº Sesión";
            this.Sesión.Width = 69;
            // 
            // Pelicula
            // 
            this.Pelicula.Text = "Nº Película";
            this.Pelicula.Width = 82;
            // 
            // Inicio
            // 
            this.Inicio.Text = "Fecha Inicio";
            this.Inicio.Width = 114;
            // 
            // Fin
            // 
            this.Fin.Text = "Fecha Fin";
            this.Fin.Width = 133;
            // 
            // cmsProyeccion
            // 
            this.cmsProyeccion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCrearProyeccion,
            this.tsmVerProyeccion,
            this.tsmEliminarProyeccion});
            this.cmsProyeccion.Name = "cmsProyeccion";
            this.cmsProyeccion.Size = new System.Drawing.Size(118, 70);
            this.cmsProyeccion.Opening += new System.ComponentModel.CancelEventHandler(this.cmsProyeccion_Opening);
            // 
            // tsmCrearProyeccion
            // 
            this.tsmCrearProyeccion.Name = "tsmCrearProyeccion";
            this.tsmCrearProyeccion.Size = new System.Drawing.Size(117, 22);
            this.tsmCrearProyeccion.Text = "Crear";
            this.tsmCrearProyeccion.Click += new System.EventHandler(this.tsmCrearProyeccion_Click);
            // 
            // tsmVerProyeccion
            // 
            this.tsmVerProyeccion.Name = "tsmVerProyeccion";
            this.tsmVerProyeccion.Size = new System.Drawing.Size(117, 22);
            this.tsmVerProyeccion.Text = "Ver";
            this.tsmVerProyeccion.Click += new System.EventHandler(this.tsmVerProyeccion_Click);
            // 
            // tsmEliminarProyeccion
            // 
            this.tsmEliminarProyeccion.Name = "tsmEliminarProyeccion";
            this.tsmEliminarProyeccion.Size = new System.Drawing.Size(117, 22);
            this.tsmEliminarProyeccion.Text = "Eliminar";
            this.tsmEliminarProyeccion.Click += new System.EventHandler(this.tsmEliminarProyeccion_Click);
            // 
            // ListaProyeccionesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 354);
            this.Controls.Add(this.lvProyecciones);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListaProyeccionesFrm";
            this.Text = "Proyecciones";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsProyeccion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem proyeccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCartelera;
        private System.Windows.Forms.ToolStripMenuItem crearProyecciónToolStripMenuItem;
        private System.Windows.Forms.ListView lvProyecciones;
        private System.Windows.Forms.ColumnHeader Sesión;
        private System.Windows.Forms.ColumnHeader Pelicula;
        private System.Windows.Forms.ColumnHeader Inicio;
        private System.Windows.Forms.ColumnHeader Fin;
        private System.Windows.Forms.ContextMenuStrip cmsProyeccion;
        private System.Windows.Forms.ToolStripMenuItem tsmCrearProyeccion;
        private System.Windows.Forms.ToolStripMenuItem tsmVerProyeccion;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarProyeccion;
    }
}