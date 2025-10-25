using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoParcial.Servicies;

namespace TrabajoParcial
{
    public partial class FormLogin : Form
    {
        private UsuarioService usuarioService = new UsuarioService();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            FormRegistrar form = new FormRegistrar();
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
            bool login = usuarioService.login(int.Parse(usuario), contraseña);
            if (login)
            {
                switch (usuarioService.Buscar(int.Parse(usuario)).TipoUsuario)
                {
                    case "Arrendador":
                        FormArrendador formA = new FormArrendador();
                        formA.Show();
                        break;

                    case "Conductor":
                        FormConductor formC = new FormConductor();
                        formC.Show();
                        break;
                }
                return;
            }
            MessageBox.Show("No se pudo registrar el usuario","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
