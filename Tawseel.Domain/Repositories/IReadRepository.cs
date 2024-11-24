using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tawseel.Domain.Entities;

namespace Tawseel.Domain.Repositories
{
    public interface IReadRepository<T> where T : RootEntity
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
    }
}
