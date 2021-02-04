using Database.Attributes;

namespace Business.Models
{
    [Model(Table = "customers")]
    public class Customer
    {
        [Pk]
        public int Id { get; set; }
        [Column]
        public string Name { get; set; }
    }
}
