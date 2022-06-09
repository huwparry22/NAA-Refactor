using Deloitte.NAA.API.Models.Common.Enums;
using Deloitte.NAA.Core.Objects.DTO.Enums;
using Deloitte.NAA.Core.Objects.Interfaces;
using Deloitte.NAA.Core.Objects.Mappers;
using Deloitte.NAA.Core.Objects.UnitTests.Mappers.TestData;
using Deloitte.NAA.UnitTests.Common.TestData;
using Xunit;

namespace Deloitte.NAA.Core.Objects.UnitTests.Mappers
{
    public class RiskRatingMapperTests : BaseEnumMapperTest<RiskRating, RiskRatingDto>
    {
        internal override IEnumMapper<RiskRating, RiskRatingDto> _objectToTest { get; set; }

        public RiskRatingMapperTests()
        {
            _objectToTest = new RiskRatingMapper();
        }

        [Theory]
        [ClassData(typeof(RiskRatingMapperTestData))]
        public void MapModelToDtoTest(BaseEnumTestData<RiskRating, RiskRatingDto> baseEnumTestData) => base.AssertMapModelToDto(baseEnumTestData);

        [Theory]
        [ClassData(typeof(RiskRatingMapperTestData))]
        public void MapDtoToModelTest(BaseEnumTestData<RiskRating, RiskRatingDto> baseEnumTestData) => base.AssertMapDtoToModel(baseEnumTestData);
    }
}
