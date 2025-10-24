using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoParcial
{
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

            MessageBox.Show("Registro exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormLogin formLogin = new FormLogin();
            formLogin.Show();

            this.Close();
        }
    }
}
