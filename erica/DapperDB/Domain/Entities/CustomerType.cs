namespace DapperDB.Domain.Entities
{
    [Table("CustomerType")]
    public class CustomerType
    {
        [Key]
        public int id {get;set;}
        public string name {get;set;}
    }
}