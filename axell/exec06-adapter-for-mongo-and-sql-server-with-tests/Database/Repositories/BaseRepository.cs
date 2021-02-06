using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NetCoreApi.Database.Contexts;
using NetCoreApi.Database.Interfaces;

namespace NetCoreApi.Database.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly DataContext _context;

        public BaseRepository(DataContext context) => _context = context;

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] expressions)
        {
            var query = _context.Set<T>().AsQueryable();
            foreach (var expression in expressions)
            {
                query = query.Include(expression);
            }
            return query.ToList();
        }

        public IEnumerable<T> Filter(
            Expression<Func<T, bool>> where,
            params Expression<Func<T, object>>[] expressions
        )
        {
            var query = _context.Set<T>().Where(where);
            foreach (var expression in expressions)
            {
                query = query.Include(expression);
            }
            return query.ToList();
        }
    }
}
