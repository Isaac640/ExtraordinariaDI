namespace UTR_E3.Aplicación_de_gestión
{
    partial class ListaPeliculaFrm
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
            this.lvPeliculas = new System.Windows.Forms.ListView();
            this.ColumnaTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaAnio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnsPeliculas = new System.Windows.Forms.MenuStrip();
            this.películasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrCrearPeliculaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPeliculas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsrCrearPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrVerPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrBorrarPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPeliculas.SuspendLayout();
            this.cmsPeliculas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPeliculas
            // 
            this.lvPeliculas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnaTitulo,
            this.ColumnaAnio,
            this.ColumnaGenero});
            this.lvPeliculas.HideSelection = false;
            this.lvPeliculas.Location = new System.Drawing.Point(-1, 27);
            this.lvPeliculas.MultiSelect = false;
            this.lvPeliculas.Name = "lvPeliculas";
            this.lvPeliculas.Size = new System.Drawing.Size(636, 263);
            this.lvPeliculas.TabIndex = 0;
            this.lvPeliculas.UseCompatibleStateImageBehavior = false;
            this.lvPeliculas.View = System.Windows.Forms.View.Details;
            // 
            // ColumnaTitulo
            // 
            this.ColumnaTitulo.Text = "Título";
            // 
            // ColumnaAnio
            // 
            this.ColumnaAnio.Text = "Año";
            // 
            // ColumnaGenero
            // 
            this.ColumnaGenero.Text = "Género";
            // 
            // mnsPeliculas
            // 
            this.mnsPeliculas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.películasToolStripMenuItem});
            this.mnsPeliculas.Location = new System.Drawing.Point(0, 0);
            this.mnsPeliculas.Name = "mnsPeliculas";
            this.mnsPeliculas.Size = new System.Drawing.Size(635, 24);
            this.mnsPeliculas.TabIndex = 1;
            this.mnsPeliculas.Text = "menuStrip1";
            // 
            // películasToolStripMenuItem
            // 
            this.películasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrCrearPeliculaMenu});
            this.películasToolStripMenuItem.Name = "películasToolStripMenuItem";
            this.películasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.películasToolStripMenuItem.Text = "Películas";
            // 
            // tsrCrearPeliculaMenu
            // 
            this.tsrCrearPeliculaMenu.Name = "tsrCrearPeliculaMenu";
            this.tsrCrearPeliculaMenu.Size = new System.Drawing.Size(180, 22);
            this.tsrCrearPeliculaMenu.Text = "Crear";
            this.tsrCrearPeliculaMenu.Click += new System.EventHandler(this.tsrCrearPelicula_Click);
            // 
            // cmsPeliculas
            // 
            this.cmsPeliculas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrCrearPelicula,
            this.tsrVerPelicula,
            this.tsrBorrarPelicula});
            this.cmsPeliculas.Name = "cmsPeliculas";
            this.cmsPeliculas.Size = new System.Drawing.Size(107, 70);
            this.cmsPeliculas.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPeliculas_Opening);
            // 
            // tsrCrearPelicula
            // 
            this.tsrCrearPelicula.Name = "tsrCrearPelicula";
            this.tsrCrearPelicula.Size = new System.Drawing.Size(106, 22);
            this.tsrCrearPelicula.Text = "Crear";
            this.tsrCrearPelicula.Click += new System.EventHandler(this.tsrCrearPelicula_Click);
            // 
            // tsrVerPelicula
            // 
            this.tsrVerPelicula.Enabled = false;
            this.tsrVerPelicula.Name = "tsrVerPelicula";
            this.tsrVerPelicula.Size = new System.Drawing.Size(106, 22);
            this.tsrVerPelicula.Text = "Ver";
            this.tsrVerPelicula.Click += new System.EventHandler(this.tsrVerPelicula_Click);
            // 
            // tsrBorrarPelicula
            // 
            this.tsrBorrarPelicula.Enabled = false;
            this.tsrBorrarPelicula.Name = "tsrBorrarPelicula";
            this.tsrBorrarPelicula.Size = new System.Drawing.Size(106, 22);
            this.tsrBorrarPelicula.Text = "Borrar";
            this.tsrBorrarPelicula.Click += new System.EventHandler(this.tsrBorrarPelicula_Click);
            // 
            // ListaPeliculaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 289);
            this.ContextMenuStrip = this.cmsPeliculas;
            this.Controls.Add(this.lvPeliculas);
            this.Controls.Add(this.mnsPeliculas);
            this.MainMenuStrip = this.mnsPeliculas;
            this.Name = "ListaPeliculaFrm";
            this.Text = "ListaPeliculaFrm";
            this.mnsPeliculas.ResumeLayout(false);
            this.mnsPeliculas.PerformLayout();
            this.cmsPeliculas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPeliculas;
        private System.Windows.Forms.MenuStrip mnsPeliculas;
        private System.Windows.Forms.ColumnHeader ColumnaTitulo;
        private System.Windows.Forms.ColumnHeader ColumnaAnio;
        private System.Windows.Forms.ColumnHeader ColumnaGenero;
        private System.Windows.Forms.ToolStripMenuItem películasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsrCrearPeliculaMenu;
        private System.Windows.Forms.ContextMenuStrip cmsPeliculas;
        private System.Windows.Forms.ToolStripMenuItem tsrCrearPelicula;
        private System.Windows.Forms.ToolStripMenuItem tsrVerPelicula;
        private System.Windows.Forms.ToolStripMenuItem tsrBorrarPelicula;
    }
}