using SRP.NaRegra.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.NaRegra.Repository
{
    public class AulaRepository : IRepository
    { 
        public void Salvar<Aula>(Aula aula)
        {
            Console.WriteLine("Salvando Aula...");
        }
    }
}
