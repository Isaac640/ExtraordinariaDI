using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UTR_E10.WPF.Aplicación_de_gestión
{
    /// <summary>
    /// Lógica de interacción para UCIncidenciaHW.xaml
    /// </summary>
    public partial class UCIncidenciaHW : UserControl
    {
        private IncidenciaHW _incidenciaHW;
        public UCIncidenciaHW()
        {
            InitializeComponent();
            _incidenciaHW = new IncidenciaHW();
            dtpFecha.Text = string.Empty;
        }

        public UCIncidenciaHW(IncidenciaHW incidenciaHW) : this()
        {
            _incidenciaHW = incidenciaHW;
            if (incidenciaHW == null)
            {
                this.txtDesc.Text = string.Empty;
                this.txtObserv.Text = string.Empty;
                this.dtpFecha.Text = string.Empty;
                this.txtEtiqueta.Text = string.Empty;
            }
            if (incidenciaHW != null)
            {
                this.txtDesc.Text = incidenciaHW.Descripcion;
                this.txtObserv.Text = incidenciaHW.Observaciones;
                this.dtpFecha.Text = incidenciaHW.Fecha.ToString();
                this.txtEtiqueta.Text = incidenciaHW.Etiqueta;
                this.cbCerrada.IsChecked = incidenciaHW.Cerrada;
                this.cbEnciende.IsChecked = incidenciaHW.Enciende;

                //Duele ver esto
                if (incidenciaHW.Clase == TipoHardwareEnum.Torre)
                {
                    this.rbTorre.IsChecked = true;
                }
                if (incidenciaHW.Clase == TipoHardwareEnum.Impresora)
                {
                    this.rbImpresora.IsChecked = true;
                }
                if (incidenciaHW.Clase == TipoHardwareEnum.Red)
                {
                    this.rbRed.IsChecked = true;
                }
            }

        }
        private bool validacion()
        {
            bool valido = false;
            if (string.IsNullOrEmpty(txtDesc.Text) ||
                string.IsNullOrEmpty(dtpFecha.Text) ||
                string.IsNullOrEmpty(txtEtiqueta.Text) ||
                string.IsNullOrEmpty(txtObserv.Text))
            {
                MessageBox.Show("Advertencia", "Algunos campos no estan rellenados", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                valido = true;
            }
            return valido;
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            this.txtDesc.Text = string.Empty;
            this.txtObserv.Text = string.Empty;
            this.dtpFecha.Text = string.Empty;
            this.txtEtiqueta.Text = string.Empty;
            this.cbCerrada.IsChecked = false;
            this.cbEnciende.IsChecked = false;
            this.rbTorre.IsChecked = false;
            this.rbImpresora.IsChecked = false; 
            this.rbRed.IsChecked = false; 
        } 

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (validacion())
            {
                this._incidenciaHW.Enciende = this.cbEnciende.IsChecked.Value;
                this._incidenciaHW.Cerrada = this.cbCerrada.IsChecked.Value;
                this._incidenciaHW.Descripcion = this.txtDesc.Text;
                this._incidenciaHW.Etiqueta = this.txtEtiqueta.Text;
                this._incidenciaHW.Observaciones = this.txtObserv.Text;
                this._incidenciaHW.Fecha = this.dtpFecha.SelectedDate.Value;

            }
        }
    }
}
