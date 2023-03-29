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
    public partial class CatalogoFrm : Form
    {
        public CatalogoFrm()
        {
            InitializeComponent();
        }

        //ARCHIVO

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //MANTENIMIENTO

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaLibroFrm listaLibro = new ListaLibroFrm();
            listaLibro.MdiParent= this;
            listaLibro.Show();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPeliculaFrm listaPelicula = new ListaPeliculaFrm();
            listaPelicula.MdiParent= this;
            listaPelicula.Show();
        }

        //VENTANAS

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
