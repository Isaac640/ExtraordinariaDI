using ProyectoUnicineIsaac.Reports;
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
    public partial class GeneroInforme : Form
    {
        private string _gen;
        public GeneroInforme()
        {
            InitializeComponent();
            _gen = "";
        }

        public GeneroInforme(string genero) : this()
        {
            InitializeComponent();
            this._gen = genero;
            this.DialogResult = DialogResult.Cancel;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._gen = this.cbGenero.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
