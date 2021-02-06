using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace NetCoreApi.Database
{
    public interface IDBEnv
    {
        string GetConnectionString();
    }
}
