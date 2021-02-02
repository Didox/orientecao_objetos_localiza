namespace Models.Implementations
{
    public class Appartament : IHome, IApartment
    {
        public int Id { get; set; }
        public int Adrress { get; set;}
        public int Number { get; set; }
        public string City {get; set;}
        public int NumberApparttament {get; set;}
    }
}