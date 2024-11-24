using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        //IRepository<T> GetRepository<T>() where T : class;        
        //Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        //Task BeginTransactionAsync(CancellationToken cancellationToken = default);
        //Task CommitTransactionAsync(CancellationToken cancellationToken = default);
        //Task RollbackTransactionAsync(CancellationToken cancellationToken = default);
    }
}
