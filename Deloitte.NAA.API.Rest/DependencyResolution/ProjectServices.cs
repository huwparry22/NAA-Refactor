using Deloitte.NAA.API.Rest.Controllers;
using Deloitte.NAA.API.Rest.Interfaces;
using Deloitte.NAA.API.Rest.Managers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ProjectServices
    {
        public static void RegisterApiRestServices(this IServiceCollection services)
        {
            services.AddTransient<IBaseController, BaseController>();
            services.AddTransient<IResponseManager, ResponseManager>();
        }
    }
}
