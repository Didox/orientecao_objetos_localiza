using System;

namespace Modelo.Cliente
{
    public class Cliente
    {
         public int Codigo { get; set; }
        public string Nome { get; set; }

        public Cliente(int novoCodigo, string novoNome)
        {
            this.Codigo = novoCodigo;
            this.Nome = novoNome;
        }

        public static string AlterarNomeParaCaixaAlta(string nome)
        {
            return nome.ToUpper();
        }
        
  
    }
}