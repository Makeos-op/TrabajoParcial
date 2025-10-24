using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoParcial.Entities;

namespace TrabajoParcial.Repositories
{
    internal class VehiculoRepository
    {
        private static List<Vehiculo> vehiculosRegistrados = new List<Vehiculo>();
        public bool Registro(Vehiculo vehiculo)
        {
            if (Duplicado(vehiculo.Matricula))
            {
                return false;
            }
            vehiculosRegistrados.Add(vehiculo);
            return true;
        }
        public bool Duplicado(string id)
        {
            return vehiculosRegistrados.Any(b => b.Matricula.Equals(id));
        }
    }
}
