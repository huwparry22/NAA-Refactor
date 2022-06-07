using Deloitte.NAA.API.Models.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Deloitte.NAA.API.Models.Common
{
    public class Client
    {
        [Required(ErrorMessage = "ClientName required")]
        public string ClientName { get; set; }

        public string ClientDunsNumber { get; set; }

        public string UltimateHoldingCompany { get; set; }

        public string UltimateHoldingCompanyDunsNumber { get; set; }

        public string MarketListings { get; set; }

        [Required(ErrorMessage = "PeriodEnd required")]
        public DateTime? PeriodEnd { get; set; }

        [Required(ErrorMessage = "RiskRating required")]
        public RiskRating? RiskRating { get; set; }

        [Required(ErrorMessage = "IsPublicInterestEntity required")]
        public bool? IsPublicInterestEntity { get; set; }

        [Required(ErrorMessage = "IsSecRegistrant required")]
        public bool? IsSecRegistrant { get; set; }

        [Required(ErrorMessage = "IsRelatedToSecRegistrant required")]
        public bool? IsRelatedToSecRegistrant { get; set; }
    }
}
