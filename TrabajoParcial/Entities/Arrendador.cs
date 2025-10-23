using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoParcial.Entities
{
    internal class Arrendador:Persona
    {
        public Arrendador(Persona persona)
        {
            DNI = persona.DNI;
            Nombre = persona.Nombre;
            Apellidos = persona.Apellidos;
            Edad = persona.Edad;
            Nacionalidad = persona.Nacionalidad;
            Telefono = persona.Telefono;
            Correo = persona.Correo;
            Contraseña = persona.Contraseña;
            Espacios = new List<Espacio>();
        }
        public List<Espacio> Espacios { get; set; }

    }
}
