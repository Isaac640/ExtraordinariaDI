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
        Libros lib;
        private LibroFrm()
        {
            InitializeComponent();
            lib = new Libros();
        }

        public LibroFrm(Libros libro)
        {
            lib = libro;
            libro.Titulo = this.txtTilulo.Text;
            libro.Anno = int.Parse(this.txtAnio.Text);
            libro.Autor = this.txtAutor.Text;
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            lib.Titulo = txtTilulo.Text;
            lib.Anno = int.Parse(txtAnio.Text);
            lib.Autor = txtAutor.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
