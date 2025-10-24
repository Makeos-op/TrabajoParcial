using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoParcial.Entities;

namespace TrabajoParcial.Repositories
{
    internal class ArrendadorRepository
    {
        private List<Arrendador> arrendadores = UsuarioRepository.MostrarArrendadores();
        //Usuarios Arrendadores como lista (Tipo Arrendador == objeto Arrendador)
        public List<Arrendador> MostrarArrendadores()
        {
            return UsuarioRepository.MostrarArrendadores();
        }
        public Arrendador BuscarArrendadores(int DNI)
        {
            return MostrarArrendadores().Find(i => i.DNI.Equals(DNI));
        }
        public bool Registro(Arrendador arrendador, Espacio espacio)
        {
            var espacioRepo = new EspacioRepository();
            arrendador.TipoUsuario = "Conductor";
            bool EspacioRegistro = espacioRepo.Registro(arrendador.DNI,espacio);
            arrendador.Espacios.Add(espacio);
            return new UsuarioRepository().RegistrarUsuario(arrendador);    
        }
        public List<Espacio> MostrarEspacios(int id)
        {
            return Buscar(id).Espacios;
        }
        public Arrendador Buscar(int DNI)
        {
            Arrendador arrendador = arrendadores.Find(i => i.DNI.Equals(DNI));
            return arrendador;
        }
    }
}
