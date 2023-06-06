using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTR_E10.WPF.Aplicación_de_gestión
{
    public class IncidenciaSF : Incidencia
    {
        public string Etiqueta { get; set; }
        public bool Instalacion { get; set; }
        public string Programa { get; set; }
        public bool Reconfiguracion { get; set; }
    }
}
