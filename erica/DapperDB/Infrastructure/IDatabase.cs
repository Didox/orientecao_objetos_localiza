namespace DapperDB.Infrastructure
{
    public interface IDatabase<T> where T : class
    {
        void Save(T obj);
        List<T> All(string sqlWhere = null);
        void Remove(T obj);
    }
}