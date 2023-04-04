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
    public partial class ListaLibroFrm : Form
    {
        public ListaLibroFrm()
        {
            InitializeComponent();
        }

        private void RefrescarLista()
        {
            this.lvLibros.Items.Clear();

            foreach (Libros libro in Negocio.ObtenerLibros())
            {
                ListViewItem item = new ListViewItem(
                    new string[] {
                    libro.Titulo.ToString(),
                    libro.Anno.ToString(),
                    libro.Autor.ToString()
                    }
                        );
                item.Tag = libro.LibroId;
                this.lvLibros.Items.Add(item);
            }
        }

        private void tsrCrearLibro_Click(object sender, EventArgs e)
        {
            Libros libro = new Libros();
            LibroFrm formLibro = new LibroFrm(libro);
            if (formLibro.ShowDialog() == DialogResult.OK)
            {
                Negocio.CrearLibro(libro);
                RefrescarLista();
            }
        }

        private void tsrVerLibro_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvLibros.SelectedItems)
            {
                int idLibro = (int)item.Tag;
                Libros libroSeleccionado = Negocio.ObtenerLibro(idLibro);
                LibroFrm infoLibro = new LibroFrm(libroSeleccionado);

                if (infoLibro.ShowDialog() == DialogResult.OK)
                {
                    Negocio.ActualizarLibro(libroSeleccionado);
                    RefrescarLista();
                }
            }
        }

        private void tsrBorrarLibro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere borrar este libro de la lista?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Negocio.BorrarLibro((int)this.lvLibros.SelectedItems[0].Tag);
            }
            RefrescarLista();
        }

        private void cmsLibros_Opening(object sender, CancelEventArgs e)
        {
            if (lvLibros.SelectedItems.Count == 1)
            {
                tsrBorrarLibro.Enabled = true;
                tsrVerLibro.Enabled = true;
            }
        }
    }
}
