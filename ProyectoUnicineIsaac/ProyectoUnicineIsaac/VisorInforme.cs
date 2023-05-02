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
    public partial class VisorInforme : Form
    {
        public VisorInforme()
        {
            InitializeComponent();
        }

        private void VisorInforme_Load(object sender, EventArgs e)
        {

            this.rpvInforme.RefreshReport();
            this.rpvInforme.RefreshReport();
        }
    }
}
