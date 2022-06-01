using Deloitte.NAA.API.Models.Requests;
using Deloitte.NAA.API.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deloitte.NAA.API.Rest.Interfaces
{
    public interface IBaseController
    {
        Task<ActionResult<Response<TResponse>>> RunCommand<TRequest, TResponse>(Request<TRequest> request)
            where TRequest : class
            where TResponse : class;
    }
}
