using System;
using Interfaces.Generics;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            //Servico.Buscar<Produto>();

            Cliente.Buscar();

            var cli = new Cliente();
            cli.Nome = "Torne-se um programador";
            cli.CPF = "23452123";
            cli.Salvar();

            var prod = new Produto();
            prod.Salvar();

            var ped = new Pedido();
            ped.Salvar();

            //var clienteSRP = new Interfaces.SOLID.DIP.Solucao.Cliente();
            //clienteSRP.Nome = "Danilo";
            //clienteSRP.Telefone = "123432123";
            //try
            //{
            //    new Interfaces.SOLID.DIP.Solucao.Validacao().Validar(clienteSRP);
            //    Interfaces.SOLID.DIP.Solucao.IRepositorio repo = new Interfaces.SOLID.DIP.Solucao.Repositorio();
            //    //Interfaces.SOLID.DIP.Solucao.IRepositorio repo = new Interfaces.SOLID.DIP.Solucao.RepositorioEmTexto();
            //    repo.Salvar(ref clienteSRP);
            //    Interfaces.SOLID.DIP.Solucao.ISms smsSender = new Interfaces.SOLID.DIP.Solucao.SmsVivo();
            //    //Interfaces.SOLID.DIP.Solucao.ISms smsSender = new Interfaces.SOLID.DIP.Solucao.SmsOi();
            //    new Interfaces.SOLID.DIP.Solucao.Sms().Enviar(clienteSRP, smsSender);
            //}
            //catch (Exception erro)
            //{
            //    Console.WriteLine($"Erro ao validar {erro.Message}");
            //}


            //Fruta fruta = new Toranja();
            //Fruta fruta = new Laranja();


            //APagamento cliente = new Cliente();
            //IGenerica produto = new Produto();
            //APagamento fornecedor = new Fornecedor();

            //Salvar(cliente);
            //Salvar(fornecedor);
            //Salvar(produto);


            //var cliente = new Interfaces.SOLID.SRP.QuebrandoRegra.Cliente();
            //cliente.Nome = "Danilo";
            //cliente.Telefone = "123432123";
            //cliente.Salvar();


            //var clienteSRP = new Interfaces.SOLID.SRP.Solucao.Cliente();
            //clienteSRP.Nome = "Danilo";
            //clienteSRP.Telefone = "123432123";
            //try
            //{
            //    new Interfaces.SOLID.SRP.Solucao.Validacao().Validar(clienteSRP);
            //    new Interfaces.SOLID.SRP.Solucao.Repositorio().Salvar(ref clienteSRP);
            //    new Interfaces.SOLID.SRP.Solucao.Sms().Enviar(clienteSRP);
            //}
            //catch (Exception erro)
            //{
            //    Console.WriteLine($"Erro ao validar {erro.Message}");
            //}






            //Console.WriteLine($"A cor da toranja é {fruta.Cor()}");


            //Console.ReadKey();







            /* var cliente = new Interfaces.SOLID.SRP.QuebrandoRegra.Cliente();
             cliente.Nome = "Danilo";
             cliente.Telefone = "123432123";
             cliente.Salvar();


             var clienteSRP = new Interfaces.SOLID.SRP.Solucao.Cliente();
             clienteSRP.Nome = "Danilo";
             clienteSRP.Telefone = "123432123";
             try
             {
                 new Interfaces.SOLID.SRP.Solucao.Validacao().Validar(clienteSRP);
                 new Interfaces.SOLID.SRP.Solucao.Repositorio().Salvar(ref clienteSRP);
                 new Interfaces.SOLID.SRP.Solucao.Sms().Enviar(clienteSRP);
             }
             catch (Exception erro)
             {
                 Console.WriteLine($"Erro ao validar {erro.Message}");
             }

             */

            /*Fisica pessoaFisica = new Fisica();
            IPessoa pessoaJurifica = new Juridica();

            pessoaFisica.

            pessoaJurifica.Id = 1;
            pessoaJurifica.Nome = "ssss";
            pessoaJurifica.Salvar();

            pessoaFisica.Id = 1;
            pessoaFisica.Nome = "ssss";
            pessoaFisica.Salvar();*/


            // TODO Abstração
            //Console.WriteLine("======= TUP ===========");
            //var veiculo = new Tup();
            //veiculo.Ano = 2020;
            //veiculo.Nome = "004DV";
            //veiculo.Salvar();


            //var carro = new Carro();


            /*
            Console.WriteLine("======= Tornese ===========");
            var veiculo2 = new Tornese();
            veiculo2.Ano = 2020;
            veiculo2.Nome = "005DV";
            veiculo2.Salvar();
            */

            var joao = new Joao();
            //joao.
        }

        //private static void Salvar(APagamento generica)
        //{
        //    generica.Id = 1;
        //    generica.Salvar();
        //    generica.Pagar();
        //    throw new NotImplementedException();
        //}

        //private static void Salvar(IGenerica generica)
        //{
        //    generica.Id = 1;
        //    generica.Salvar();
        //    throw new NotImplementedException();
        //}
    }
}
