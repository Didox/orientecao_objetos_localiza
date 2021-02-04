namespace strategy.Models.Implemented
{
    public interface IJuridica : IPessoa
    {
        string Cnpj { get; set; }
        string RazaoSocial { get; set; }

    }
}