using Deloitte.NAA.API.Interfaces;
using Deloitte.NAA.API.Models.Common.Enums;
using Deloitte.NAA.API.Models.Requests;
using Deloitte.NAA.API.Models.Responses;
using Deloitte.NAA.API.Rest.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Deloitte.NAA.API.Rest.Controllers
{
    public class BaseController : ControllerBase, IBaseController
    {
        private readonly IResponseManager _responseManager;
        private readonly IApiProcessFactory _apiProcessFactory;

        public BaseController(
            IResponseManager responseManager,
            IApiProcessFactory apiProcessFactory)
        {
            _responseManager = responseManager;
            _apiProcessFactory = apiProcessFactory;
        }

        [NonAction]
        public async Task<ActionResult<Response<TResponse>>> RunCommand<TRequest, TResponse>(Request<TRequest> request)
            where TRequest : class
            where TResponse : class
        {
            if (!ModelState.IsValid)
            {
                var errorMessages = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();

                return _responseManager.BadRequestWithLog<TRequest, TResponse>(request, errorMessages);
            }

            var apiProcess = _apiProcessFactory.GetApiProcess<TRequest, TResponse>();

            var validateResponse = await apiProcess.Validate(request).ConfigureAwait(false);

            if (validateResponse?.ResponseStatus == ResponseStatus.Failure)
            {
                return _responseManager.BadRequestWithLog(request, validateResponse);
            }

            var executeResponse = await apiProcess.Execute(request).ConfigureAwait(false);

            return _responseManager.OkWithLog(request, executeResponse);
        }
    }
}
