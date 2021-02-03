namespace builder.Models.Entidades
{
    public class VeiculoBuilder
    {
        public static Veiculo construir(int id, string marca, string cor, TipoDeVeiculo tipoDeVeiculo)
        {
            return new Veiculo(id, new Concessionaria(){Marca = marca, Cor = cor, Tipo = tipoDeVeiculo});
        }
    }
}