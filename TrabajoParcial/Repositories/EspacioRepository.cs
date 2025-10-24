using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoParcial.Entities;

namespace TrabajoParcial.Repositories
{
    internal class EspacioRepository
    {
        private static List<Espacio> espaciosRegistrados = new List<Espacio>();
        public bool Registro(Espacio espacio)
        {
            if (Duplicado(espacio.Id))
            {
                return false;
            }
            espaciosRegistrados.Add(espacio);
            return true;
        }
        public bool Duplicado(int id)
        {
            return espaciosRegistrados.Any(b => b.Id.Equals(id));
        }
    }
}
