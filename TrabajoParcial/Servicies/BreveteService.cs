using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoParcial.Entities;
using TrabajoParcial.Repositories;

namespace TrabajoParcial.Servicies
{
    internal class BreveteService
    {
        private BreveteRepository breveteRepository = new BreveteRepository();

        public bool Registro(Brevete brevete)
        {
            return breveteRepository.Registro(brevete);
        }

    }
}
