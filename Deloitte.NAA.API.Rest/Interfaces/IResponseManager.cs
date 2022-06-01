using Deloitte.NAA.API.Models.Requests;
using Deloitte.NAA.API.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Deloitte.NAA.API.Rest.Interfaces
{
    public interface IResponseManager
    {
        ActionResult<Response<TResponse>> OkWithLog<TRequest, TResponse>(Request<TRequest> request, Response<TResponse> response)
            where TRequest : class
            where TResponse : class;

        ActionResult<Response<TResponse>> BadRequestWithLog<TRequest, TResponse>(Request<TRequest> request, IList<string> errorMessages)
            where TRequest : class
            where TResponse : class;

        ActionResult<Response<TResponse>> BadRequestWithLog<TRequest, TResponse>(Request<TRequest> request, Response<TResponse> response)
            where TRequest : class
            where TResponse : class;
    }
}
