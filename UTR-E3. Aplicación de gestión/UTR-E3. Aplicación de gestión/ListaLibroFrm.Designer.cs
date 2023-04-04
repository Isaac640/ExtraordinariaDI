namespace UTR_E3.Aplicación_de_gestión
{
    partial class ListaLibroFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaLibroFrm));
            this.mnsLibros = new System.Windows.Forms.MenuStrip();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrCrearLibroMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lvLibros = new System.Windows.Forms.ListView();
            this.ColumnaTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaAnio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaAutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsLibros = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsrCrearLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrVerLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrBorrarLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsLibros.SuspendLayout();
            this.cmsLibros.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsLibros
            // 
            this.mnsLibros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem});
            this.mnsLibros.Location = new System.Drawing.Point(0, 0);
            this.mnsLibros.Name = "mnsLibros";
            this.mnsLibros.Size = new System.Drawing.Size(635, 24);
            this.mnsLibros.TabIndex = 1;
            this.mnsLibros.Text = "menuStrip1";
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrCrearLibroMenu});
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // tsrCrearLibroMenu
            // 
            this.tsrCrearLibroMenu.Name = "tsrCrearLibroMenu";
            this.tsrCrearLibroMenu.Size = new System.Drawing.Size(102, 22);
            this.tsrCrearLibroMenu.Text = "Crear";
            this.tsrCrearLibroMenu.Click += new System.EventHandler(this.tsrCrearLibro_Click);
            // 
            // lvLibros
            // 
            this.lvLibros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnaTitulo,
            this.ColumnaAnio,
            this.ColumnaAutor});
            this.lvLibros.HideSelection = false;
            this.lvLibros.Location = new System.Drawing.Point(0, 27);
            this.lvLibros.MultiSelect = false;
            this.lvLibros.Name = "lvLibros";
            this.lvLibros.Size = new System.Drawing.Size(635, 262);
            this.lvLibros.TabIndex = 0;
            this.lvLibros.UseCompatibleStateImageBehavior = false;
            this.lvLibros.View = System.Windows.Forms.View.Details;
            // 
            // ColumnaTitulo
            // 
            this.ColumnaTitulo.Tag = "ColumnaTitulo";
            this.ColumnaTitulo.Text = "Titulo";
            this.ColumnaTitulo.Width = 334;
            // 
            // ColumnaAnio
            // 
            this.ColumnaAnio.Tag = "ColumnaAnio";
            this.ColumnaAnio.Text = "Año";
            this.ColumnaAnio.Width = 72;
            // 
            // ColumnaAutor
            // 
            this.ColumnaAutor.Tag = "ColumnaAutor";
            this.ColumnaAutor.Text = "Autor";
            this.ColumnaAutor.Width = 221;
            // 
            // cmsLibros
            // 
            this.cmsLibros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrCrearLibro,
            this.tsrVerLibro,
            this.tsrBorrarLibro});
            this.cmsLibros.Name = "contextMenuStrip1";
            this.cmsLibros.Size = new System.Drawing.Size(107, 70);
            this.cmsLibros.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLibros_Opening);
            // 
            // tsrCrearLibro
            // 
            this.tsrCrearLibro.Image = ((System.Drawing.Image)(resources.GetObject("tsrCrearLibro.Image")));
            this.tsrCrearLibro.Name = "tsrCrearLibro";
            this.tsrCrearLibro.Size = new System.Drawing.Size(106, 22);
            this.tsrCrearLibro.Text = "Crear";
            this.tsrCrearLibro.Click += new System.EventHandler(this.tsrCrearLibro_Click);
            // 
            // tsrVerLibro
            // 
            this.tsrVerLibro.Enabled = false;
            this.tsrVerLibro.Image = ((System.Drawing.Image)(resources.GetObject("tsrVerLibro.Image")));
            this.tsrVerLibro.Name = "tsrVerLibro";
            this.tsrVerLibro.Size = new System.Drawing.Size(106, 22);
            this.tsrVerLibro.Text = "Ver";
            this.tsrVerLibro.Click += new System.EventHandler(this.tsrVerLibro_Click);
            // 
            // tsrBorrarLibro
            // 
            this.tsrBorrarLibro.Enabled = false;
            this.tsrBorrarLibro.Image = ((System.Drawing.Image)(resources.GetObject("tsrBorrarLibro.Image")));
            this.tsrBorrarLibro.Name = "tsrBorrarLibro";
            this.tsrBorrarLibro.Size = new System.Drawing.Size(106, 22);
            this.tsrBorrarLibro.Text = "Borrar";
            this.tsrBorrarLibro.Click += new System.EventHandler(this.tsrBorrarLibro_Click);
            // 
            // ListaLibroFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 289);
            this.ContextMenuStrip = this.cmsLibros;
            this.Controls.Add(this.mnsLibros);
            this.Controls.Add(this.lvLibros);
            this.MainMenuStrip = this.mnsLibros;
            this.Name = "ListaLibroFrm";
            this.Text = "Mantenimiento de libros";
            this.mnsLibros.ResumeLayout(false);
            this.mnsLibros.PerformLayout();
            this.cmsLibros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLibros;
        private System.Windows.Forms.ColumnHeader ColumnaTitulo;
        private System.Windows.Forms.ColumnHeader ColumnaAnio;
        private System.Windows.Forms.ColumnHeader ColumnaAutor;
        private System.Windows.Forms.ContextMenuStrip cmsLibros;
        private System.Windows.Forms.ToolStripMenuItem tsrCrearLibro;
        private System.Windows.Forms.MenuStrip mnsLibros;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsrCrearLibroMenu;
        private System.Windows.Forms.ToolStripMenuItem tsrVerLibro;
        private System.Windows.Forms.ToolStripMenuItem tsrBorrarLibro;
    }
}