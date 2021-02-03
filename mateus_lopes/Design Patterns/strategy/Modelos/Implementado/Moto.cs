using System;

namespace strategy.Modelos.Implementado
{
    public class Moto : IVeiculo, IMoto
    {
        public string Placa { get ; set; }
        public int QuantidadeRodas { get; set; }
        public string Documento { get ; set ; }
        public string Capacete { get ; set ; }

        public void Salvar()
        {
            Console.WriteLine("Salvar Moto");
        }
    }
}