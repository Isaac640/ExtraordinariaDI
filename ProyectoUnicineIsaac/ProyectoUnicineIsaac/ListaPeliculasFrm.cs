using ProyectoUnicineIsaac.Reports;
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
    public partial class ListaPeliculasFrm : Form
    {
        private Cliente _cliente;
        private Generador _generador;
        public ListaPeliculasFrm()
        {
            InitializeComponent();
            _cliente = new Cliente();
            _generador = new Generador();
            RefrescarLista();
        }

        private void RefrescarLista()
        {
            this.lvPeliculas.Items.Clear();

            _cliente.ObtenerPeliculas().ToList().ForEach(peli =>
            {
                ListViewItem item = new ListViewItem(
                    new string[] {
                    peli.Nombre.ToString(),
                    peli.Categoria.ToString(),
                    peli.Genero.ToString(),
                    peli.Duracion.ToString(),
                    peli.Anno.ToString()
                    }
                        );
                item.Tag = peli.PeliculaId;
                this.lvPeliculas.Items.Add(item);
            });
        }

        private void tsrCrearPelicula_Click(object sender, EventArgs e)
        {
            Pelicula peli = new Pelicula();
            PeliculaFrm peliculaFrm = new PeliculaFrm(peli);
            if (peliculaFrm.ShowDialog() == DialogResult.OK)
            {
                _cliente.CrearPelicula(peli);
                RefrescarLista();
            }
        }

        private void tsrVerPelicula_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lvPeliculas.SelectedItems.Count)
            {
                ListViewItem item = lvPeliculas.SelectedItems[i];
                int idPeli = (int)item.Tag;
                Pelicula peliculaSeleccionada = _cliente.ObtenerPelicula(idPeli);
                PeliculaFrm infoPelicula = new PeliculaFrm(peliculaSeleccionada);

                if (infoPelicula.ShowDialog() == DialogResult.OK)
                {
                    _cliente.ActualizarPelicula(peliculaSeleccionada);
                    RefrescarLista();
                }

                i++;
            }
        }

        private void tsrEliminarPelicula_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere borrar esta pelicula de la lista?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _cliente.EliminarPelicula((int)this.lvPeliculas.SelectedItems[0].Tag);
            }
            RefrescarLista();
        }

        private void cmsPeliculas_Opening(object sender, CancelEventArgs e)
        {
            if (lvPeliculas.SelectedItems.Count == 1)
            {
                tsrEliminarPelicula.Enabled = true;
                tsrVerPelicula.Enabled = true;
            }
        }

        private void fichaDePeliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (lvPeliculas.SelectedItems.Count > 0)
            {
                //localizar a partir del id de la lista la pelicula entera
                ListViewItem peliSeleccionada = lvPeliculas.SelectedItems[0];

                int id = (int)peliSeleccionada.Tag;

                _generador.CargarInformePeliculas(id);
            }
        }

        private void tsmCategorias_Click(object sender, EventArgs e)
        {
            GeneroInforme generoInforme = new GeneroInforme();
            if (generoInforme.ShowDialog() == DialogResult.OK)
            {
                _generador.CargarCategorias(generoInforme.cbGenero_Get());
            }

        }
    }
}
