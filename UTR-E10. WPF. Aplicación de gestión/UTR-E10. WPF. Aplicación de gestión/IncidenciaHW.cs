using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTR_E10.WPF.Aplicación_de_gestión
{
    public enum TipoHardwareEnum
    {
        Torre,
        Impresora,
        Red
    }
    public class IncidenciaHW : Incidencia
    {
        public TipoHardwareEnum Clase { get; set; }
        public bool Enciende { get; set; }
        public string Etiqueta { get; set; }
    }
}
