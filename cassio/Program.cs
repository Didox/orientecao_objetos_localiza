using System;
using System.Collections.Generic;
using PrimeiraAulaCSharp;

namespace cassio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> temasAbordados = new List<string>()
            {
                "Git - GitHub", "Pull Requests", "Dotnet CLI", "Estrutura simples do C#"
            };

            var aula = new Aula();
            foreach (var tema in temasAbordados)
            {
                aula.Tema = tema;
                Console.WriteLine(aula.Tema);
            }

        }
    }
}
