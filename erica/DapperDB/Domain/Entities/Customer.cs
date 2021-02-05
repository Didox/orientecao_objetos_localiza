namespace DapperDB.Domain.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int id { get; set; }

        [Fields(ColumnName = "name")]
        public string name { get; set; }
        [Fields(ColumnName = "email")]
        public string email { get; set; }
        [Fields(ColumnName = "phone")]
        public string phone { get; set; }
        public CustomerType CustomerType {get;set;}
    }
}