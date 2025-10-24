using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoParcial.Entities;
using TrabajoParcial.Repositories;

namespace TrabajoParcial.Servicies
{
    internal class ReservaService
    {
        private ReservaRepository reservaRepository = new ReservaRepository();

        public bool Registro(Reserva reserva)
        {
            return reservaRepository.Registro(reserva);
        }

        public void TerminarReserva(Reserva reserva)
        {
            reservaRepository.TerminarReserva(reserva);
        }
    }
}
