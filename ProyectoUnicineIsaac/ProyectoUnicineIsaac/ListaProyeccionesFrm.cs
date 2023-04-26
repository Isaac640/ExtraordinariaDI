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
            _cliente.ObtenerProyecciones().ToList().ForEach(proyeccion =>
            {
                ListViewItem item = new ListViewItem(
                   new string[] {
                        proyeccion.SesionId.ToString(),
                        proyeccion.PeliculaId.ToString(),
                        proyeccion.Inicio.ToString(),
                        proyeccion.Fin.ToString()
                    }
                        );
                item.Tag = proyeccion;
                this.lvProyecciones.Items.Add(item);
            });
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
                Proyeccion proyeccion = (Proyeccion)lvProyecciones.SelectedItems[0].Tag;
                ProyeccionFrm infoProyeccion = new ProyeccionFrm(proyeccion);

                if (infoProyeccion.ShowDialog() == DialogResult.OK)
                {
                    _cliente.ActualizarProyeccion(proyeccion);
                    RefrescarLista();
                }
            }
        }

        private void tsmEliminarProyeccion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere borrar esta proyeccion de la lista?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Proyeccion pro = (Proyeccion)lvProyecciones.SelectedItems[0].Tag;
                _cliente.EliminarProyeccion(pro);
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
