using Database.Attributes;

namespace Business.Models
{
    [Model(Table = "orders_products")]
    public class OrderProduct
    {
        [Column]
        public Order order { get; set; }
        [Column]
        public Customer customer { get; set; }
    }
}
