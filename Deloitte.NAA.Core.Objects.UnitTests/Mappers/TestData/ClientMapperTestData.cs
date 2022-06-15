using Deloitte.NAA.API.Models.Common;
using Deloitte.NAA.Core.Objects.DTO.Common;
using Deloitte.NAA.Core.Objects.DTO.Enums;
using Deloitte.NAA.UnitTests.Common.TestData;
using System;
using Xunit;

namespace Deloitte.NAA.Core.UnitTests.Mappers.TestData
{
    public class ClientMapperTestData : TheoryData<BaseTestData<Client, ClientDto>>
    {
        public ClientMapperTestData()
        {
            var now = DateTime.UtcNow;

            Add(
                new BaseTestData<Client, ClientDto>
                {
                    ObjOne = new Client
                    {
                        ClientDunsNumber = "testClientDunsNumber",
                        ClientName = "testClientName",
                        IsPublicInterestEntity = true,
                        IsRelatedToSecRegistrant = true,
                        IsSecRegistrant = true,
                        MarketListings = "testMarketListings",
                        PeriodEnd = now,
                        RiskRating = API.Models.Common.Enums.RiskRating.Normal,
                        UltimateHoldingCompany = "testUltimateHoldingCompany",
                        UltimateHoldingCompanyDunsNumber = "testUltimateHoldingCompanyDunsNumber"
                    },
                    ObjTwo = new ClientDto
                    {
                        ClientDunsNumber = "testClientDunsNumber",
                        ClientName = "testClientName",
                        IsPublicInterestEntity = true,
                        IsRelatedToSecRegistrant = true,
                        IsSecRegistrant = true,
                        MarketListings = "testMarketListings",
                        PeriodEnd = now,
                        RiskRating = RiskRatingDto.Normal,
                        UltimateHoldingCompany = "testUltimateHoldingCompany",
                        UltimateHoldingCompanyDunsNumber = "testUltimateHoldingCompanyDunsNumber"
                    }
                }
            );

            Add(
                new BaseTestData<Client, ClientDto>
                {
                    ObjOne = null,
                    ExpectException = true,
                    ExceptionType = typeof(ArgumentNullException),
                }
            );
        }
    }
}
