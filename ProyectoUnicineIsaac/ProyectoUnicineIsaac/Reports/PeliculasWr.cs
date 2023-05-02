using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUnicineIsaac.Reports
{
    public class PeliculasWr
    {
        public int PeliculaId { get; set; }
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        public int Anno { get; set; }
        public string Categoria { get; set; }
        public string Genero { get; set; }

        //Sesion
        public string Sala { get; set; }
        public string DiaSemana { get; set; }
        public System.DateTime Comienzo { get; set; }
        public float Precio { get; set; }

        //Proyeccion
        public System.DateTime Inicio { get; set; }
        public Nullable<System.DateTime> Fin { get; set; }


    }
}
