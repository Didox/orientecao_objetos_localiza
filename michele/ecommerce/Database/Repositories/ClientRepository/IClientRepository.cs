namespace Database.Repositories.ClientRepository
{
    public interface IClientRepository
    {
        T Create<T>(T client);
        void Delete<T>(T obj);

    }
}