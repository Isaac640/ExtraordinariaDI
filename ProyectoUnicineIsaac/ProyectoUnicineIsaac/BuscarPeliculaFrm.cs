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
        private int _id;
        private string _nom;
        private BuscarPeliculaFrm()
        {
            InitializeComponent();
            _cliente = new Cliente();
            _id = 0;
            _nom = "";
            RefrescarLista();
        }

        public BuscarPeliculaFrm(int idPeli, string nombre) : this()
        {
            this._id = idPeli;
            this._nom = nombre;
            this.DialogResult = DialogResult.Cancel;
        }

        private void RefrescarLista()
        {
            this.lvPeliculas.Items.Clear();
            _cliente.ObtenerPeliculas().ToList();
            //Hacer con where
            foreach (Pelicula peli in _cliente.ObtenerPeliculas())
            {
                ListViewItem item = new ListViewItem(
                    new string[] {
                    peli.Nombre.ToString(),
                    peli.PeliculaId.ToString()
                    }
                        );
                item.Tag = peli.PeliculaId;
                this.lvPeliculas.Items.Add(item);
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvPeliculas.SelectedItems.Count > 0)
            {
                ListViewItem peliSeleccionada = lvPeliculas.SelectedItems[0];
                this._nom = peliSeleccionada.SubItems[0].Text;
                this._id = _cliente.ObtenerIdPeliculaPorNombre(_nom);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
