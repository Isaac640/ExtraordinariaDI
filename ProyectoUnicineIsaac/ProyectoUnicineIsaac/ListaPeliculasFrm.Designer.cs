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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.peliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvPeliculas = new System.Windows.Forms.ListView();
            this.informeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duracion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Anno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsrCrearPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrVerPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrEliminarPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPeliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculasToolStripMenuItem,
            this.informeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // peliculasToolStripMenuItem
            // 
            this.peliculasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearPeliculaToolStripMenuItem});
            this.peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
            this.peliculasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.peliculasToolStripMenuItem.Text = "Peliculas";
            // 
            // lvPeliculas
            // 
            this.lvPeliculas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Categoria,
            this.Genero,
            this.Duracion,
            this.Anno});
            this.lvPeliculas.ContextMenuStrip = this.contextMenuStrip1;
            this.lvPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPeliculas.HideSelection = false;
            this.lvPeliculas.Location = new System.Drawing.Point(0, 24);
            this.lvPeliculas.Name = "lvPeliculas";
            this.lvPeliculas.Size = new System.Drawing.Size(621, 327);
            this.lvPeliculas.TabIndex = 1;
            this.lvPeliculas.UseCompatibleStateImageBehavior = false;
            this.lvPeliculas.View = System.Windows.Forms.View.Details;
            // 
            // informeToolStripMenuItem
            // 
            this.informeToolStripMenuItem.Name = "informeToolStripMenuItem";
            this.informeToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.informeToolStripMenuItem.Text = "Informe";
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrCrearPelicula,
            this.tsrVerPelicula,
            this.tsrEliminarPelicula});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // tsrCrearPelicula
            // 
            this.tsrCrearPelicula.Name = "tsrCrearPelicula";
            this.tsrCrearPelicula.Size = new System.Drawing.Size(180, 22);
            this.tsrCrearPelicula.Text = "Crear";
            this.tsrCrearPelicula.Click += new System.EventHandler(this.tsrCrearPelicula_Click);
            // 
            // tsrVerPelicula
            // 
            this.tsrVerPelicula.Name = "tsrVerPelicula";
            this.tsrVerPelicula.Size = new System.Drawing.Size(180, 22);
            this.tsrVerPelicula.Text = "Ver";
            // 
            // tsrEliminarPelicula
            // 
            this.tsrEliminarPelicula.Name = "tsrEliminarPelicula";
            this.tsrEliminarPelicula.Size = new System.Drawing.Size(180, 22);
            this.tsrEliminarPelicula.Text = "Eliminar";
            // 
            // crearPeliculaToolStripMenuItem
            // 
            this.crearPeliculaToolStripMenuItem.Name = "crearPeliculaToolStripMenuItem";
            this.crearPeliculaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearPeliculaToolStripMenuItem.Text = "Crear Pelicula";
            // 
            // ListaPeliculasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 351);
            this.Controls.Add(this.lvPeliculas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListaPeliculasFrm";
            this.Text = "ListaPeliculasFrm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peliculasToolStripMenuItem;
        private System.Windows.Forms.ListView lvPeliculas;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Categoria;
        private System.Windows.Forms.ColumnHeader Genero;
        private System.Windows.Forms.ColumnHeader Duracion;
        private System.Windows.Forms.ColumnHeader Anno;
        private System.Windows.Forms.ToolStripMenuItem crearPeliculaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsrCrearPelicula;
        private System.Windows.Forms.ToolStripMenuItem tsrVerPelicula;
        private System.Windows.Forms.ToolStripMenuItem tsrEliminarPelicula;
    }
}