using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoParcial.Entities
{
    internal class Conductor:Usuario
    {
        public Conductor(Usuario persona)
        {
            DNI = persona.DNI;
            Nombre = persona.Nombre;
            Apellidos = persona.Apellidos;
            Edad = persona.Edad;
            Nacionalidad = persona.Nacionalidad;
            Telefono = persona.Telefono;
            Correo = persona.Correo;
            Contraseña = persona.Contraseña;
            vehiculos = new List<Vehiculo>();
            brevetes = new List<Brevete>();
            puntuacion = 0;
        }
        public List<Vehiculo> vehiculos { get; set; }
        public List<Brevete> brevetes { get; set; }
        public int puntuacion{ get; set; }

    }
}
