namespace factory
{
    public class Gato : IAnimal
    {
        public Gato()
        {
            Falar();
        }
        public string Falar()
        {
            System.Console.WriteLine("Miau");
        }
    }
}