using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoParcial.Entities;

namespace TrabajoParcial.Repositories
{
    internal class ReservaRepository
    {
        private static List<Reserva> ReservasActivas = new List<Reserva>();

        public bool Registro(Reserva reserva)
        {
            if (Duplicado(reserva))
            {
                return false;
            }
            ReservasActivas.Add(reserva);
            return true;
        }
        public bool Duplicado(Reserva reserva)
        {
            return ReservasActivas.Any(b => b.Id.Equals(reserva.Id) || (b.idUbicacion.Equals(reserva.idUbicacion) && b.Fecha_de_reserva.Equals(reserva.Fecha_de_reserva)&& b.Hora_de_reserva.Equals(reserva.Hora_de_reserva)));
        }
    }
}
