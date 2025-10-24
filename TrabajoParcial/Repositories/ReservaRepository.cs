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
        public void TerminarReserva(Reserva reserva)
        {
            var UsuarioRepo = new UsuarioRepository();
            var VehiculoRepo = new VehiculoRepository();
            var EspacioRepo = new EspacioRepository();
            //Problema: reserva.matricula o dniConductor
            UsuarioRepo.QuitarMonto(reserva.Monto_horas, VehiculoRepo.Buscar(reserva.matricula).dniConductor);
            //Problema: reserva.idUbicacion o dniArrendador
            UsuarioRepo.AgregarMonto(reserva.Monto_horas, EspacioRepo.Buscar(reserva.idUbicacion).DniArrendador);
        }


    }
}
