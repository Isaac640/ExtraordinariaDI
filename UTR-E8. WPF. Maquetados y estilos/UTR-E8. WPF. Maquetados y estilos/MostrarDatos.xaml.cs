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

namespace UTR_E8.WPF.Maquetados_y_estilos
{
    /// <summary>
    /// Lógica de interacción para MostrarDatos.xaml
    /// </summary>
    public partial class MostrarDatos : Window
    {
        private MostrarDatos()
        {
            InitializeComponent();
        }
        public MostrarDatos(Evento evento) : this()
        {
            this.txtNombre.Text = evento.Nombre;
            this.txtAforo.Text = evento.Aforo.ToString();
            this.txtHora.Text = evento.Hora.ToString();
            this.txtPromotor.Text = evento.Promotor;
            this.txtDescripcion.Text = evento.Descripcion;
            switch (evento.Tipo)
            {
                case TipoEnum.Todos:
                    txtTipo.Text = "Todos";
                    break;
                case TipoEnum.Mayor_de_10:
                    txtTipo.Text = "<10";
                    break;
                case TipoEnum.Menor_de_16:
                    txtTipo.Text = ">16";
                    break;
                case TipoEnum.Menor_de_18:
                    txtTipo.Text = ">18";
                    break;
            }

        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
