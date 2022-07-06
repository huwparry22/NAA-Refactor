using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deloitte.NAA.API.Validation.Common
{
    public class ClientValidation : AbstractValidator<Models.Common.Client>
    {
        public ClientValidation()
        {

        }
    }
}
