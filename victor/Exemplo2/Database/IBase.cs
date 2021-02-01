namespace Database
{
    public interface IBase
    {
        int Id { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }
        int Ano { get; set; }
    }
}
