namespace MVC.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Senha { get; set; }

        public Usuario GetUsuario()
        {
            return new Usuario
            {
                Nome = "danilo",
                Senha = "123"
            };
        }


    }

}