using Deloitte.NAA.API.Models.Common.Enums;
using Deloitte.NAA.Core.Objects.DTO.Enums;
using Deloitte.NAA.UnitTests.Common.TestData;
using Xunit;

namespace Deloitte.NAA.Core.Objects.UnitTests.Mappers.TestData
{
    public class RiskRatingMapperTestData : TheoryData<BaseEnumTestData<RiskRating, RiskRatingDto>>
    {
        public RiskRatingMapperTestData()
        {
            Add(new BaseEnumTestData<RiskRating, RiskRatingDto>
            {
                EnumOne = RiskRating.Normal,
                EnumTwo = RiskRatingDto.Normal,
                ExpectException = false
            });

            Add(new BaseEnumTestData<RiskRating, RiskRatingDto>
            {
                EnumOne = RiskRating.Mgtn,
                EnumTwo = RiskRatingDto.Mgtn,
                ExpectException = false
            });

            Add(new BaseEnumTestData<RiskRating, RiskRatingDto>
            {
                EnumOne = RiskRating.Gtn,
                EnumTwo = RiskRatingDto.Gtn,
                ExpectException = false
            });
        }
    }
}
