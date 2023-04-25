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
    public partial class ListaSesionesFrm : Form
    {
        private Cliente _cliente;
        public ListaSesionesFrm()
        {
            InitializeComponent();
            _cliente = new Cliente();
            RefrescarLista();
        }

        private void RefrescarLista()
        {
            this.lvSesiones.Items.Clear();

            _cliente.ObtenerSesiones().ToList().ForEach(sesion =>
            {
                ListViewItem item = new ListViewItem(
                   new string[] {
                        sesion.Sala.ToString(),
                        sesion.DiaSemana.ToString(),
                        sesion.Comienzo.ToString(),
                        sesion.FinMax.ToString(),
                        sesion.Precio.ToString(),
                        sesion.Aforo.ToString()
                    }
                        );
                item.Tag = sesion.SesionId;
                this.lvSesiones.Items.Add(item);
            });
        }

        private void tsmCrearSesion_Click(object sender, EventArgs e)
        {
            Sesion sesion = new Sesion();
            SesionFrm sesionFrm = new SesionFrm(sesion);
            if (sesionFrm.ShowDialog() == DialogResult.OK)
            {
                _cliente.CrearSesion(sesion);
                RefrescarLista();
            }
        }

        private void tsmVerSesion_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvSesiones.SelectedItems)
            {
                int idSesion = (int)item.Tag;
                Sesion sesionSeleccionada = _cliente.ObtenerSesion(idSesion);
                SesionFrm infoSesion = new SesionFrm(sesionSeleccionada);

                if (infoSesion.ShowDialog() == DialogResult.OK)
                {
                    _cliente.ActualizarSesion(sesionSeleccionada);
                    RefrescarLista();
                }
            }
        }

        private void tsmEliminarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere borrar esta sesión de la lista?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _cliente.EliminarSesion((int)this.lvSesiones.SelectedItems[0].Tag);
            }
            RefrescarLista();
        }

        private void cmsSesion_Opening(object sender, CancelEventArgs e)
        {
            if (lvSesiones.SelectedItems.Count == 1)
            {
                tsmEliminarSesion.Enabled = true;
                tsmVerSesion.Enabled = true;
            }
        }
    }
}
