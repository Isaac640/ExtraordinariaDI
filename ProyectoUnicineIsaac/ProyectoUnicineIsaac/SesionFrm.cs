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
    public partial class SesionFrm : Form
    {
        Sesion sesi;
        private SesionFrm()
        {
            InitializeComponent();
            sesi = new Sesion();
        }
        public SesionFrm(Sesion sesion) : this()
        {
            this.sesi = sesion;
            this.DialogResult = DialogResult.Cancel;

            this.cmbSalas.Text = string.Empty;
            this.cmbDia.Text = string.Empty;
            this.dtpComienzo.Text = string.Empty;
            this.dtpFin.Text = string.Empty;
            this.txtPrecio.Text = string.Empty;
            this.txtAforo.Text = string.Empty;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.sesi.Sala = this.cmbSalas.SelectedItem.ToString();
            this.sesi.DiaSemana = this.cmbDia.SelectedItem.ToString();
            this.sesi.Comienzo = this.dtpComienzo.Value;
            this.sesi.FinMax = this.dtpFin.Value;
            this.sesi.Precio = float.Parse(this.txtPrecio.Text);
            this.sesi.Aforo = int.Parse(this.txtAforo.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
