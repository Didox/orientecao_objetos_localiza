namespace strategy.Models.Implemented
{
    public class Pessoa : IFisica, IPessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
    }
}