using Database;

namespace Business.Model
{
    // Criando Virtual Class
    public partial class Carro : IBase
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        
    }
}