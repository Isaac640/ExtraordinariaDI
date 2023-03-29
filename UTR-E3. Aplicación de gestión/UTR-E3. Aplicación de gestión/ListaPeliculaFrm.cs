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
    public partial class ListaPeliculaFrm : Form
    {
        private Peliculas peli;
        public ListaPeliculaFrm()
        {
            InitializeComponent();
            peli = new Peliculas();
        }

        private void tsrCrearPelicula_Click(object sender, EventArgs e)
        {
            PeliculaFrm peliculaFrm = new PeliculaFrm(peli);
            peliculaFrm.ShowDialog();
        }

        private void tsrVerPelicula_Click(object sender, EventArgs e)
        {

        }

        private void tsrBorrarPelicula_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Seguro que quiere borrar esta pelicula de la lista?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Negocio.BorrarPelicula((int)this.lvPeliculas.SelectedItems[0].Tag);
            }

        }

        private void cmsPeliculas_Opening(object sender, CancelEventArgs e)
        {
            if (lvPeliculas.SelectedItems.Count == 1)
            {
                tsrBorrarPelicula.Enabled = true;
                tsrVerPelicula.Enabled = true;
            }
        }
    }
}
