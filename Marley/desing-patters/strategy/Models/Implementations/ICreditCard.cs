using system;


namespace Strategy.Models.Implementations
{
    public interface ICreditCard
    {
        public string cardNumber { get; set; };
        
        public string verificationCode { get; set; };
    }
}