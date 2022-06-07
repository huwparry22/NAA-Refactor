using Deloitte.NAA.API.Models.Common;
using Deloitte.NAA.API.Models.Common.Enums;
using Deloitte.NAA.Core.Objects.DTO.Common;
using Deloitte.NAA.Core.Objects.DTO.Enums;
using Deloitte.NAA.Core.Objects.Interfaces;
using Deloitte.NAA.Core.Objects.Mappers;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ProjectServices
    {
        public static void AddCoreObjectsServices(this IServiceCollection services)
        {
            services.AddTransient<IMapper<Docket, DocketDto>, DocketMapper>();
            services.AddTransient<IMapper<Client, ClientDto>, ClientMapper>();

            services.AddTransient<IEnumMapper<RiskRating, RiskRatingDto>, RiskRatingMapper>();
        }
    }
}
