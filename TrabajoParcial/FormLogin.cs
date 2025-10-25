using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoParcial.Entities;
using TrabajoParcial.Repositories;
using TrabajoParcial.Servicies;

namespace TrabajoParcial
{
    public partial class FormLogin : Form
    {
        private UsuarioService usuarioService = new UsuarioService();
        private ArrendadorService arrendadorService;
        private ConductorService conductorService;
        public FormLogin()
        {
            arrendadorService = new ArrendadorService(usuarioService.usuarioRepository);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            FormRegistrar form = new FormRegistrar(usuarioService);
            form.Show();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario = txtususario.Text.Trim();
            string contraseña = txtcontrasenalogin.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, selecciona o ingresa un usuario y una contraseña.",
                                "Campos vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(usuario, out int usuarioId))
            {
                MessageBox.Show("El campo usuario debe ser un número entero (por ejemplo, DNI o ID).",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            bool login = usuarioService.login(usuarioId, contraseña);
            if (login)
            {
                Usuario usuarioEncontrado = usuarioService.Buscar(usuarioId);

                if (usuarioEncontrado == null)
                {
                    MessageBox.Show("Error: el usuario no fue encontrado en la base de datos.",
                                    "Error interno",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }
                string tipo = usuarioEncontrado.TipoUsuario.Trim().ToLower();
                if (tipo == "Arrendador")
                {
                    FormArrendador formA = new FormArrendador();
                    formA.Show();
                }
                else if (tipo == "Conductor")
                {
                    FormConductor formC = new FormConductor();
                    formC.Show();
                }
                else
                {
                    MessageBox.Show($"Tipo de usuario desconocido: {usuarioEncontrado.TipoUsuario}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
    }
}
