using Deloitte.NAA.API.Interfaces;
using System;

namespace Deloitte.NAA.API.Processes
{
    public class ApiProcessFactory : IApiProcessFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public ApiProcessFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IApiProcess<TRequest, TResponse> GetApiProcess<TRequest, TResponse>()
            where TRequest : class
            where TResponse : class
        {
            return _serviceProvider.GetService(typeof(IApiProcess<TRequest, TResponse>)) as IApiProcess<TRequest, TResponse>;
        }
    }
}
