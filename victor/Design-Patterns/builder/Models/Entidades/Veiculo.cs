namespace builder.Models.Entidades
{
    public class Veiculo
    {
        public int Id { get; set; }
        public Concessionaria _concessionaria { get; set; }

        public Veiculo(int Id, Concessionaria concessionaria)
        {
            this._concessionaria = concessionaria;
            this.Id = Id;
        }

    }
}