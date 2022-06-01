namespace Deloitte.NAA.API.Models.Common
{
    public class Docket
    {
        public Client Client { get; set; }

        public int PartnerOfficeId { get; set; }

        public int OperatingUnit { get; set; }

        public string ChargeCode { get; set; }
    }
}
