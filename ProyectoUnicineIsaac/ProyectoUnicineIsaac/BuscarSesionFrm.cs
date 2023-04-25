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
    public partial class BuscarSesionFrm : Form
    {
        private Cliente _cliente;
        private Sesion _sesion;
        public BuscarSesionFrm()
        {
            InitializeComponent();
            _cliente = new Cliente();
            RefrescarLista();
        }

        public Sesion sesionSeleccionada
        {
            get { return _sesion; }
            set { sesionSeleccionada = _sesion; }
        }

        private void RefrescarLista()
        {
            this.lvSesiones.Items.Clear();

            _cliente.ObtenerSesiones().ToList().ForEach(sesion =>
            {
                ListViewItem item = new ListViewItem(
                   new string[] {
                    sesion.SesionId.ToString(),
                    sesion.Sala.ToString(),
                    sesion.DiaSemana.ToString(),
                    sesion.Comienzo.ToString(),
                    sesion.Aforo.ToString()
                    }
                        );
                item.Tag = sesion.SesionId;
                this.lvSesiones.Items.Add(item);
            });
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvSesiones.SelectedItems.Count > 0)
            {
                ListViewItem sesionSeleccionada = lvSesiones.SelectedItems[0];

                int id = (int)sesionSeleccionada.Tag;
                this._sesion = _cliente.ObtenerSesion(id);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
