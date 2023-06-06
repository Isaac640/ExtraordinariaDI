using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUnicineIsaac
{
    public partial class PeliculaFrm : Form
    {
        private Pelicula peli;
        private PeliculaFrm()
        {
            InitializeComponent();
            peli = new Pelicula();
        }

        public PeliculaFrm(Pelicula pelicula) : this()
        {
            this.peli = pelicula;
            this.DialogResult = DialogResult.Cancel;

            this.txtNombre.Text = string.Empty;
            this.cmbCategoria.Text = string.Empty;
            this.cmbGenero.Text = string.Empty;
            this.txtDuracion.Text = string.Empty;
            this.txtAnno.Text = string.Empty;
            this.txtSinopsis.Text = string.Empty;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.peli.Nombre = this.txtNombre.Text;
            this.peli.Categoria = this.cmbCategoria.SelectedItem.ToString();
            this.peli.Genero = this.cmbGenero.SelectedItem.ToString();
            this.peli.Duracion = int.Parse(this.txtDuracion.Text);
            this.peli.Anno = int.Parse(this.txtAnno.Text);
            this.peli.Sinopsis = this.txtSinopsis.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
