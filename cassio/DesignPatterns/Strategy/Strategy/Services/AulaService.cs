using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Services
{
    public class AulaService
    {
        public static void Salvar<Entidade>(Entidade entidade  )
        {
            Console.WriteLine($"Salvo {entidade.GetType().Name} com sucesso");
        }

        public static ICollection<Entidade> Listar<Entidade>()
        {
            return new List<Entidade>();
        }

    }
}
