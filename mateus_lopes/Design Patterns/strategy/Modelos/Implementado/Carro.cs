using System;

namespace strategy.Modelos.Implementado
{
    public class Carro : ICarro, IVeiculo
    {
        public string Placa { get; set; }
        public int QuantidadeRodas { get ; set ; }
        public string Documento { get ; set ; }
        public int QuantidadePortas { get ; set ; }

        public void Salvar()
        {
            Console.WriteLine("Salvar Carro");
        }
    }
}