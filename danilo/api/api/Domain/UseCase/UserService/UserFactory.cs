using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Domain.Entities;
using api.Domain.ViewModel;
using api.Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace api.Domain.UseCase.UserService
{
    public class UserFactory
    {
        public UserFactory(IUserRepository repository)
        {
          this.repository = repository;
        }
        private IUserRepository repository;
        public async Task Save(User user)
        {
          if(user.Id > 0)
          {
            var size = await repository.CountByIdAndEmail(user.Id, user.Email);
            if(size > 0) throw new UserUniqMail("Email já cadastrado");
            await repository.Update(user);
          }
          else
          {
            var size = await repository.CountByEmail(user.Email);
            if(size > 0) throw new UserUniqMail("Email já cadastrado");
            await repository.Save(user);
          }
        }
        public async Task Delete(int id)
        {
          if(id == 0) throw new UserEmptyId("Id não pode ser vazio");
          var user = await repository.FindById(id);
          if(user == null) throw new UserNotFound("Usuário não encontrado");
          await repository.Delete(user);
        }

        public Task<ICollection<UserView>> All()
        {
           return repository.All();
        }
    }
}
