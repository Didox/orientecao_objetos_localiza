using Newtonsoft.Json;

namespace Axell.Models
{
    public class Customer : People
    {
        public string Card { get; set; }

        public Customer(int id, string name, string card) : base(id, name)
        {
            Card = card;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public override string Details()
        {
            return $"{{ \"name\": \"{Name}\", \"card\": \"{Card}\" }}";
        }
    }
}
