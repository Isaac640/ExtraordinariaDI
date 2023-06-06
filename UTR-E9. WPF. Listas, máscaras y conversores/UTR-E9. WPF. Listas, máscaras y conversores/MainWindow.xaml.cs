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

namespace UTR_E9.WPF.Listas__máscaras_y_conversores
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Negocio _negocio;
        public MainWindow()
        {
            InitializeComponent();
            _negocio = new Negocio();
        }

        private void RefrescarLista()
        {
            this.lvReservas.Items.Clear();

            _negocio.ObtenerReservas().ToList().ForEach(res =>
            {
                this.lvReservas.Items.Add(new Reserva { Fecha = res.Fecha,
                Nombre = res.Nombre, Comensales = res.Comensales, Asiste = res.Asiste}
                );
            });

            lblRegistros.Content = this.lvReservas.Items.Count + " Registros"; 
        }


        private void btnNueva_Click(object sender, RoutedEventArgs e)
        {
            Reserva reserva = new Reserva();
            VentanaReserva nuevaRes = new VentanaReserva(reserva);
            if (nuevaRes.ShowDialog() == true)
            {
                _negocio.CrearReserva(reserva);
                RefrescarLista();
            }

        }

        private void mi_Ver_Click(object sender, RoutedEventArgs e)
        {
            Reserva reserva = (Reserva)lvReservas.SelectedItem;
            VentanaReserva nuevaRes = new VentanaReserva(reserva);
            nuevaRes.ShowDialog();
        }

        private void mi_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            Reserva reserva = (Reserva)lvReservas.SelectedItem;
            _negocio.BorrarReserva(reserva.ReservaId);
            RefrescarLista();
        }

        private void btnFiltro_Click(object sender, RoutedEventArgs e)
        {
            CollectionView vista = (CollectionView)CollectionViewSource.GetDefaultView(lvReservas.Items);
            if (string.IsNullOrEmpty(txtFiltro.Text))
            {
                vista.Filter = null;
            }
            else
            {
                vista.Filter = item =>
                {
                    string nombre = ((Reserva)item).Nombre;
                    string fecha = ((Reserva)item).Fecha.ToString();

                    lblFiltrado.Content = "Filtrado por " + txtFiltro.Text;

                    return nombre.Contains(txtFiltro.Text) || fecha.Contains(txtFiltro.Text);
                    
                };
            }

        }

    }
}
