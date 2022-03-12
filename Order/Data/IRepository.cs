using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Order.Models.Entities;

namespace Order.Data
{
    public interface IRepository<T> where T: class,IEntity
    {
        Task<T> GetEntityByIdAsync(int id);
        Task<List<T>> GetsAsync(Expression<Func<T, bool>> predicate = null);
        Task<T> SaveAsync (T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}