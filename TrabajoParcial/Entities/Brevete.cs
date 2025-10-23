using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoParcial.Entities
{
    internal class Brevete
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaEmisional { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public bool Vigente { get; set; }
    }
}
