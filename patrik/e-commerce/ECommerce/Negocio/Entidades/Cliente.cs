namespace Negocio.Entidades
{
    public class Cliente : IPessoa, IFisica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        
        public string Cpf { get; set; }
        
        public string Telefone { get; set; }
    }
}