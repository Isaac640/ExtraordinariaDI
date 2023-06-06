using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace UTR_E8.WPF.Maquetados_y_estilos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Evento _evento;
        public MainWindow()
        {
            InitializeComponent();
            _evento = new Evento();
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            if (camposObligatorios())
            {
                obtenerDatos();
                MostrarDatos md = new MostrarDatos(_evento);
                md.ShowDialog();
            }

        }

        private bool camposObligatorios()
        {
            bool valido = false;
            if (string.IsNullOrEmpty(txtNombre.Text) ||
               string.IsNullOrEmpty(dtpFecha.Text) ||
               string.IsNullOrEmpty(txtHora.Text))
            {
                MessageBox.Show("Los campos de Nombre, Fecha y Hora son obligatorios", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show("Datos confirmados", "Validos", MessageBoxButton.OK, MessageBoxImage.Information);
                valido = true;
            }
            return valido;
        }

        private void obtenerDatos()
        {
            _evento.Nombre = txtNombre.Text;
            _evento.Fecha = dtpFecha.SelectedDate.Value;
            _evento.Aforo = Convert.ToInt32(txtAforo.Text);
            _evento.Promotor = cmbPromotor.Text;
            if (rbTodos.IsChecked == true)
            {
                _evento.Tipo = TipoEnum.Todos;
            }
            else if (rbM10.IsChecked == true)
            {
                _evento.Tipo = TipoEnum.Mayor_de_10;
            }
            else if (rbM16.IsChecked == true)
            {
                _evento.Tipo = TipoEnum.Menor_de_16;
            }
            else if (rbM18.IsChecked == true)
            {
                _evento.Tipo = TipoEnum.Menor_de_18;
            }

            _evento.Descripcion = txtDescripcion.Text;
        }
    }
}
