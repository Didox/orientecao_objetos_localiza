using strategy.Models.Implemented;

namespace strategy
{
    public class Program
    {
        static void Main(string[] args)
        {


            PessoaService.Salvar(new Pessoa()
            {
                Nome = "Victor"
            });

            PessoaService.Listar();



        }
    }
}