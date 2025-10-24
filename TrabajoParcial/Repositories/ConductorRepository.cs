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
            conductores = UsuarioRepository.MostrarConductores();
            return conductores;
        }
        public Conductor BuscarConductores(int DNI)
        {
            return MostrarConductores().Find(i => i.DNI.Equals(DNI));
        }
        public bool Registro(Conductor conductor, Brevete brevete)
        {
            var breveteRepo = new BreveteRepository(); //Llamar Repo Brevetes
            conductor.TipoUsuario = "Conductor";
            bool BreveteRegistro = breveteRepo.Registro(brevete);
            conductor.brevetes.Add(brevete);
            return new UsuarioRepository().RegistrarUsuario(conductor);
        }
        public List<Vehiculo> MostrarVehiculos(int id)
        {
            Conductor conductor = conductores.Find(i => i.DNI.Equals(id));
            return conductor.vehiculos;
        }
        public List<Brevete> MostrarBrevetes(int id)
        {
            Conductor conductor = conductores.Find(i => i.DNI.Equals(id));
            return conductor.brevetes;
        }
    }
}
