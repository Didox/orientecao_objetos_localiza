using System;
using builder.Models.Entidades;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {

            VeiculoBuilder.construir(1, "Gol", "Azul", TipoDeVeiculo.HATCH);
        }
    }
}
