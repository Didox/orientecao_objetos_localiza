using system;


namespace Strategy.Models.Implementations
{
    public interface IBankSlip
    {
        public string codeBar { get; set; };

        public string dueDate { get; set; };
    }
}