using System;

namespace factory
{
    public class AnimalFactory
    {
        public static IAnimal FabricaAnimal(TipoAnimal tipo)
        {
            switch (tipo)

            {
                case TipoAnimal.CACHORRO:
                    return Cachorro;
                case TipoAnimal.GATO:
                    return Gato;
                default:
                    throw new Exception("Animal não existente");
            }
        }
    }
}