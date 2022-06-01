using Deloitte.NAA.API.Models.Common;
using Deloitte.NAA.Core.Objects.DTO.Common;
using Deloitte.NAA.Core.Objects.Interfaces;
using System;

namespace Deloitte.NAA.Core.Objects.Mappers
{
    public class ClientMapper : IMapper<Client, ClientDto>
    {
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
                //RiskRating = objOne.RiskRating,
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
                //RiskRating = objTwo.RiskRating,
                UltimateHoldingCompany = objTwo.UltimateHoldingCompany,
                UltimateHoldingCompanyDunsNumber = objTwo.UltimateHoldingCompanyDunsNumber
            };
        }
    }
}
