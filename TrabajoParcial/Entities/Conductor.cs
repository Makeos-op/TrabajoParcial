using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoParcial.Entities
{
    internal class Conductor:Persona
    {
        public Conductor(Persona persona,Brevete brevete) {
            DNI=persona.DNI;
            Nombre=persona.Nombre;
            Apellidos=persona.Apellidos;
            Edad=persona.Edad;
            Nacionalidad = persona.Nacionalidad;
            Telefono = persona.Telefono;
            Correo = persona.Correo;
            Contraseña = persona.Contraseña;
            vehiculos = new List<Vehiculo>();
            brevetesVigentes = new List<Brevete>();
            puntuacion = 0;
        }
        public List<Vehiculo> vehiculos { get; set; }
        public List<Brevete> brevetesVigentes { get; set; }
        public int puntuacion{ get; set; }
    }
}
