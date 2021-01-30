using Negocio.Modelos;
using Negocio.Servico;
using System.Collections.Generic;

namespace Visao
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> temasAbordados = new List<string>()
            {
                "Git - GitHub", "Pull Requests", "Dotnet CLI", "Estrutura simples do C#"
            };

            List<Aula> aulasParaSalvar = new List<Aula>();
            var _dbService = new AulaDBService();

            foreach (var tema in temasAbordados)
            {
                var aula = new Aula(tema);
                aulasParaSalvar.Add(aula);
                aula.MostrarTemaAula();
            }

            aulasParaSalvar.ForEach(aula => _dbService.Salvar(aula));

        }
    }
}
