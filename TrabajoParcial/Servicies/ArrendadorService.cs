using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoParcial.Entities;
using TrabajoParcial.Repositories;

namespace TrabajoParcial.Servicies
{
    internal class ArrendadorService
    {
        ArrendadorRepository arrendadorRepository = new ArrendadorRepository();

        public List<Arrendador> MostrarArrendadores()
        {
            return arrendadorRepository.MostrarArrendadores();
        }
        public Arrendador BuscarArrendadores(int DNI)
        {
            return arrendadorRepository.Buscar(DNI);
        }
        public bool Registro(Arrendador arrendador, Espacio espacio)
        {
            return arrendadorRepository.Registro(arrendador, espacio);  
        }
        public List<Espacio> MostrarEspacios(int id)
        {
            return arrendadorRepository.MostrarEspacios(id);
        }
        public Arrendador Buscar(int DNI)
        {
            return arrendadorRepository.Buscar(DNI);
        }
    }
}
