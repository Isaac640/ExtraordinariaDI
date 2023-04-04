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
        public ListaPeliculaFrm()
        {
            InitializeComponent();
        }

        private void RefrescarLista()
        {
            this.lvPeliculas.Items.Clear();
            Negocio.ObtenerPeliculas().ToList();

            foreach (Peliculas peli in Negocio.ObtenerPeliculas())
            {
                ListViewItem item = new ListViewItem(
                    new string[] {
                    peli.Titulo.ToString(),
                    peli.Anno.ToString(),
                    peli.Genero.ToString()
                    }
                        );
                item.Tag = peli.PeliculaId;
                this.lvPeliculas.Items.Add(item);
            }
        }

        private void tsrCrearPelicula_Click(object sender, EventArgs e)
        {
            Peliculas peli = new Peliculas();
            PeliculaFrm peliculaFrm = new PeliculaFrm(peli);
            if (peliculaFrm.ShowDialog() == DialogResult.OK)
            {
                Negocio.CrearPelicula(peli);
                RefrescarLista();
            }
        }

        private void tsrVerPelicula_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvPeliculas.SelectedItems)
            {
                int idPelicula = (int)item.Tag;
                Peliculas peliculaSeleccionada = Negocio.ObtenerPelicula(idPelicula);
                PeliculaFrm infoPelicula = new PeliculaFrm(peliculaSeleccionada);

                if (infoPelicula.ShowDialog() == DialogResult.OK)
                {
                    Negocio.ActualizarPelicula(peliculaSeleccionada);
                    RefrescarLista();
                }
            }
        }

        private void tsrBorrarPelicula_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Seguro que quiere borrar esta pelicula de la lista?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Negocio.BorrarPelicula((int)this.lvPeliculas.SelectedItems[0].Tag);
                RefrescarLista();
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
