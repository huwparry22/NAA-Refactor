using Deloitte.NAA.API.Models.Common;
using Deloitte.NAA.API.Models.Common.Enums;
using Deloitte.NAA.Core.Interfaces;
using Deloitte.NAA.Core.Mappers;
using Deloitte.NAA.Core.Objects.DTO.Common;
using Deloitte.NAA.Core.Objects.DTO.Enums;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ProjectServices
    {
        public static void RegisterCoreServices(this IServiceCollection services)
        {
            services.AddTransient<IMapper<Docket, DocketDto>, DocketMapper>();
            services.AddTransient<IMapper<Client, ClientDto>, ClientMapper>();

            services.AddTransient<IEnumMapper<RiskRating, RiskRatingDto>, RiskRatingMapper>();
        }
    }
}
