using Deloitte.NAA.API.Models.Common;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deloitte.NAA.API.Validation.Common
{
    public class DocketValidation : AbstractValidator<Models.Common.Docket>
    {
        public DocketValidation()
        {

        }
    }
}
