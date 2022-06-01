using Deloitte.NAA.API.Models.Responses;
using FluentValidation.Results;

namespace Deloitte.NAA.API.Interfaces
{
    public interface IValidationResultMapper
    {
        Response<TResponse> MapToApiResponse<TResponse>(ValidationResult validationResult)
            where TResponse : class, new();
    }
}
