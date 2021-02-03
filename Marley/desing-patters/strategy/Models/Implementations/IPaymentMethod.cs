using system;


namespace Strategy.Models.Implementations
{
    public interface IPaymentMethod
    {
        public int Id {get;set;}

        public string Name {get; set;}
        
        public void Pay();
    }
}
