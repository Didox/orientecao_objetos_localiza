
namespace WebMVC.Models
{

    public class UserLogin : IUserLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public TipoDeAcesso Acesso { get; set; }
    }
}
