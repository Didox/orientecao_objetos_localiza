using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public static partial class Contexto<T> where T : Entity
    {
       
        public static T BuscaPorNome(string nome)
        {
            return _entities
                .Where(e => e.Nome == nome)
                .FirstOrDefault();
        }

    }
}
