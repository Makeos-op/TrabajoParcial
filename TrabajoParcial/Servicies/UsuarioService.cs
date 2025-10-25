    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoParcial.Entities;
using TrabajoParcial.Repositories;

namespace TrabajoParcial.Servicies
{
    internal class UsuarioService
    {
        public UsuarioRepository usuarioRepository { get; }  
        public UsuarioService()
        {
            usuarioRepository = new UsuarioRepository();
        }

        public bool RegistrarUsuario(Usuario usuario)
        {
            return usuarioRepository.RegistrarUsuario(usuario);
        }
        //Mostrar
        public static List<Usuario> MostrarUsuarios()
        {
            return UsuarioRepository.MostrarUsuarios();
        }
        public static List<Conductor> MostrarConductores()
        {
            return UsuarioRepository.MostrarConductores();
        }
        public static List<Arrendador> MostrarArrendadores()
        {
            return UsuarioRepository.MostrarArrendadores();
        }

        public bool VerificarCuenta(int DNI, string contraseña)
        {
            return usuarioRepository.VerificarCuenta(DNI,contraseña);
        }
        public Usuario Buscar(int DNI)
        {
            
            return usuarioRepository.Buscar(DNI);
        }
        public void AgregarMonto(double monto, int DNI)
        {
            usuarioRepository.AgregarMonto(monto, DNI);
        }
        public void QuitarMonto(double monto, int DNI)
        {
            usuarioRepository.QuitarMonto(monto, DNI);
        }
        public bool login(int dni, string contraseña)
        {
            return usuarioRepository.login(dni, contraseña);
        }
    }
}
