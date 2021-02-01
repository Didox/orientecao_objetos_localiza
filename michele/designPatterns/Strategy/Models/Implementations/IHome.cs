namespace Models.Implementations
{
    public interface IHome
    {
        public int Id { get; set; }
        public int Adrress { get; set; }
        public int Number { get; set; }

        public string City { get; set; }
    }
}