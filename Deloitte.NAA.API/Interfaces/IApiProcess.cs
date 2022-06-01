using Deloitte.NAA.API.Models.Requests;
using Deloitte.NAA.API.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deloitte.NAA.API.Interfaces
{
    public interface IApiProcess<TRequest, TResponse>
        where TRequest : class
        where TResponse : class
    {
        Task<Response<TResponse>> Validate(Request<TRequest> request);

        Task<Response<TResponse>> Execute(Request<TRequest> request);
    }
}
