using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoParcial.Entities;

namespace TrabajoParcial.Repositories
{
    internal class BreveteRepository
    {
        private static List<Brevete> brevetesRegistados = new List<Brevete>();
        public bool Registro(Brevete brevete)
        {
            if (Duplicado(brevete.Id))
            {
                return false;
            }
            brevetesRegistados.Add(brevete);
            return true;
        }
        public bool Duplicado(int id)
        {
            return brevetesRegistados.Any(b => b.Id.Equals(id));
        }
    }
}
