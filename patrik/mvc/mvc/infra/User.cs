using System.Collections.Generic;

namespace mvc.Infra
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Perfil { get; set; }

        public static List<User> usuarios = new List<User>
        {
            new User()
            {
                Name = "Patrik Olivera",
                Email = "patrik@gmail.com",
                Password = "123",
                Perfil = "Admin"
            },
            new User()
            {
                Name = "Patrik Rodrigues",
                Email = "rodrigues@gmail.com",
                Password = "123",
                Perfil = "Editor"
            },
            new User()
            {
                Name = "Zé das Couves",
                Email = "ze.couves@gmail.com",
                Password = "123",
                Perfil = "Estagiario"
            }
        };
        
        public static User getUser(string email)
        {
            return usuarios.Find(user => user.Email == email);
        }
    }
}