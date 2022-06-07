using Deloitte.NAA.API.Models.Common;
using Deloitte.NAA.API.Models.Common.Enums;
using Deloitte.NAA.Core.Objects.DTO.Common;
using Deloitte.NAA.Core.Objects.DTO.Enums;
using Deloitte.NAA.Core.Objects.Interfaces;
using System;

namespace Deloitte.NAA.Core.Objects.Mappers
{
    public class ClientMapper : IMapper<Client, ClientDto>
    {
        private readonly IEnumMapper<RiskRating, RiskRatingDto> _riskRatingMapper;

        public ClientMapper(IEnumMapper<RiskRating, RiskRatingDto> riskRatingMapper)
        {
            _riskRatingMapper = riskRatingMapper;
        }

        public ClientDto MapTo(Client objOne)
        {
            if (objOne == null)
                throw new ArgumentNullException(nameof(objOne));

            return new ClientDto
            {
                ClientDunsNumber = objOne.ClientDunsNumber,
                ClientName = objOne.ClientName,
                IsPublicInterestEntity = objOne.IsPublicInterestEntity,
                IsRelatedToSecRegistrant = objOne.IsRelatedToSecRegistrant,
                IsSecRegistrant = objOne.IsSecRegistrant,
                MarketListings = objOne.MarketListings,
                PeriodEnd = objOne.PeriodEnd,
                RiskRating = _riskRatingMapper.MapTo(objOne.RiskRating),
                UltimateHoldingCompany = objOne.UltimateHoldingCompany,
                UltimateHoldingCompanyDunsNumber = objOne.UltimateHoldingCompanyDunsNumber
            };
        }

        public Client MapTo(ClientDto objTwo)
        {
            if (objTwo == null)
                throw new ArgumentNullException(nameof(objTwo));

            return new Client
            {
                ClientDunsNumber = objTwo.ClientDunsNumber,
                ClientName = objTwo.ClientName,
                IsPublicInterestEntity = objTwo.IsPublicInterestEntity,
                IsRelatedToSecRegistrant = objTwo.IsRelatedToSecRegistrant,
                IsSecRegistrant = objTwo.IsSecRegistrant,
                MarketListings = objTwo.MarketListings,
                PeriodEnd = objTwo.PeriodEnd,
                RiskRating = _riskRatingMapper.MapTo(objTwo.RiskRating),
                UltimateHoldingCompany = objTwo.UltimateHoldingCompany,
                UltimateHoldingCompanyDunsNumber = objTwo.UltimateHoldingCompanyDunsNumber
            };
        }
    }
}
