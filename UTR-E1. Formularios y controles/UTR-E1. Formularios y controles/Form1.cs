using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTR_E1.Formularios_y_controles
{
    public partial class Form1 : Form
    {
        private Socio _socio;
        public Form1()
        {
            InitializeComponent();
            _socio = new Socio();
            cmbSituacion.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._socio.Nombre = txtNombre.Text;
            this._socio.Nacimiento = dtpNacimiento.ToString();
            this._socio.Aficiones = txtAficionesOtros.Text;
            this._socio.Situacion = cmbSituacion.Text;

            Resumen resumen = new Resumen(_socio);
            resumen.ShowDialog();
        }
            private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtAficionesOtros.Text = "";
            dtpNacimiento.Text = "";
            rbHombre.Checked = true;
        }

        private void chkOtras_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOtras.Checked == true)
            {
                txtAficionesOtros.ReadOnly = false;
            }
        }

        private void chkDeportes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeportes.Checked == true)
            {
                txtAficionesOtros.Text = txtAficionesOtros.Text + "Deportes ";
            }
        }

        private void chkMusica_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMusica.Checked == true)
            {
                txtAficionesOtros.Text = txtAficionesOtros.Text + "Musica ";
            }
        }

        private void chkLectura_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLectura.Checked == true)
            {
                txtAficionesOtros.Text = txtAficionesOtros.Text + "Lectura ";
            }
        }

        private void rbHombre_CheckedChanged(object sender, EventArgs e)
        {
            this._socio.Sexo = sender.ToString();
        }
    }
}
