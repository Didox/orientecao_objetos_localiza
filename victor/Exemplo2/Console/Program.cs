using Business.Model;
using Business.Services;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new CarroService();
            carro.Salvar(new Carro()
            {
                Id = 1,
                Marca = "Marca",
                Modelo = "Modelo",
                Ano = 2021
            });

            carro.SalvarHatch();

        }
    }
}
