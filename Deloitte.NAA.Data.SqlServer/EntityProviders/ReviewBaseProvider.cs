using Deloitte.NAA.Data.Entities;
using Deloitte.NAA.Data.EntityProviders;
using Deloitte.NAA.Data.SqlServer.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Deloitte.NAA.Data.SqlServer.EntityProviders
{
    public class ReviewBaseProvider : EntityProvider<ReviewBase>, IReviewBaseProvider
    {
        public ReviewBaseProvider(NaaContext naaContext) : base(naaContext) { }

        public async Task<ReviewBase> GetByReviewBaseId(int reviewBaseId)
        {
            return await _naaContext.ReviewBase.SingleOrDefaultAsync(rb => rb.ReviewBaseId == reviewBaseId).ConfigureAwait(false);
        }
    }
}
