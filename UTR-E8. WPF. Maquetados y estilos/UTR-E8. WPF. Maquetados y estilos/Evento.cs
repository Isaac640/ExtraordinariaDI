using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTR_E8.WPF.Maquetados_y_estilos
{
    public enum TipoEnum
    {
        Todos,
        Mayor_de_10,
        Menor_de_16,
        Menor_de_18
    }
    public class Evento
    {
        public string Nombre {  get; set; }
        public DateTime Fecha { get; set; }

        public DateTime Hora { get; set; }
        public int Aforo { get; set; }
        public TipoEnum Tipo { get; set; }
        public string Descripcion { get; set; }
        public bool Seguridad { get; set; }
        public bool Bar { get; set; }
        public bool Montaje {  get; set; }
        public bool Sanitarios { get; set; }
        public string Promotor { get; set; }

    }
}
