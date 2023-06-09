using RecuperacionWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace WPF_Isaac_Cabria_Diez
{
    /// <summary>
    /// Lógica de interacción para PropiedadEmp.xaml
    /// </summary>
    public partial class PropiedadEmp : Window
    {
        private Empleado _empleado;
        private Negocio _negocio;
        private PropiedadEmp()
        {
            InitializeComponent();
            _empleado = new Empleado();
        }

        public PropiedadEmp(Empleado emp) : this()
        {
            this._empleado = emp;

            if (emp == null)
            {
                this.txtNombre.Text = string.Empty;
                this.dtpNacimiento.Text = string.Empty;
                this.txtSalario.Text = string.Empty;
                this.txtApellidos.Text = string.Empty;
                this.txtTlfn.Text = string.Empty;
            }
            if (emp != null)
            {
                this.txtNombre.Text = emp.Nombre;
                this.dtpNacimiento.Text = emp.Nacimiento.ToString();
                this.txtSalario.Text = emp.SalarioAnual.ToString();
                this.txtApellidos.Text = emp.Apellidos;
                this.txtTlfn.Text = emp.Telefono;
                this.cbActivo.IsChecked = emp.Activo;
            }

        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (validacion() == true)
            {
                this._empleado.Nombre = this.txtNombre.Text;
                this._empleado.Apellidos = this.txtApellidos.Text;
                this._empleado.Nacimiento = this.dtpNacimiento.SelectedDate.Value;
                this._empleado.SalarioAnual = float.Parse(this.txtSalario.Text);
                this._empleado.Telefono = this.txtTlfn.Text;
                this._empleado.Activo = this.cbActivo.IsChecked.Value;
                this._empleado.Departamento = departamentos();

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
                string.IsNullOrEmpty(txtApellidos.Text) ||
                string.IsNullOrEmpty(dtpNacimiento.Text) ||
                string.IsNullOrEmpty(txtTlfn.Text) ||
                string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Advertencia", "Los campos de Nombre, Apellidos, Telefono, Nacimiento y Salario son obligatorios", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                valido = true;
            }
            return valido;
        }

        private void txtSalario_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (!IsNumericKey(e.Key) && e.Key != Key.Back && e.Key != Key.Tab && e.Key != Key.OemComma)
            {
                e.Handled = true;
            }
        }

        private void txtTlfn_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (!IsNumericKey(e.Key) && e.Key != Key.Back && e.Key != Key.Tab && e.Key != Key.OemComma)
            {
                e.Handled = true;
            }
        }

        private bool IsNumericKey(Key key)
        {
            return (key >= Key.D0 && key <= Key.D9) || (key >= Key.NumPad0 && key <= Key.NumPad9);
        }


        //Los siguientes metodos puede ser horribles, pero no encuentro otra manera
        private Departamento departamentos()
        {
            Departamento dep = null;
            if (cmbDept.Text.Equals("Finanzas"))
            {
                Herramientas.ObtenerDepartamento(1);
            }
            if (cmbDept.Text.Equals("Marketing"))
            {
                Herramientas.ObtenerDepartamento(2);
            }
            if (cmbDept.Text.Equals("Desarrollo"))
            {
                Herramientas.ObtenerDepartamento(3);
            }
            if (cmbDept.Text.Equals("Recursos humanos"))
            {
                Herramientas.ObtenerDepartamento(4);
            }
            if (cmbDept.Text.Equals("Ventas"))
            {
                Herramientas.ObtenerDepartamento(5);
            }
            return dep;
        }

    }
}
