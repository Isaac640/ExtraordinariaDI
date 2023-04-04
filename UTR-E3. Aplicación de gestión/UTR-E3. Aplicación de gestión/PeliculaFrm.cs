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
        private Peliculas peli;
        private PeliculaFrm()
        {
            InitializeComponent();
            peli = new Peliculas();
        }
        public PeliculaFrm(Peliculas pelicula) : this()
        {
            this.peli = pelicula;
            this.DialogResult = DialogResult.Cancel;

            this.txtTilulo.Text = string.Empty;
            this.txtAnio.Text = string.Empty;
            this.txtGenero.Text = string.Empty;
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.peli.Titulo = this.txtTilulo.Text;
            this.peli.Anno = int.Parse(this.txtAnio.Text);
            this.peli.Genero = this.txtGenero.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
