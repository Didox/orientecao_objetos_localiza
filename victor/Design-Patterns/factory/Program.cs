using System;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFactory.FabricaAnimal(TipoAnimal.GATO);
        }
    }
}
