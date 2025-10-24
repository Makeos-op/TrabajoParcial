using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoParcial.Entities
{
    internal class Reserva
    {
        public int Id { get; set; }

        public Reserva(Vehiculo vehiculo,Espacio espacio) { 
            matricula = vehiculo.Matricula;
            idUbicacion = espacio.Id;
            tarifa = espacio.TarifaHora;
            Monto_horas = espacio.TarifaHora * Cantidad_Horas;
        }
        public string matricula { get; set; }
        public int idUbicacion { get; set; }
        public double tarifa { get; set; }
        public DateTime Fecha_de_reserva {  get; set; }
        public int Hora_de_reserva { get; set; }
        public int Cantidad_Horas { get; set; }
        public double Monto_horas { get; set; }
    }
}
