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
        public ListaPeliculasFrm()
        {
            InitializeComponent();
            RefrescarLista();
        }

        private void RefrescarLista()
        {
            this.lvPeliculas.Items.Clear();
            Herramientas.ObtenerPeliculas().ToList();

            foreach (Pelicula peli in Herramientas.ObtenerPeliculas())
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
            }
        }

        private void tsrCrearPelicula_Click(object sender, EventArgs e)
        {
            Pelicula peli = new Pelicula();
            PeliculaFrm peliculaFrm = new PeliculaFrm(peli);
            if (peliculaFrm.ShowDialog() == DialogResult.OK)
            {
                Herramientas.CrearPelicula(peli);
                RefrescarLista();
            }
        }
    }
}
