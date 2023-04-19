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
    public partial class ProyeccionFrm : Form
    {
        Proyeccion pro;
        int idPeli;
        int idSesion;
        string nombrePeli;
        string nombreSesion;
        public ProyeccionFrm()
        {
            InitializeComponent();
            idPeli = 0;
            idSesion = 0;
            nombrePeli = "";
            pro = new Proyeccion();
        }

        public ProyeccionFrm(Proyeccion proyeccion) : this()
        {
            this.pro = proyeccion;
            this.DialogResult = DialogResult.Cancel;

            this.txtSesion.Text = string.Empty;
            this.txtPelicula.Text = string.Empty;
            this.dtpInicio.Text = string.Empty;
            this.dtpFin.Text = string.Empty;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.pro.SesionId = idSesion;
            this.pro.PeliculaId = idPeli;
            this.pro.Inicio = this.dtpInicio.Value;
            this.pro.Fin = this.dtpFin.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarSesion_Click(object sender, EventArgs e)
        {
            BuscarSesionFrm buscarSesionFrm = new BuscarSesionFrm(idSesion);
            if (buscarSesionFrm.ShowDialog() == DialogResult.OK)
            {
                txtSesion.Text = idSesion.ToString();
            }
        }

        private void btnBuscarPelicula_Click(object sender, EventArgs e)
        {
            BuscarPeliculaFrm buscarPeliFrm = new BuscarPeliculaFrm(idPeli, nombrePeli);
            if (buscarPeliFrm.ShowDialog() == DialogResult.OK)
            {
                txtPelicula.Text = nombrePeli;
            }

        }
    }
}
