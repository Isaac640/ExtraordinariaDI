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
    public partial class BuscarPeliculaFrm : Form
    {
        private Cliente _cliente;
        private Pelicula _pelicula;
        public BuscarPeliculaFrm()
        {
            InitializeComponent();
            _cliente = new Cliente();
            this.DialogResult = DialogResult.Cancel;
            RefrescarLista();
        }

        public Pelicula peliculaSeleccionada
        {
            get { return _pelicula; } 
            set { peliculaSeleccionada = _pelicula; }
        }

        private void RefrescarLista()
        {
            this.lvPeliculas.Items.Clear();
            
            _cliente.ObtenerPeliculas().ToList().ForEach(peli =>
            {
                ListViewItem item = new ListViewItem(
                   new string[] {
                    peli.Nombre.ToString(),
                    peli.PeliculaId.ToString()
                    }
                        );
                item.Tag = peli.PeliculaId;
                this.lvPeliculas.Items.Add(item);
            });
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvPeliculas.SelectedItems.Count > 0)
            {
                //localizar a partir del id de la lista la pelicula entera
                ListViewItem peliSeleccionada = lvPeliculas.SelectedItems[0];

                int id = (int)peliSeleccionada.Tag;

                this._pelicula = _cliente.ObtenerPelicula(id);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
