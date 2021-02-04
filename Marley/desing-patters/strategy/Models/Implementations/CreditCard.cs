using system;


namespace Strategy.Models.Implementations

{
    public class BankSlip : IPaymentMethod, IBankSlip
    {
        public int Id {get;set;}
        
        public string Name {get;set;}
        
        public string codeBar { get; set; };

        public string dueDate { get; set; };


        void ICreditCard.Pay()
        {
            Console.WriteLine("Paying with bank slip!!!");
        }
    }
}