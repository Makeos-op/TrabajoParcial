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
        //Usuarios Arrendadores como lista (Tipo Arrendador == objeto Arrendador)
        public List<Arrendador> MostrarArrendadores()
        {
            return UsuarioRepository.MostrarArrendadores();
        }
        public Arrendador BuscarArrendadores(int DNI)
        {
            return MostrarArrendadores().Find(i => i.DNI.Equals(DNI));
        }
        public bool RegistrarArrendador(Arrendador arrendador)
        {
            arrendador.TipoUsuario = "Arrendador";
            return new UsuarioRepository().RegistrarUsuario(arrendador);
        }
    }
}
