using System;

namespace strategy.Modelos.Estrategia1
{
    public class Cliente
    {
        public int id {get;set;}
        public string nome {get;set;}
        public string telefone {get;set}
        public string email {get; set;}

        public List<Cliente> Salvar(){
            Console.WriteLine("Salvando..");
            return new List<Cliente>();
        }
    }
}