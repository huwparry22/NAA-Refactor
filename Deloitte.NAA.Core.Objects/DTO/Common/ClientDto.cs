using Deloitte.NAA.Core.Objects.DTO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deloitte.NAA.Core.Objects.DTO.Common
{
    public class ClientDto
    {
        public string ClientName { get; set; }

        public string ClientDunsNumber { get; set; }

        public string UltimateHoldingCompany { get; set; }

        public string UltimateHoldingCompanyDunsNumber { get; set; }

        public string MarketListings { get; set; }

        public DateTime PeriodEnd { get; set; }

        public RiskRatingDto RiskRating { get; set; }

        public bool IsPublicInterestEntity { get; set; }

        public bool IsSecRegistrant { get; set; }

        public bool IsRelatedToSecRegistrant { get; set; }
    }
}
