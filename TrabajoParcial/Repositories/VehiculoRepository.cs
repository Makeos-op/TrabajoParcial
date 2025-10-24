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
        private static List<Vehiculo> VehiculosRegistrados = new List<Vehiculo>();
        public bool RegistroBrevete(Vehiculo vehiculo)
        {
            if (Duplicado(vehiculo.Matricula))
            {
                return false;
            }
            VehiculosRegistrados.Add(vehiculo);
            return true;
        }
        public bool Duplicado(string id)
        {
            return VehiculosRegistrados.Any(b => b.Matricula.Equals(id));
        }
    }
}
