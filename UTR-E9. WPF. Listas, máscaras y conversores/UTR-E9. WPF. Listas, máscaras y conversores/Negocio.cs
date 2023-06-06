using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTR_E9.WPF.Listas__máscaras_y_conversores
{
    public class Negocio
    {
        private int _reserva;
        private List<Reserva> reservas;

        public void BorrarReserva(int reservaId)
        {
            var borrar = ObtenerReserva(reservaId);
            reservas.Remove(borrar);
        }

        public void CrearReserva(Reserva NuevaReserva)
        {
            if (reservas.Count > 0)
            {
                NuevaReserva.ReservaId = SiguienteReservaId();
            }
            else
            {
                NuevaReserva.ReservaId = 1;
            }

            reservas.Add(NuevaReserva);
        }

        public Negocio()
        {
            reservas = new List<Reserva>();
        }

        public Reserva ObtenerReserva(int reservaId)
        {
            return reservas.FirstOrDefault(x => x.ReservaId == reservaId);
        }

        public Reserva[] ObtenerReservas()
        {
            return reservas.ToArray();
        }

        private int SiguienteReservaId()
        {
            return _reserva++;
        }
    }
}
