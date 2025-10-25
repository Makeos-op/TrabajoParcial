using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace TrabajoParcial
{
    public partial class FormEspacioArrendador : Form
    {
        public FormEspacioArrendador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idText = txtidespacioalquilar.Text.Trim();
            string tarifaText = txttarifaporhora.Text.Trim();
            string ubicacion = txtubicacionalquilar.Text.Trim();
            string areaText = txtareaalquilar.Text.Trim();

            if (string.IsNullOrWhiteSpace(idText) ||
                string.IsNullOrWhiteSpace(tarifaText) ||
                string.IsNullOrWhiteSpace(ubicacion) ||
                string.IsNullOrWhiteSpace(areaText))
            {
                MessageBox.Show("Por favor complete todos los campos antes de registrar.",
                                "Campos vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int id;
            double tarifa;
            double area;

            if (!int.TryParse(idText, out id))
            {
                MessageBox.Show("El ID debe ser un número entero válido.",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(tarifaText, out tarifa))
            {
                MessageBox.Show("La tarifa debe ser un número válido (use solo dígitos o coma decimal).",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(areaText, out area))
            {
                MessageBox.Show("El área debe ser un número válido.",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (tarifa <= 0)
            {
                MessageBox.Show("La tarifa por hora debe ser mayor a 0.",
                                "Valor inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (area <= 0)
            {
                MessageBox.Show("El área debe ser mayor a 0.",
                                "Valor inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Espacio registrado correctamente",
                            "Registro exitoso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
