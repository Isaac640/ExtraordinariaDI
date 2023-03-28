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
    public partial class Resumen : Form
    {
        private Socio _socio;
        public Resumen(Socio socio)
        {
            InitializeComponent();
            this._socio = socio;
            asignar();
        }

        private void asignar()
        {
            txtNombre.Text = _socio.Nombre;
            txtNacimiento.Text = _socio.Nacimiento;
            txtSexo.Text = _socio.Sexo;

        }

    }
}
