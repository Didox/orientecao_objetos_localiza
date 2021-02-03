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
            var _dbAulaService = new AulaDBService();

            foreach (var tema in temasAbordados)
            {
                var aula = new Aula(tema);
                aulasParaSalvar.Add(aula);
                aula.MostrarTemaAula();
            }

            aulasParaSalvar.ForEach(aula => _dbAulaService.Salvar(aula));
            var listaAulas = _dbAulaService.Listar();

            listaAulas.ForEach(aula => System.Console.WriteLine("Aula: " + ((Aula)aula).Tema));

        }
    }
}
