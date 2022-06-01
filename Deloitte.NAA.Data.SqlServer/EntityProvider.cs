using Deloitte.NAA.Data.SqlServer.Context;
using System.Threading.Tasks;

namespace Deloitte.NAA.Data.SqlServer
{
    public class EntityProvider<T> : IEntityProvider<T> where T : class
    {
        internal readonly NaaContext _naaContext;

        public EntityProvider(NaaContext naaContext)
        {
            _naaContext = naaContext;
        }

        public async Task<T> SaveAsync(T entity)
        {
            using (var transaction = await _naaContext.Database.BeginTransactionAsync().ConfigureAwait(false))
            {
                try
                {
                    var entityEntry = _naaContext.Entry(entity);

                    switch (entityEntry.State)
                    {
                        case Microsoft.EntityFrameworkCore.EntityState.Added:
                        case Microsoft.EntityFrameworkCore.EntityState.Detached:
                            _naaContext.Set<T>().Add(entity);
                            break;
                        case Microsoft.EntityFrameworkCore.EntityState.Modified:
                            _naaContext.Set<T>().Update(entity);
                            break;
                        case Microsoft.EntityFrameworkCore.EntityState.Deleted:
                            _naaContext.Set<T>().Remove(entity);
                            break;
                        case Microsoft.EntityFrameworkCore.EntityState.Unchanged:
                            //no change
                            break;
                    }

                    await _naaContext.SaveChangesAsync().ConfigureAwait(false);

                    await transaction.CommitAsync().ConfigureAwait(false);

                    return entity;
                }
                catch
                {
                    await transaction.RollbackAsync().ConfigureAwait(false);

                    throw;
                }
            }
        }
    }
}
