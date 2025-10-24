using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoParcial.Entities;
using TrabajoParcial.Repositories;

namespace TrabajoParcial.Servicies
{
    internal class EspacioService
    {
        private EspacioRepository espacioRepository = new EspacioRepository();

        public bool Registro(int dni, Espacio espacio)
        {
            return espacioRepository.Registro(dni,espacio);
        }

        public Espacio Buscar(int id)
        {
            return espacioRepository.Buscar(id);
        }
    }
}
