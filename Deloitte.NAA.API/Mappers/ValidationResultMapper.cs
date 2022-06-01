using Deloitte.NAA.API.Interfaces;
using Deloitte.NAA.API.Models.Common.Enums;
using Deloitte.NAA.API.Models.Responses;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace Deloitte.NAA.API.Mappers
{
    public class ValidationResultMapper : IValidationResultMapper
    {
        public Response<TResponse> MapToApiResponse<TResponse>(ValidationResult validationResult)
            where TResponse : class, new()
        {
            return new Response<TResponse>
            {
                ResponseStatus = validationResult.IsValid ? ResponseStatus.Success : ResponseStatus.Failure,
                ErrorMessages = validationResult.Errors.Any() ? new List<string>(validationResult.Errors.Select(e => e.ErrorMessage)) : null
            };
        }
    }
}
