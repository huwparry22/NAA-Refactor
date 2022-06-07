using Deloitte.NAA.API.Models.Common;
using Deloitte.NAA.API.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Deloitte.NAA.API.Models.Requests.Dockets
{
    public class DocketCreateRequest : IDocket
    {
        [Required(ErrorMessage = "Docket required")]
        public Docket Docket { get; set; }
    }
}
