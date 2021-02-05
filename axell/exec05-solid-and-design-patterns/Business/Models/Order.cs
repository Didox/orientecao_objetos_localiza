using Database.Attributes;

namespace Business.Models
{
    [Model(Table = "orders")]
    public class Order
    {
        [Pk]
        public int Id { get; set; }
        [Column]
        public Customer Customer { get; set; }
    }
}
