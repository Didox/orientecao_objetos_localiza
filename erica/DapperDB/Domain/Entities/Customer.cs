namespace DapperDB.Domain.Entities
{
    public class Customer
    {
        [Pk(Name="id")]
        public int id { get; set; }

        [Fields(ColumnName = "name")]
        public string name { get; set; }
        [Fields(ColumnName = "email")]
        public string email { get; set; }
        [Fields(ColumnName = "phone")]
        public string phone { get; set; }
    }
}