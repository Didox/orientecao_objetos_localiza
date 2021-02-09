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
    public interface IUserRepository
    {
        Task<int> CountByIdAndEmail(int id, string email);
        Task<int> CountByEmail(string email);
        Task<User> FindById(int id);
        Task Update(User user);
        Task Save(User user);
        Task Delete(User user);
        Task<ICollection<UserView>> All();
    }
}
