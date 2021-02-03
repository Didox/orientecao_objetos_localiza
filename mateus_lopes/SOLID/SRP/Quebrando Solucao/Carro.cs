using System;

namespace mateus_lopes.SOLID.SRP.Quebrando_Solucao
{
    public class Carro
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }


        public void Salvar()
        {
            Console.WriteLine("Salvando Carro");
        }

        public void EnviarSms()
        {
            Console.WriteLine("Enviando Sms");
        }

        public void Validando()
        {
            Console.WriteLine("Validando Carro");
        }
    }
}