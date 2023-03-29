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
    public partial class PeliculaFrm : Form
    {
        Peliculas peli;
        private PeliculaFrm()
        {
            InitializeComponent();
            peli = new Peliculas();
        }
        public PeliculaFrm(Peliculas pelicula)
        {
            peli = pelicula;
            pelicula.Titulo = this.txtTilulo.Text;
            pelicula.Anno = int.Parse(this.txtAnio.Text);
            pelicula.Genero = this.txtGenero.Text;
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            peli.Titulo = txtTilulo.Text;
            peli.Anno = int.Parse(txtAnio.Text);
            peli.Genero = txtGenero.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
