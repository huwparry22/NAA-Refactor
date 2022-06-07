using Deloitte.NAA.API.Models.Common;
using Deloitte.NAA.API.Models.Common.Enums;
using Deloitte.NAA.Core.Objects.DTO.Common;
using Deloitte.NAA.Core.Objects.DTO.Enums;
using Deloitte.NAA.Core.Objects.Interfaces;
using Deloitte.NAA.Core.Objects.Mappers;
using Deloitte.NAA.Core.Objects.UnitTests.Mappers.TestData;
using Moq;
using System;
using Xunit;

namespace Deloitte.NAA.Core.Objects.UnitTests.Mappers
{
    public class ClientMapperTests : BaseMapperTest<Client, ClientDto>
    {
        internal override IMapper<Client, ClientDto> _objectToTest { get; set; }

        private readonly Mock<IEnumMapper<RiskRating, RiskRatingDto>> _mockRiskRatingMapper;

        public ClientMapperTests()
        {
            _mockRiskRatingMapper = new Mock<IEnumMapper<RiskRating,RiskRatingDto>>();

            _mockRiskRatingMapper
                .Setup(x => x.MapTo(It.IsAny<RiskRating>()))
                .Returns<RiskRating>(riskRating => 
                {
                    Enum.TryParse(riskRating.ToString(), out RiskRatingDto riskRatingDto);
                    return riskRatingDto;
                });

            _mockRiskRatingMapper
                .Setup(x => x.MapTo(It.IsAny<RiskRatingDto>()))
                .Returns<RiskRatingDto>(riskRatingDto =>
                {
                    Enum.TryParse(riskRatingDto.ToString(), out RiskRating riskRating);
                    return riskRating;
                });

            _objectToTest = new ClientMapper(_mockRiskRatingMapper.Object);
        }

        [Theory]
        [ClassData(typeof(ClientMapperTestData))]
        public void MapModelToDtoTest(BaseTestData<Client, ClientDto> baseTestData) => base.AssertMapModelToDto(baseTestData);

        [Theory]
        [ClassData(typeof(ClientMapperTestData))]
        public void MapDtoToModelTest(BaseTestData<Client, ClientDto> baseTestData) => base.AssertMapDtoToModel(baseTestData);
    }
}
