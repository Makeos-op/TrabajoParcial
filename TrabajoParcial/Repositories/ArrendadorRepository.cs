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
        private UsuarioRepository usuarioRepository;
        private List<Arrendador> arrendadores = UsuarioRepository.MostrarArrendadores();
        public List<Arrendador> MostrarArrendadores()
        {
            return UsuarioRepository.MostrarArrendadores();
        }
        public ArrendadorRepository(UsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }
        public Arrendador Buscar(int DNI)
        {
            return arrendadores.Find(i => i.DNI.Equals(DNI));
        }
        public bool Registro(Arrendador arrendador, Espacio espacio)
        {
            var espacioRepo = new EspacioRepository();
            arrendador.TipoUsuario = "Arrendador";
            bool EspacioRegistro = espacioRepo.Registro(arrendador.DNI,espacio);
            if (!EspacioRegistro)
            {
                return false;
            }
            arrendador.Espacios.Add(espacio);
            return usuarioRepository.RegistrarUsuario(arrendador);    
        }
        public List<Espacio> MostrarEspacios(int id)
        {
            return Buscar(id).Espacios;
        }
    }
}
