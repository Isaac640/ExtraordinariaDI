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
    public partial class UnicineFrm : Form
    {
        public UnicineFrm()
        {
            InitializeComponent();
        }

        private void películasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPeliculasFrm listaPelicula = new ListaPeliculasFrm();
            listaPelicula.MdiParent = this;
            listaPelicula.Show();
        }
        private void sesionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaSesionesFrm listaSesiones = new ListaSesionesFrm();
            listaSesiones.MdiParent = this;
            listaSesiones.Show();
        }
        private void proyeccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaProyeccionesFrm listaProyecciones = new ListaProyeccionesFrm();
            listaProyecciones.MdiParent = this;
            listaProyecciones.Show();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
