namespace strategy.Modelos.Implementado
{
    public interface ICarro : IVeiculo
    {
        public int QuantidadePortas { get; set; }

        public void Salvar();
    }
}