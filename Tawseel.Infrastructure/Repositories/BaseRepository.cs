using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tawseel.Domain.Entities;
using Tawseel.Domain.Repositories;
using Tawseel.Infrastructure.Data;

namespace Tawseel.Infrastructure.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : RootEntity
    {
        private readonly WriteDbContext _context;

        public BaseRepository(WriteDbContext context)
        {
            _context = context;
        }
        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            _context.Set<T>().Update(entity);
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).AsNoTracking();
        }

        public async Task<T?> GetById(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            return entity;
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
