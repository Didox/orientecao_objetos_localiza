using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NetCoreApi.Database.Interfaces
{
    public interface IBaseRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] expressions);
        IEnumerable<T> Filter(
            Expression<Func<T, bool>> where,
            params Expression<Func<T, object>>[] expressions
        );
    }
}
