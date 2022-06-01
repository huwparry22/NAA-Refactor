using Deloitte.NAA.API.Models.Common;
using Deloitte.NAA.Core.Objects.DTO.Common;
using Deloitte.NAA.Core.Objects.Interfaces;
using Deloitte.NAA.Core.Objects.Mappers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ProjectServices
    {
        public static void AddCoreObjectsServices(this IServiceCollection services)
        {
            services.AddTransient<IMapper<Docket, DocketDto>, DocketMapper>();
            services.AddTransient<IMapper<Client, ClientDto>, ClientMapper>();
        }
    }
}
