using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.QuebrandoARegra
{
    public class Aula
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tema { get; set; }

        private static void Salvar(Aula aula)
        {
            Console.WriteLine("Salvando Aula do jeito errado!");
        }
    }
}
