using ModeloCamadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3Camadas
{
  class Program
  {
    static void Main(string[] args)
    {
      Random numeroAleatorio = new Random();
      
      /*************************************PESSOA FISICA*******************************************************/
      PessoaFisica novoClientePessoaFisica = new PessoaFisica();
      
      novoClientePessoaFisica.Nome = Cliente.AlterarNomeParaCaixaAlta("cliente pessoa fisica");
      novoClientePessoaFisica.CPF = numeroAleatorio.Next();

      //Exemplo de polimorfismo
      novoClientePessoaFisica.RetornaDadosCliente();

      //Exemplo de Generics onde o "Salvar" está em uma classe base "BaseService"
      novoClientePessoaFisica.Salvar();
      
      //Exemplo de metodo implementado em uma classe Partial
      novoClientePessoaFisica.ValidaCPFClientePF(novoClientePessoaFisica.CPF);
      Console.WriteLine("=======================================================");

      /*************************************PESSOA JURIDICA*********************************************************/
      PessoaJuridica novoClientePessoaJuridica = new PessoaJuridica();

      novoClientePessoaJuridica.Nome = Cliente.AlterarNomeParaCaixaAlta("cliente Pessoa Juridica");
      novoClientePessoaJuridica.CNPJ = numeroAleatorio.Next(); ;

      novoClientePessoaJuridica.RetornaDadosCliente();
      
      //Exemplo de Generics onde o "Salvar" está em uma classe base "BaseService"
      novoClientePessoaJuridica.Salvar();
      Console.WriteLine("=======================================================");

      /***************************************CARRO   *************************************************************/
      Carro novoCarro = new Carro();
      novoCarro.Marca = "Fiat";
      novoCarro.Modelo = "Siena";

      //Exemplo de Generics onde o "Salvar" está em uma classe base "BaseService"
      novoCarro.Salvar();

      Console.WriteLine($"Novo carro da marca {novoCarro.Marca} e modelo {novoCarro.Modelo}.");
      Console.WriteLine("=======================================================");

      /***************************************CARRO 2 classe Sealed *************************************************************/
      Carro2 novoCarro2 = new Carro2();
      novoCarro2.MarcaCarro = "BMW";

      //Exemplo de Generics onde o "Salvar" está em uma classe base "BaseService"
      novoCarro2.Salvar();

      Console.WriteLine($"Novo carro da marca {novoCarro2.MarcaCarro}.");
      Console.WriteLine("=======================================================");
    }
  }
}
