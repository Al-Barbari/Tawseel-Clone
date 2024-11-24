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
    public class ReadRepository<T> : IReadRepository<T> where T : RootEntity
    {
        private readonly ReadDbContext _context;

        public ReadRepository(ReadDbContext context)
        {
            _context = context;
        }
        public IQueryable<T> FindAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).AsNoTracking();
        }
    }
}
