using System;
using System.Linq;
using System.Threading.Tasks;
using api.Domain.Entities;
using api.Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace api.Domain.UseCase.UserService
{
    public class UserRepository
    {
        private readonly EntityContext context;
        public UserRepository(EntityContext context)
        {
          this.context = context;
        }

        public async Task Save(User user)
        {
          if(user.Id > 0)
          {
            var size = await context.Users.Where(u => u.Id != user.Id && u.Email == u.Email).CountAsync();
            if(size > 0) throw new UserUniqMail("Email já cadastrado");
            context.Users.Update(user);
          }
          else
          {
            var size = await context.Users.Where(u => u.Email == u.Email).CountAsync();
            if(size > 0) throw new UserUniqMail("Email já cadastrado");
            context.Users.Add(user);
          }

          await context.SaveChangesAsync(); 
        }

        public async Task Delete(int id)
        {
          if(id == 0) throw new UserEmptyId("Id não pode ser vazio");
          var user = await context.Users.FindAsync(id);
          if(user == null) throw new UserNotFound("Usuário não encontrado");

          context.Users.Remove(user);
          await context.SaveChangesAsync(); 
        }
    }
}
