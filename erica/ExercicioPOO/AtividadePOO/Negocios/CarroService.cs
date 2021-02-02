using System;
using System.Collections.Generic;
using System.Text;
using Database;

public class CarroService
{
	public void Salvar(Carro carro)
	{
		Console.WriteLine("Salvando carro..");
		CarroDBService.Salvar(carro);
	}
}
