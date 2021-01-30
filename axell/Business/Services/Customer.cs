using Business.Models;
using Database.Repositories;

namespace Business.Services
{
    public class CustomerService
    {
        public static void Save(Customer customer)
        {
            BaseRepository.Save(customer);
        }
    }
}
