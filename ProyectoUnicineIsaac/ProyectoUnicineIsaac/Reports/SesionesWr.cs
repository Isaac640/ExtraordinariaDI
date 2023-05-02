using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUnicineIsaac.Reports
{
    public class SesionesWr
    {
        public int SesionId { get; set; }
        public string Sala { get; set; }
        public string DiaSemana { get; set; }
        public System.DateTime Comienzo { get; set; }
        public System.DateTime FinMax { get; set; }
        public float Precio { get; set; }
        public int Aforo { get; set; }

        //Pelicula
        public int PeliculaId { get; set; }
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        public int Anno { get; set; }
        public string Categoria { get; set; }
        public string Genero { get; set; }

    }
}

