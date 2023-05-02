namespace ProyectoUnicineIsaac
{
    partial class ListaPeliculasFrm
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
            this.mnsPeliculas = new System.Windows.Forms.MenuStrip();
            this.peliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPeliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGeneros = new System.Windows.Forms.ToolStripMenuItem();
            this.lvPeliculas = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duracion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Anno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsPeliculas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsrCrearPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrVerPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrEliminarPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.informeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaDePeliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPeliculas.SuspendLayout();
            this.cmsPeliculas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPeliculas
            // 
            this.mnsPeliculas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculasToolStripMenuItem,
            this.tsmGeneros});
            this.mnsPeliculas.Location = new System.Drawing.Point(0, 0);
            this.mnsPeliculas.Name = "mnsPeliculas";
            this.mnsPeliculas.Size = new System.Drawing.Size(621, 24);
            this.mnsPeliculas.TabIndex = 0;
            this.mnsPeliculas.Text = "menuStrip1";
            // 
            // peliculasToolStripMenuItem
            // 
            this.peliculasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearPeliculaToolStripMenuItem});
            this.peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
            this.peliculasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.peliculasToolStripMenuItem.Text = "Peliculas";
            // 
            // crearPeliculaToolStripMenuItem
            // 
            this.crearPeliculaToolStripMenuItem.Name = "crearPeliculaToolStripMenuItem";
            this.crearPeliculaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.crearPeliculaToolStripMenuItem.Text = "Crear Pelicula";
            this.crearPeliculaToolStripMenuItem.Click += new System.EventHandler(this.tsrCrearPelicula_Click);
            // 
            // tsmGeneros
            // 
            this.tsmGeneros.Name = "tsmGeneros";
            this.tsmGeneros.Size = new System.Drawing.Size(62, 20);
            this.tsmGeneros.Text = "Géneros";
            this.tsmGeneros.Click += new System.EventHandler(this.tsmCategorias_Click);
            // 
            // lvPeliculas
            // 
            this.lvPeliculas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Categoria,
            this.Genero,
            this.Duracion,
            this.Anno});
            this.lvPeliculas.ContextMenuStrip = this.cmsPeliculas;
            this.lvPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPeliculas.FullRowSelect = true;
            this.lvPeliculas.HideSelection = false;
            this.lvPeliculas.Location = new System.Drawing.Point(0, 24);
            this.lvPeliculas.MultiSelect = false;
            this.lvPeliculas.Name = "lvPeliculas";
            this.lvPeliculas.Size = new System.Drawing.Size(621, 327);
            this.lvPeliculas.TabIndex = 1;
            this.lvPeliculas.UseCompatibleStateImageBehavior = false;
            this.lvPeliculas.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 237;
            // 
            // Categoria
            // 
            this.Categoria.Text = "Categoria";
            this.Categoria.Width = 97;
            // 
            // Genero
            // 
            this.Genero.Text = "Género";
            this.Genero.Width = 100;
            // 
            // Duracion
            // 
            this.Duracion.Text = "Duración";
            this.Duracion.Width = 56;
            // 
            // Anno
            // 
            this.Anno.Text = "Año";
            this.Anno.Width = 72;
            // 
            // cmsPeliculas
            // 
            this.cmsPeliculas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrCrearPelicula,
            this.tsrVerPelicula,
            this.tsrEliminarPelicula,
            this.informeToolStripMenuItem});
            this.cmsPeliculas.Name = "contextMenuStrip1";
            this.cmsPeliculas.Size = new System.Drawing.Size(118, 92);
            this.cmsPeliculas.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPeliculas_Opening);
            // 
            // tsrCrearPelicula
            // 
            this.tsrCrearPelicula.Name = "tsrCrearPelicula";
            this.tsrCrearPelicula.Size = new System.Drawing.Size(117, 22);
            this.tsrCrearPelicula.Text = "Crear";
            this.tsrCrearPelicula.Click += new System.EventHandler(this.tsrCrearPelicula_Click);
            // 
            // tsrVerPelicula
            // 
            this.tsrVerPelicula.Name = "tsrVerPelicula";
            this.tsrVerPelicula.Size = new System.Drawing.Size(117, 22);
            this.tsrVerPelicula.Text = "Ver";
            this.tsrVerPelicula.Click += new System.EventHandler(this.tsrVerPelicula_Click);
            // 
            // tsrEliminarPelicula
            // 
            this.tsrEliminarPelicula.Name = "tsrEliminarPelicula";
            this.tsrEliminarPelicula.Size = new System.Drawing.Size(117, 22);
            this.tsrEliminarPelicula.Text = "Eliminar";
            this.tsrEliminarPelicula.Click += new System.EventHandler(this.tsrEliminarPelicula_Click);
            // 
            // informeToolStripMenuItem
            // 
            this.informeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichaDePeliculaToolStripMenuItem});
            this.informeToolStripMenuItem.Name = "informeToolStripMenuItem";
            this.informeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.informeToolStripMenuItem.Text = "Informe";
            // 
            // fichaDePeliculaToolStripMenuItem
            // 
            this.fichaDePeliculaToolStripMenuItem.Name = "fichaDePeliculaToolStripMenuItem";
            this.fichaDePeliculaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.fichaDePeliculaToolStripMenuItem.Text = "Ficha de Pelicula";
            this.fichaDePeliculaToolStripMenuItem.Click += new System.EventHandler(this.fichaDePeliculaToolStripMenuItem_Click);
            // 
            // ListaPeliculasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 351);
            this.Controls.Add(this.lvPeliculas);
            this.Controls.Add(this.mnsPeliculas);
            this.MainMenuStrip = this.mnsPeliculas;
            this.Name = "ListaPeliculasFrm";
            this.Text = "Peliculas";
            this.mnsPeliculas.ResumeLayout(false);
            this.mnsPeliculas.PerformLayout();
            this.cmsPeliculas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPeliculas;
        private System.Windows.Forms.ToolStripMenuItem peliculasToolStripMenuItem;
        private System.Windows.Forms.ListView lvPeliculas;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Categoria;
        private System.Windows.Forms.ColumnHeader Genero;
        private System.Windows.Forms.ColumnHeader Duracion;
        private System.Windows.Forms.ColumnHeader Anno;
        private System.Windows.Forms.ToolStripMenuItem crearPeliculaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsPeliculas;
        private System.Windows.Forms.ToolStripMenuItem tsrCrearPelicula;
        private System.Windows.Forms.ToolStripMenuItem tsrVerPelicula;
        private System.Windows.Forms.ToolStripMenuItem tsrEliminarPelicula;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaDePeliculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmGeneros;
    }
}