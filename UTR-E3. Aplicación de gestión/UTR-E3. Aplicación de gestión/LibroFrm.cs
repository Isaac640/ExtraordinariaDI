using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTR_E3.Aplicación_de_gestión
{
    public partial class LibroFrm : Form
    {
        private Libros lib;
        private LibroFrm()
        {
            InitializeComponent();
            lib = new Libros();
        }

        public LibroFrm(Libros libro) : this()
        {
            this.lib = libro;
            this.DialogResult = DialogResult.Cancel;

            this.txtTilulo.Text = string.Empty;
            this.txtAnio.Text = string.Empty;
            this.txtAutor.Text = string.Empty;
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.lib.Titulo = txtTilulo.Text;
            this.lib.Anno = int.Parse(txtAnio.Text);
            this.lib.Autor = txtAutor.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
