namespace Megocio.Servicos.Provedores
{
    public interface IServicoEnviar
    {
        string De { get; set; }
        string Para { get; set; }
        
        public void Enviar();
    }
}