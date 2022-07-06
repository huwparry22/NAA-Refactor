using Deloitte.NAA.API.Models.Interfaces;
using Deloitte.NAA.API.Models.Requests;
using Deloitte.NAA.API.Models.Requests.Dockets;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deloitte.NAA.API.Validation.Docket
{
    public class DocketCreateValidation : AbstractValidator<Request<DocketCreateRequest>>
    {
        public DocketCreateValidation(IValidator<Models.Common.Client> clientValidator, IValidator<Models.Common.Docket> docketValidator)
        {
            RuleFor(req => req.RequestData.Docket.Client).SetValidator(clientValidator);
            RuleFor(req => req.RequestData.Docket).SetValidator(docketValidator);
        }
    }
}
