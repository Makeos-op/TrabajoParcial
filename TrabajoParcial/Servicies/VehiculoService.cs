using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoParcial.Entities;
using TrabajoParcial.Repositories;

namespace TrabajoParcial.Servicies
{
    internal class VehiculoService
    {
        private VehiculoRepository vehiculoRepository = new VehiculoRepository();
        public bool Registro(int DNI, Vehiculo vehiculo)
        {
            return vehiculoRepository.Registro(DNI, vehiculo);
        }

        public Vehiculo Buscar(string Matricula)
        {
            return vehiculoRepository.Buscar(Matricula);
        }
    }
}
