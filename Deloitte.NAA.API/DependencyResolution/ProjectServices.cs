using Deloitte.NAA.API.Interfaces;
using Deloitte.NAA.API.Mappers;
using Deloitte.NAA.API.Models.Common;
using Deloitte.NAA.API.Models.Interfaces;
using Deloitte.NAA.API.Models.Requests;
using Deloitte.NAA.API.Models.Requests.Dockets;
using Deloitte.NAA.API.Models.Responses.Dockets;
using Deloitte.NAA.API.Processes;
using Deloitte.NAA.API.Processes.Docket;
using Deloitte.NAA.API.Validation.Common;
using Deloitte.NAA.API.Validation.Docket;
using FluentValidation;
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
        public static void AddApiServices(this IServiceCollection services)
        {
            services.AddTransient<IApiProcessFactory, ApiProcessFactory>();

            services.AddTransient<IApiProcess<DocketCreateRequest, DocketCreateResponse>, DocketCreateApiProcess>();
            services.AddTransient<IApiProcess<DocketGetRequest, DocketGetResponse>, DocketGetApiProcess>();

            services.AddTransient<IValidator<Request<DocketCreateRequest>>, DocketCreateValidation>();
            services.AddTransient<IValidator<Docket>, DocketValidation>();
            services.AddTransient<IValidator<Client>, ClientValidation>();

            services.AddTransient<IValidationResultMapper, ValidationResultMapper>();
        }
    }
}
