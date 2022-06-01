using Deloitte.NAA.API.Models.Common;
using Deloitte.NAA.Core.Objects.DTO.Common;
using Deloitte.NAA.Core.Objects.Interfaces;
using Deloitte.NAA.Core.Objects.Mappers;
using Deloitte.NAA.Core.Objects.UnitTests.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Deloitte.NAA.Core.Objects.UnitTests.Mappers
{
    public class ClientMapperTests : BaseMapperTest<Client, ClientDto>
    {
        internal override IMapper<Client, ClientDto> _objectToTest { get; set; }

        public ClientMapperTests()
        {
            _objectToTest = new ClientMapper();
        }

        [Theory]
        [ClassData(typeof(ClientMapperTestData))]
        public void MapModelToDtoTest(BaseTestData<Client, ClientDto> baseTestData) => base.AssertMapModelToDto(baseTestData);

        [Theory]
        [ClassData(typeof(ClientMapperTestData))]
        public void MapDtoToModelTest(BaseTestData<Client, ClientDto> baseTestData) => base.AssertMapDtoToModel(baseTestData);
    }
}
