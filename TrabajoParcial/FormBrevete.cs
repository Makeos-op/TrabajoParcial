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
    public partial class FormBrevete : Form
    {
        public FormBrevete()
        {
            InitializeComponent();
        }

        private void btnregistrarbrevete_Click(object sender, EventArgs e)
        {
            // --- Obtener valores de los TextBox ---
            string idText = txtidbrevete.Text.Trim();
            string categoria = txtcategoriabrevete.Text.Trim();
            string fechaEmisionText = txtcategoriabrevete.Text.Trim();
            string fechaCaducidadText = txtfechacaducidad.Text.Trim();

            if (string.IsNullOrWhiteSpace(idText) ||
                string.IsNullOrWhiteSpace(categoria) ||
                string.IsNullOrWhiteSpace(fechaEmisionText) ||
                string.IsNullOrWhiteSpace(fechaCaducidadText))
            {
                MessageBox.Show("Por favor completa todos los campos antes de registrar.",
                                "Campos vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int id;
            DateTime fechaEmision;
            DateTime fechaCaducidad;

            if (!int.TryParse(idText, out id))
            {
                MessageBox.Show("El ID debe ser un número entero válido.",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(fechaEmisionText, out fechaEmision))
            {
                MessageBox.Show("La fecha de emisión no tiene un formato válido. (Ejemplo: 24/10/2025)",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(fechaCaducidadText, out fechaCaducidad))
            {
                MessageBox.Show("La fecha de caducidad no tiene un formato válido. (Ejemplo: 24/10/2030)",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (fechaCaducidad <= fechaEmision)
            {
                MessageBox.Show("La fecha de caducidad debe ser posterior a la fecha de emisión.",
                                "Fechas inválidas",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (fechaEmision > DateTime.Now)
            {
                MessageBox.Show("La fecha de emisión no puede ser en el futuro.",
                                "Fecha inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Brevet registrado correctamente ",
                            "Registro exitoso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

        }
    }
}
