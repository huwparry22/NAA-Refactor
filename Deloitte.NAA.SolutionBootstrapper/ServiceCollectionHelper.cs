using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionHelper
    {
        public static IServiceCollection AddSolutionServices(this IServiceCollection services)
        {
            services.AddSqlServerServices();
            services.AddCoreObjectsServices();
            services.AddApiServices();

            return services;
        }
    }
}
