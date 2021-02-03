namespace factory
{
    public class Cachorro : IAnimal
    {
        public Cachorro()
        {
            Falar();
        }
        public string Falar()
        {
            System.Console.WriteLine("Au");
        }
    }
}