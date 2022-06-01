using Deloitte.NAA.API.Models.Requests;
using Deloitte.NAA.API.Models.Responses;
using Deloitte.NAA.API.Rest.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deloitte.NAA.API.Rest.Managers
{
    public class ResponseManager : IResponseManager
    {
        public ActionResult<Response<TResponse>> OkWithLog<TRequest, TResponse>(Request<TRequest> request, Response<TResponse> response)
            where TRequest : class
            where TResponse : class
        {
            //log

            return new OkObjectResult(response);
        }

        public ActionResult<Response<TResponse>> BadRequestWithLog<TRequest, TResponse>(Request<TRequest> request, IList<string> errorMessages)
            where TRequest : class
            where TResponse : class
        {
            var response = new Response<TResponse>
            {
                ErrorMessages = errorMessages
            };

            return BadRequestWithLog(request, response);
        }

        public ActionResult<Response<TResponse>> BadRequestWithLog<TRequest, TResponse>(Request<TRequest> request, Response<TResponse> response)
            where TRequest : class
            where TResponse : class
        {
            //log

            return new BadRequestObjectResult(response);
        }
    }
}
