namespace Strategy.Modelos.Implementado
{
    public interface IPessoa
    {
        public int  Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public void Salvar();
    }
}