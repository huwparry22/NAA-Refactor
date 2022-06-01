using Deloitte.NAA.API.Models.Requests;
using Deloitte.NAA.API.Models.Requests.Dockets;
using Deloitte.NAA.API.Models.Responses;
using Deloitte.NAA.API.Models.Responses.Dockets;
using Deloitte.NAA.API.Rest.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deloitte.NAA.API.Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocketController : ControllerBase
    {
        private readonly IBaseController _baseController;

        public DocketController(IBaseController baseController)
        {
            _baseController = baseController;
        }

        [HttpPost("Create")]
        public async Task<ActionResult<Response<DocketCreateResponse>>> PostCreate([FromBody] Request<DocketCreateRequest> request)
        {
            return await _baseController.RunCommand<DocketCreateRequest, DocketCreateResponse>(request).ConfigureAwait(false);
        }

        [HttpGet("Get")]
        public async Task<ActionResult<Response<DocketGetResponse>>> Get([FromQuery] int docketId)
        {
            var request = new Request<DocketGetRequest>
            {
                RequestData = new DocketGetRequest
                {
                    DocketId = docketId
                }
            };

            return await _baseController.RunCommand<DocketGetRequest, DocketGetResponse>(request).ConfigureAwait(false);
        }
    }
}
