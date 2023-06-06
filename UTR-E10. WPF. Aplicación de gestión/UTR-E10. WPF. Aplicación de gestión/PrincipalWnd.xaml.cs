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

namespace UTR_E10.WPF.Aplicación_de_gestión
{
    /// <summary>
    /// Lógica de interacción para PrincipalWnd.xaml
    /// </summary>
    public partial class PrincipalWnd : Window
    {
        private Negocio _negocio;
        private Incidencia _incidencia;
        public PrincipalWnd()
        {
            InitializeComponent();
            _negocio = new Negocio();
        }

        /*
        private void RefrescarLista()
        {
            this.lvIncidencias.Items.Clear();

            _negocio.ObtenerIncidencias().ToList().ForEach(res =>
            {
                this.lvIncidencias.Items.Add(new Incidencia
                {
                    Fecha = res.Fecha,
                    Descripcion = res.Descripcion,
                    Cerrada = res.Cerrada
                }
                );
            });

        }
        */

        private void btnHardware_Click(object sender, RoutedEventArgs e)
        {
            IncidenciaHW inHardware = new IncidenciaHW();
            UCIncidenciaHW uCIncidenciaHW = new UCIncidenciaHW(inHardware);

            uCIncidenciaHW.Show();
        }

        private void btnSoftware_Click(object sender, RoutedEventArgs e)
        {
            UCIncidenciasSF uCIncidenciaSF = new UCIncidenciasSF();

            uCIncidenciaSF.Show();
        }

        private void btnOtros_Click(object sender, RoutedEventArgs e)
        {
            UCIncidenciaOtros uCIncidenciaOtros = new UCIncidenciaOtros();

            uCIncidenciaOtros.Show();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            CollectionView vista = (CollectionView)CollectionViewSource.GetDefaultView(lvIncidencias.Items);
            if (string.IsNullOrEmpty(txtFiltro.Text))
            {
                vista.Filter = null;
            }
            else
            {
                vista.Filter = item =>
                {
                    string desc = ((Incidencia)item).Descripcion;
                    string fecha = ((Incidencia)item).Fecha.ToString();

                    return desc.Contains(txtFiltro.Text) || fecha.Contains(txtFiltro.Text);

                };
            }
        }
    }
}
