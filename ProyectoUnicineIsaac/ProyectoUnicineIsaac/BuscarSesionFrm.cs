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
        private int _id;
        public BuscarSesionFrm()
        {
            InitializeComponent();
            _id = new int();
            _cliente = new Cliente();
            RefrescarLista();
        }

        public BuscarSesionFrm(int id) : this()
        {
            this._id = id;
        }

        private void RefrescarLista()
        {
            this.lvSesiones.Items.Clear();
            _cliente.ObtenerSesiones().ToList();

            foreach (Sesion sesion in _cliente.ObtenerSesiones())
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
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvSesiones.SelectedItems.Count > 0)
            {
                ListViewItem sesionSeleccionada = lvSesiones.SelectedItems[0];
                this._id = int.Parse(sesionSeleccionada.SubItems[0].Text);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
