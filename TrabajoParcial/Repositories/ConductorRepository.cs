using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoParcial.Entities;

namespace TrabajoParcial.Repositories
{
    internal class ConductorRepository
    {
        private List<Conductor> conductores = UsuarioRepository.MostrarConductores();
        //Usuarios Conductores como lista (Tipo conductor == objeto conductor)
        public List<Conductor> MostrarConductores()
        {
            return UsuarioRepository.MostrarConductores();
        }
        public Conductor BuscarConductores(int DNI)
        {
            return MostrarConductores().Find(i => i.DNI.Equals(DNI));
        }
        public bool RegistrarConductor(Conductor conductor, Brevete brevete)
        {
            var breveteRepo = new BreveteRepository(); //Llamar Repo Brevetes
            conductor.TipoUsuario = "Conductor";
            bool BreveteRegistro = breveteRepo.RegistroBrevete(brevete);
            conductor.brevetes.Add(brevete);
            return new UsuarioRepository().RegistrarUsuario(conductor);
        }
    }
}
