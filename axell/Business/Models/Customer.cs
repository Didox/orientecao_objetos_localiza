using Database.Attributes;

namespace Business.Models
{
    [Model(Table = "customers")]
    public class Customer : People
    {
        [Column]
        public string Card { get; set; }

        public Customer(int id, string name, string card) : base(id, name)
        {
            Card = card;
        }

        public override string Details()
        {
            return $"{{ \"name\": \"{Name}\", \"card\": \"{Card}\" }}";
        }
    }
}
