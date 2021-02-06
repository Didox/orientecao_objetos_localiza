using LoginWithCookies.Enums;
using System.ComponentModel.DataAnnotations;

namespace LoginWithCookies.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Usuário é requerido!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Senha é requerida!")]
        public string Senha { get; set; }
        public Roles Role { get; set; }
        public bool Authorized { get; set; } = false;
    }
}
