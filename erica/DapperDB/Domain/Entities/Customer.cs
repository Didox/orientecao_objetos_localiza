namespace DapperDB.Domain.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        [ExplicitKey]
        public CustomerType CustomerType {get;set;}
    }
}