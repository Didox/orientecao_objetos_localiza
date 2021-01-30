using System;

public class CarroService
{
	public void Salvar(Carro carro)
	{
		Console.WriteLine("Salvando carro..");
		CarroDBService.Salvar(carro);
	}
}
