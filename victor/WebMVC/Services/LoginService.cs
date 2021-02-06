using System.Collections.Generic;
using WebMVC.Models;

namespace WebMVC.Services
{
    public class LoginService
    {
        // chamada do Repositório
        public static UserLogin ValidaLogin(string username, string password)
        {
            // Criar objeto de teste e retorna uma "key"
            List<UserLogin> userLogin = new List<UserLogin>();
            userLogin.Add(new UserLogin(){Username = "victor",Password = "senha",Acesso = TipoDeAcesso.ADMIN});
            userLogin.Add(new UserLogin(){Username = "felipe",Password = "senha",Acesso = TipoDeAcesso.USUARIO});
            
            string key = username.ToLower() + password;
            
            UserLogin result = userLogin.Find(x => x.Username.ToLower() + x.Password == key);

            if (result is not null)
            {
                System.Console.WriteLine("PEGOU!");
                return result;
            }
            else
            {
                System.Console.WriteLine("FALHOU!");
                return null;
            }
        }
    }
}
