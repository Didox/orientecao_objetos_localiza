using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using NetCoreApi.Business.Interfaces;
using NetCoreApi.Database.Interfaces;

namespace NetCoreApi.Business.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        protected readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository) => this._repository = repository;

        public void Create(T t)
        {
            _repository.Add(t);
        }

        public void Update(T t)
        {
            _repository.Update(t);
        }

        public void Delete(T t)
        {
            _repository.Delete(t);
        }

        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] expressions)
        {
            return _repository.GetAll(expressions);
        }

        public IEnumerable<T> Filter(
            Expression<Func<T, bool>> where = null,
            params Expression<Func<T, object>>[] expressions
        )
        {
            return _repository.Filter(where, expressions);
        }
    }
}
