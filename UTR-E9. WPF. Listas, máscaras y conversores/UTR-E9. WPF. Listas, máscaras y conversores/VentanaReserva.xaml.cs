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
using System.Windows.Shapes;

namespace UTR_E9.WPF.Listas__máscaras_y_conversores
{
    /// <summary>
    /// Lógica de interacción para VentanaReserva.xaml
    /// </summary>
    public partial class VentanaReserva : Window
    {
        private Reserva _reserva;
        private VentanaReserva()
        {
            InitializeComponent();
            _reserva = new Reserva();
            dtpFecha.SelectedDate = DateTime.Today;
        }

        public VentanaReserva(Reserva reserva) : this()
        {
            this._reserva = reserva;

            if (reserva == null)
            {
                this.txtNombre.Text = string.Empty;
                this.txtComensales.Text = string.Empty;
                this.txtTlfn.Text = string.Empty;
                this.txtObservaciones.Text = string.Empty;
                this.cbAsistencia.IsChecked = false;
            }

            if (reserva != null)
            {
                this.txtNombre.Text = reserva.Nombre;
                this.txtComensales.Text = reserva.Comensales.ToString();
                this.txtTlfn.Text = reserva.Telefono;
                this.txtObservaciones.Text = reserva.Observaciones;
                this.dtpFecha.Text = reserva.Fecha.ToString();
                this.cbAsistencia.IsChecked = reserva.Asiste;
            }

        }


        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (validacion() == true)
            {
                this._reserva.Nombre = this.txtNombre.Text;
                this._reserva.Comensales = int.Parse(this.txtComensales.Text);
                this._reserva.Telefono = this.txtTlfn.Text;
                this._reserva.Observaciones = this.txtObservaciones.Text;
                this._reserva.Asiste = this.cbAsistencia.IsChecked.Value;
                this._reserva.Fecha = this.dtpFecha.SelectedDate.Value;

                this.DialogResult = true;
            }

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private bool validacion()
        {
            bool valido = false;
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(dtpFecha.Text) ||
                string.IsNullOrEmpty(txtTlfn.Text) ||
                string.IsNullOrEmpty(txtComensales.Text))
            {
                MessageBox.Show("Advertencia", "Los campos de Nombre, Fecha, Telefono y Comensales son obligatorios", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                valido = true;
            }
            return valido;
        }

        private void txtComensales_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (!IsNumericKey(e.Key) && e.Key != Key.Back && e.Key != Key.Tab)
            {
                e.Handled = true;
            }
        }
        private bool IsNumericKey(Key key)
        {
            return (key >= Key.D0 && key <= Key.D9) || (key >= Key.NumPad0 && key <= Key.NumPad9);
        }
    }
}
