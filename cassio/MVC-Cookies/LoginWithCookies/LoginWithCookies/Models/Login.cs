using System.ComponentModel.DataAnnotations;

namespace LoginWithCookies.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Usuário é requerido!")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Senha é requerida!")]
        public string Senha { get; set; }
    }
}
