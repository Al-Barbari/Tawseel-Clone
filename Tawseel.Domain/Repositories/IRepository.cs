using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tawseel.Domain.Entities;

namespace Tawseel.Domain.Repositories
{
    public interface IRepository<T> where T : RootEntity
    {
        Task<T?> GetById(int id);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
