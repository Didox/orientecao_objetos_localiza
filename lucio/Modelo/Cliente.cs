using System;

namespace Modelo.Cliente
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Cliente()
        {

        }
        public Cliente(int novoCodigo, string novoNome, int idadeCliente)
        {
            this.Codigo = novoCodigo;
            this.Nome = novoNome;
            this.Idade = idadeCliente; 
        }

        public static string AlterarNomeParaCaixaAlta(string nome)
        {
            return nome.ToUpper();
        }

        public virtual void RetornaDadosCliente()
        {
            Console.WriteLine($"Nome do Cliente: {Nome}");
        }
        
  
    }
}