using System;
using System.Collections.Generic;

namespace hugo.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        private string nome;
        private string nomePrivado;
        

        public string Nome{
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }

        public void Salvar(){
            Console.WriteLine("Salvou cliente");
        }

        public static List<Cliente> BuscaPorNome(string nome){
            return new List<Cliente>();
        }
        
    }
}