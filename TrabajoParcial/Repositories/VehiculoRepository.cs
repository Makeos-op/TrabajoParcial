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
        public bool Registro(int DNI,Vehiculo vehiculo)
        {
            if (Duplicado(vehiculo.Matricula))
            {
                return false;
            }
            var ConductorRepo = new ConductorRepository();
            ConductorRepo.Buscar(DNI).vehiculos.Add(vehiculo);
            vehiculosRegistrados.Add(vehiculo);
            return true;
        }
        public bool Duplicado(string id)
        {
            return vehiculosRegistrados.Any(b => b.Matricula.Equals(id));
        }
        public Vehiculo Buscar(string Matricula)
        {
            return vehiculosRegistrados.Find(v => v.Matricula.Equals(Matricula));
        }
    }
}
