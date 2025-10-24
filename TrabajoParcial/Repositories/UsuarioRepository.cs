using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TrabajoParcial.Entities;

namespace TrabajoParcial.Repositories
{
    internal class UsuarioRepository
    {
        private static List<Usuario> usuarios = new List<Usuario>();
        //Registro
        public bool RegistrarUsuario(Usuario usuario)
        {
            if (ExisteUsuario(usuario.DNI))
            {
                return false;
            }
            usuarios.Add(usuario); 
            return true;
        }
        // Duplicado
        public bool ExisteUsuario(int Dni)
        {
            return usuarios.Any(d => d.DNI.Equals(Dni));
        }
        //Mostrar
        public static List<Usuario> MostrarUsuarios()
        {
            return usuarios;
        }
        public static List<Conductor> MostrarConductores()
        {
            return usuarios.Where(p => p.TipoUsuario == "Conductor").Select(p => new Conductor(p)).ToList();
        }
        public static List<Arrendador> MostrarArrendadores()
        {
            return usuarios.Where(p => p.TipoUsuario == "Arrendador").Select(p => new Arrendador(p)).ToList();
        }

        public bool VerificarCuenta(int DNI, string contraseña)
        {
            return usuarios.Any(p=>p.DNI.Equals(DNI)&& p.Contraseña.Equals(contraseña));
        }
        public Usuario Buscar(int DNI)
        {
            Usuario usuario = usuarios.Find(i => i.DNI.Equals(DNI));
            return usuario;
        }
        public void AgregarMonto(double monto, int DNI)
        {
            Buscar(DNI).Balance += monto;
        }
        public void QuitarMonto(double monto, int DNI)
        {
            Buscar(DNI).Balance -= monto;
        }
        public bool login(int dni,string contraseña)
        {
            return usuarios.Exists(i => i.DNI.Equals(dni) && i.Contraseña.Equals(contraseña));
        }
    }
}
