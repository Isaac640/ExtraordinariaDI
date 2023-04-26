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
        Pelicula _pelicula;
        Sesion _sesion;
        public ProyeccionFrm()
        {
            InitializeComponent();
            pro = new Proyeccion();
            _pelicula = new Pelicula();
            _sesion = new Sesion();
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
            this.pro.SesionId = _sesion.SesionId;
            this.pro.PeliculaId = _pelicula.PeliculaId;
            this.pro.Inicio = this.dtpInicio.Value.Date;
            this.pro.Fin = this.dtpFin.Value.Date;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarSesion_Click(object sender, EventArgs e)
        {
            BuscarSesionFrm buscarSesionFrm = new BuscarSesionFrm();
            if (buscarSesionFrm.ShowDialog() == DialogResult.OK)
            {
                _sesion = buscarSesionFrm.sesionSeleccionada;
                txtSesion.Text = _sesion.Sala;
            }
        }

        private void btnBuscarPelicula_Click(object sender, EventArgs e)
        {
            BuscarPeliculaFrm buscarPeliFrm = new BuscarPeliculaFrm();
            if (buscarPeliFrm.ShowDialog() == DialogResult.OK)
            {
                _pelicula = buscarPeliFrm.peliculaSeleccionada;
                txtPelicula.Text = _pelicula.Nombre;
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dtpFin.CustomFormat = " ";
        }
    }
}
