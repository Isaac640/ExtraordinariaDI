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
    public partial class ListaProyeccionesFrm : Form
    {
        private Cliente _cliente;
        public ListaProyeccionesFrm()
        {
            InitializeComponent();
            _cliente = new Cliente();
            RefrescarLista();
        }

        private void RefrescarLista()
        {
            this.lvProyecciones.Items.Clear();
            _cliente.ObtenerPeliculas().ToList();

            foreach (Proyeccion proyeccion in _cliente.ObtenerProyecciones())
            {
                ListViewItem item = new ListViewItem(
                    new string[] {
                        proyeccion.SesionId.ToString(),
                        proyeccion.PeliculaId.ToString(),
                        proyeccion.Inicio.ToString(),
                        proyeccion.Fin.ToString()
                    }
                        );
                item.Tag = proyeccion.Inicio;
                this.lvProyecciones.Items.Add(item);
            }
        }

        private void tsmCrearProyeccion_Click(object sender, EventArgs e)
        {
            Proyeccion proyeccion = new Proyeccion();
            ProyeccionFrm proyeccionFrm = new ProyeccionFrm(proyeccion);
            if (proyeccionFrm.ShowDialog() == DialogResult.OK)
            {
                _cliente.CrearProyeccion(proyeccion);
                RefrescarLista();
            }
        }

        private void tsmVerProyeccion_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvProyecciones.SelectedItems)
            {
                int idProyeccion = (int)item.Tag;
                Proyeccion proyeccionSeleccionada = _cliente.ObtenerProyeccion(idProyeccion);
                ProyeccionFrm infoProyeccion = new ProyeccionFrm(proyeccionSeleccionada);

                if (infoProyeccion.ShowDialog() == DialogResult.OK)
                {
                    _cliente.ActualizarProyeccion(proyeccionSeleccionada);
                    RefrescarLista();
                }
            }
        }

        private void tsmEliminarProyeccion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere borrar esta proyeccion de la lista?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _cliente.EliminarProyeccion((int)this.lvProyecciones.SelectedItems[0].Tag);
            }
            RefrescarLista();
        }

        private void cmsProyeccion_Opening(object sender, CancelEventArgs e)
        {
            if (lvProyecciones.SelectedItems.Count == 1)
            {
                tsmEliminarProyeccion.Enabled = true;
                tsmVerProyeccion.Enabled = true;
            }
        }
    }
}
