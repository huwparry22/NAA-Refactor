using Deloitte.NAA.Data;
using Deloitte.NAA.Data.EntityProviders;
using Deloitte.NAA.Data.SqlServer;
using Deloitte.NAA.Data.SqlServer.Context;
using Deloitte.NAA.Data.SqlServer.EntityProviders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ProjectServices
    {
        public static void AddSqlServerServices(this IServiceCollection services)
        {
            services.ConfigureSqlServerConnection();

            services.AddEntityProviders();
        }

        private static void ConfigureSqlServerConnection(this IServiceCollection services)
        {
            var configuration = services.BuildServiceProvider().GetService<IConfiguration>();

            var connectionString = configuration.GetConnectionString("NaaConnectionString");

            services.AddDbContext<NaaContext>(options => options.UseSqlServer(connectionString));
        }

        private static void AddEntityProviders(this IServiceCollection services)
        {
            services.AddTransient(typeof(IEntityProvider<>), typeof(EntityProvider<>));

            services.AddTransient<IReviewBaseProvider, ReviewBaseProvider>();
        }
    }
}
