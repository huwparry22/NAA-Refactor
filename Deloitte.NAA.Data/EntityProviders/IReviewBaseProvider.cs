using Deloitte.NAA.Data.Entities;
using System.Threading.Tasks;

namespace Deloitte.NAA.Data.EntityProviders
{
    public interface IReviewBaseProvider : IEntityProvider<ReviewBase>
    {
        Task<ReviewBase> GetByReviewBaseId(int reviewBaseId);
    }
}
