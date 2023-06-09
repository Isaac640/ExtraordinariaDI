using System.Linq;
using WPF_Isaac_Cabria_Diez;

namespace RecuperacionWpf
{
    internal static class Herramientas
    {
        public static Departamento ObtenerDepartamento(int departamentoId)
        {
            EmpleadosBD bd = new EmpleadosBD();
            return bd.Departamentos.FirstOrDefault(x => x.DepartamentoId == departamentoId);
        }

        public static Departamento[] ObtenerDepartamentos()
        {
            EmpleadosBD bd = new EmpleadosBD();
            return bd.Departamentos.ToArray();
        }
    }
}
