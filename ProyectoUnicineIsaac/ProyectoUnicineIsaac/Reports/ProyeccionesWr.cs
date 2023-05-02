using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUnicineIsaac.Reports
{
    public class ProyeccionesWr
    {

        public string Nombre { get; set; }
        public int Duracion { get; set; }
        public string Categoria { get; set; }
        public string Genero { get; set; }

        public string DiaSemana { get; set; }


        public System.DateTime Inicio { get; set; }
        public Nullable<System.DateTime> Fin { get; set; }
    }
}
