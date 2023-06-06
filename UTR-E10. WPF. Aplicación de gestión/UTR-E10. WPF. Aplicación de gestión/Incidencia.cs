using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTR_E10.WPF.Aplicación_de_gestión
{

    public enum TipoIncidenciaEnum
    {
        Hardware,
        Software,
        Otro
    }

    public abstract class Incidencia
    {
        public bool Cerrada { get; set; }
        public string Descripcion { get; set; } 
        public DateTime Fecha { get; set; }
        public int IncidenciaId { get; set; }
        public string Observaciones { get; set; }
        public TipoIncidenciaEnum Tipo { get; set; }
    }
}
