using Deloitte.NAA.API.Models.Common.Enums;
using System;

namespace Deloitte.NAA.API.Models.Common
{
    public class Client
    {
        public string ClientName { get; set; }

        public string ClientDunsNumber { get; set; }

        public string UltimateHoldingCompany { get; set; }

        public string UltimateHoldingCompanyDunsNumber { get; set; }

        public string MarketListings { get; set; }

        public DateTime PeriodEnd { get; set; }

        public RiskRating RiskRating { get; set; }

        public bool IsPublicInterestEntity { get; set; }

        public bool IsSecRegistrant { get; set; }

        public bool IsRelatedToSecRegistrant { get; set; }
    }
}
