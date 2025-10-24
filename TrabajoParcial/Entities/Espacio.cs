using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoParcial.Entities
{
    internal class Espacio
    {
        public Espacio() { }
        public int Id { get; set; }
        public double TarifaHora { get; set; }
        public string Ubicacion { get; set; }
        public string Area { get; set; }
        public int DniArrendador { get; set; }
    }
}
