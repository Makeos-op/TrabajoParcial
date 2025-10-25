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
        private UsuarioRepository usuarioRepository;
        private List<Conductor> conductores = UsuarioRepository.MostrarConductores();
        //Usuarios Conductores como lista (Tipo conductor == objeto conductor)
        public List<Conductor> MostrarConductores()
        {
            conductores = UsuarioRepository.MostrarConductores();
            return conductores;
        }
        public Conductor Buscar(int DNI)
        {
            return MostrarConductores().Find(i => i.DNI.Equals(DNI));
        }
        public bool Registro(Conductor conductor, Brevete brevete)
        {
            var breveteRepo = new BreveteRepository(); //Llamar Repo Brevetes
            conductor.TipoUsuario = "Conductor";
            bool BreveteRegistro = breveteRepo.Registro(brevete);
            if (!BreveteRegistro)
            {
                return false;
            }
            conductor.brevetes.Add(brevete);
            return usuarioRepository.RegistrarUsuario(conductor);
        }
        public List<Vehiculo> MostrarVehiculos(int id)
        {
            return Buscar(id).vehiculos;
        }
        public List<Brevete> MostrarBrevetes(int id)
        {
            return Buscar(id).brevetes;
        }
        //Reportes

    }
}
