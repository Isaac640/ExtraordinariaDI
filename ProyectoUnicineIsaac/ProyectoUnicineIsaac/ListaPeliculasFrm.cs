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
        public ListaPeliculasFrm()
        {
            InitializeComponent();
            _cliente = new Cliente();
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
            foreach (ListViewItem item in lvPeliculas.SelectedItems)
            {
                int idPeli = (int)item.Tag;
                Pelicula peliculaSeleccionada = _cliente.ObtenerPelicula(idPeli);
                PeliculaFrm infoPelicula = new PeliculaFrm(peliculaSeleccionada);

                if (infoPelicula.ShowDialog() == DialogResult.OK)
                {
                    _cliente.ActualizarPelicula(peliculaSeleccionada);
                    RefrescarLista();
                }
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
    }
}
