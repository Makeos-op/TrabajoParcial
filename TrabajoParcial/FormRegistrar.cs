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
using TrabajoParcial.Servicies;

namespace TrabajoParcial
{
    public partial class FormRegistrar : Form
    {
        ConductorService conductorService = new ConductorService();
        ArrendadorService arrendadorService;
        internal FormRegistrar(UsuarioService usuarioService)
        {
            arrendadorService = new ArrendadorService(usuarioService.usuarioRepository);
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string nombres = txtnombres.Text.Trim();
            string apellidos = txtapellidos.Text.Trim();
            string nacionalidad = txtnacionalidad.Text.Trim();
            string correo = txtcorreo.Text.Trim();
            string contrasena = txtcontrasena.Text.Trim();
            string nuevacontrasena = txtconfirmarcontrasena.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombres) ||
                string.IsNullOrWhiteSpace(apellidos) ||
                string.IsNullOrWhiteSpace(nacionalidad) ||
                string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(contrasena) ||
                string.IsNullOrWhiteSpace(nuevacontrasena))
            {
                MessageBox.Show("Por favor completa todos los campos de texto.",
                                "Campos vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int edad;
            int telefono;
            int dni;

            if (!int.TryParse(txtedad.Text.Trim(), out edad))
            {
                MessageBox.Show("Por favor ingresa una edad válida (solo números).",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txttelefono.Text.Trim(), out telefono))
            {
                MessageBox.Show("Por favor ingresa un número de teléfono válido.",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtdni.Text.Trim(), out dni))
            {
                MessageBox.Show("Por favor ingresa un DNI válido.",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (edad < 18 || edad > 100)
            {
                MessageBox.Show("La edad debe estar entre 18 y 100 años.",
                                "Edad inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (contrasena != nuevacontrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden.",
                                "Error de validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            Usuario usuario = new Usuario();
            {
                usuario.Nombre = nombres;
                usuario.Apellidos = apellidos;
                usuario.Edad= edad;
                usuario.Nacionalidad = nacionalidad;
                usuario.Correo = correo;
                usuario.Telefono = telefono;
                usuario.Contraseña = contrasena;
                usuario.TipoUsuario = cmbtipoususario.Text;
            }
            switch (cmbtipoususario.Text)
            {
                case "Arrendador":
                    {
                        Arrendador arrendador = new Arrendador(usuario);
                        Espacio espacio = new Espacio();
                        FormEspacioArrendador formEspacio = new FormEspacioArrendador(espacio);
                        formEspacio.FormClosed += (s, args) =>
                        {
                            bool registroA = arrendadorService.Registro(arrendador, espacio);
                            if (!registroA)
                            {
                                MessageBox.Show("El Arrendador ya fue registrado.",
                                                "Error de validación",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                                return;
                            }
                            MessageBox.Show("Registro exitoso",
                                            "Éxito",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            this.Close();
                        };
                        formEspacio.Show();
                        break;
                    }
                case "Conductor":
                    {
                        Conductor conductor = new Conductor(usuario);
                        Brevete brevete = new Brevete();
                        FormBrevete formBrevete = new FormBrevete(brevete);
                        formBrevete.FormClosed += (s, args) =>
                        {
                            bool registroB = conductorService.Registro(conductor, brevete);
                            if (!registroB)
                            {
                                MessageBox.Show("El Conductor ya fue registrado.",
                                                "Error de validación",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                                return;
                            }
                            MessageBox.Show("Registro exitoso",
                                            "Éxito",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            this.Close();
                        };
                        formBrevete.Show();
                        break;
                    }
            }
        }
    }
}
