﻿using Negocio;
using System;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {   
            Carro carro = new Carro();
            carro.Ano = 2020;
            carro.Nome = "Palio";
            CarroService.Salvar(carro);
        }
    }
}
