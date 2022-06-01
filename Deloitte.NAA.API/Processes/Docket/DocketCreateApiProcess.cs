using Deloitte.NAA.API.Interfaces;
using Deloitte.NAA.API.Models.Requests;
using Deloitte.NAA.API.Models.Requests.Dockets;
using Deloitte.NAA.API.Models.Responses;
using Deloitte.NAA.API.Models.Responses.Dockets;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deloitte.NAA.API.Processes.Docket
{
    public class DocketCreateApiProcess : IApiProcess<DocketCreateRequest, DocketCreateResponse>
    {
        private readonly IValidator<Request<DocketCreateRequest>> _docketCreateValidation;
        private readonly IValidationResultMapper _validationResultMapper;

        public DocketCreateApiProcess(
            IValidator<Request<DocketCreateRequest>> docketCreateValidation,
            IValidationResultMapper validationResultMapper)
        {
            _docketCreateValidation = docketCreateValidation;
            _validationResultMapper = validationResultMapper;
        }

        public async Task<Response<DocketCreateResponse>> Execute(Request<DocketCreateRequest> request)
        {
            var validationResult = await _docketCreateValidation.ValidateAsync(request).ConfigureAwait(false);

            return _validationResultMapper.MapToApiResponse<DocketCreateResponse>(validationResult);
        }

        public async Task<Response<DocketCreateResponse>> Validate(Request<DocketCreateRequest> request)
        {
            throw new NotImplementedException();
        }
    }
}
