using System.Threading.Tasks;

namespace Deloitte.NAA.Data
{
    public interface IEntityProvider<T> where T : class
    {
        Task<T> SaveAsync(T entity);
    }
}
