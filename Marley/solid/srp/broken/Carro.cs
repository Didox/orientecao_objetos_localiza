using System;

namespace broken
{
    public class Carro
    {
        private string Modelo;
        private int Ano;
        
        public void Salvar()
        {
            Console.WriteLine("Salvando o carro");
        }

        public void Alugar()
        {
            Console.WriteLine("Alugando o carro");
        }

        public void Reparar()
        {
            Console.WriteLine("Reparando o carro");
        }
    }
}