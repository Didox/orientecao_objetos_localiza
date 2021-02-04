namespace solid.QuebrandoRegra
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereço { get; set; }
    }


    public void Salvar(Cliente cliente)
    {
        if(!validaCliente(cliente)) throw new System.Exception("Dados incorretos para cliente");

        if(salvaClienteBanco(cliente)){
            this.disparaEmail(cliente.Email);
            this.disparaSms(cliente.Telefone);
        }
    }

    public boolean validaCliente(Cliente cliente){
        return true;
    }
    public boolean salvarBanco(Cliente cliente){
        return true;
    }
    public void disparaEmail(string email){
        Console.WriteLine("Email Enviado com Sucesso");
    }
    public void disparaSms(string telefone){
        Console.WriteLine("Email Enviado com Sucesso");
    }
}