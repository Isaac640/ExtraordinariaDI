using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTR_E10.WPF.Aplicación_de_gestión
{
    public class IncidenciaEventArgs : EventArgs
    {
        private object _dato;

        public object Dato { get; set; }
        public IncidenciaEventArgs(Incidencia incidencia)
        {

        }
    }
}
