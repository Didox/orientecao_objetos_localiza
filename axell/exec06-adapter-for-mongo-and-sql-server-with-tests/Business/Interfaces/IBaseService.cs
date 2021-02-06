using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NetCoreApi.Business.Interfaces
{
    public interface IBaseService<T>
    {
        void Create(T t);
        void Update(T t);
        void Delete(T t);
        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] expressions);
        IEnumerable<T> Filter(
            Expression<Func<T, bool>> where = null,
            params Expression<Func<T, object>>[] expressions
        );
    }
}
