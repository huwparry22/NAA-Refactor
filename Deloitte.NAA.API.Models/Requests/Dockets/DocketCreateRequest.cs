using Deloitte.NAA.API.Models.Common;
using Deloitte.NAA.API.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deloitte.NAA.API.Models.Requests.Dockets
{
    public class DocketCreateRequest : IDocket
    {
        public Docket Docket { get; set; }
    }
}
