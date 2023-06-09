using System.Linq;
using WPF_Isaac_Cabria_Diez;

namespace RecuperacionWpf
{
    internal class Negocio
    {
        public Empleado[] ObtenerEmpleados()
        {
            EmpleadosBD bd = new EmpleadosBD();
            return bd.Empleados.ToArray();
        }

        public void CrearEmpleado(Empleado empleado)
        {
            EmpleadosBD bd = new EmpleadosBD();
            bd.Empleados.Add(empleado);
            bd.SaveChanges();
        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            EmpleadosBD bd = new EmpleadosBD();
            Empleado empleadobd = bd.Empleados.FirstOrDefault(x => x.EmpleadoId == empleado.EmpleadoId);
            if (empleadobd != null)
            {
                bd.Entry(empleadobd).CurrentValues.SetValues(empleado);
                bd.SaveChanges();
            }
        }

        public void EliminarEmpleado(int empleadoId)
        {
            EmpleadosBD bd = new EmpleadosBD();
            Empleado empleadobd = bd.Empleados.FirstOrDefault(x => x.EmpleadoId == empleadoId);
            if (empleadobd != null)
            {
                bd.Empleados.Remove(empleadobd);
                bd.SaveChanges();
            }
        }

    }
}
