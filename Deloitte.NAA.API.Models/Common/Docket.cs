using System.ComponentModel.DataAnnotations;

namespace Deloitte.NAA.API.Models.Common
{
    public class Docket
    {
        [Required(ErrorMessage = "Client required")]
        public Client Client { get; set; }

        [Required(ErrorMessage = "PartnerOfficeId required")]
        public int PartnerOfficeId { get; set; }

        [Required(ErrorMessage = "OperatingUnit required")]
        public string OperatingUnit { get; set; }

        [Required(ErrorMessage = "ChargeCode required")]
        public string ChargeCode { get; set; }

        [Required(ErrorMessage = "MemberFirmName required")]
        public string MemberFirmName { get; set; }
    }
}
