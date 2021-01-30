
using System;

namespace daniloAlmeida.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Obs;
        private string _obs;

        public void SalvarBanco(){
            Console.WriteLine("salvo no banco");
        }
       
    }
}