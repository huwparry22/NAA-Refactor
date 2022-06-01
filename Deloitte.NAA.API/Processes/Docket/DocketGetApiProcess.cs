using Deloitte.NAA.API.Interfaces;
using Deloitte.NAA.API.Models.Requests;
using Deloitte.NAA.API.Models.Requests.Dockets;
using Deloitte.NAA.API.Models.Responses;
using Deloitte.NAA.API.Models.Responses.Dockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deloitte.NAA.API.Processes.Docket
{
    public class DocketGetApiProcess : IApiProcess<DocketGetRequest, DocketGetResponse>
    {
        public async Task<Response<DocketGetResponse>> Execute(Request<DocketGetRequest> request)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<DocketGetResponse>> Validate(Request<DocketGetRequest> request)
        {
            throw new NotImplementedException();
        }
    }
}
