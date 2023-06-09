using RecuperacionWpf;
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

namespace WPF_Isaac_Cabria_Diez
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
            RefrescarLista();
        }

        private void RefrescarLista()
        {
            this.lvEmpleados.Items.Clear();

            _negocio.ObtenerEmpleados().ToList().ForEach(res =>
            {
                this.lvEmpleados.Items.Add(new Empleado
                {
                    Nombre = res.Nombre,
                    Apellidos = res.Apellidos,
                    Departamento = Herramientas.ObtenerDepartamento(res.Departamento.DepartamentoId)
                }
                );
            });

        }

        private void btnFiltro_Click(object sender, RoutedEventArgs e)
        {
            CollectionView vista = (CollectionView)CollectionViewSource.GetDefaultView(lvEmpleados.Items);
            if (string.IsNullOrEmpty(txtFiltro.Text))
            {
                vista.Filter = null;
            }
            else
            {
                vista.Filter = item =>
                {
                    string nombre = ((Empleado)item).Nombre;
                    string apellidos = ((Empleado)item).Apellidos;

                    return nombre.Contains(txtFiltro.Text) || apellidos.Contains(txtFiltro.Text);

                };
            }
        }

        private void btnNueva_Click(object sender, RoutedEventArgs e)
        {
            Empleado emp = null;
            PropiedadEmp propiedadEmp = new PropiedadEmp(emp);
            if (propiedadEmp.ShowDialog() == true)
            {
                _negocio.CrearEmpleado(emp);
                RefrescarLista();
            }
        }

        private void mi_Ver_Click(object sender, RoutedEventArgs e)
        {
            Empleado emp = (Empleado)lvEmpleados.SelectedItem;
            PropiedadEmp propiedadEmp = new PropiedadEmp(emp);
            if (propiedadEmp.ShowDialog() == true)
            {
                _negocio.ActualizarEmpleado(emp);
                RefrescarLista();
            }
        }

        private void mi_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            Empleado emp = (Empleado)lvEmpleados.SelectedItem;
            _negocio.EliminarEmpleado(emp.EmpleadoId);
            RefrescarLista();
        }
    }

}

