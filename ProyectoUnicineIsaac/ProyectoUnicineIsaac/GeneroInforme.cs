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
            cbGenero.SelectedIndex = 0;
            this.DialogResult = DialogResult.Cancel;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._gen = cbGenero.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string cbGenero_Get()
        {
            return _gen;
        }
    }
}
