using Deloitte.NAA.Core.Interfaces;
using Deloitte.NAA.UnitTests.Common.TestData;
using FluentAssertions;
using System;
using Xunit;

namespace Deloitte.NAA.Core.UnitTests.Mappers
{
    public abstract class BaseMapperTest<TObjOne, TObjTwo>
        where TObjOne : class, new()
        where TObjTwo : class, new()
    {
        internal abstract IMapper<TObjOne, TObjTwo> _objectToTest { get; set; }

        internal void AssertMapModelToDto(BaseTestData<TObjOne, TObjTwo> baseTestData)
        {
            Func<TObjTwo> func = () => _objectToTest.MapTo(baseTestData.ObjOne);

            if (baseTestData.ExpectException)
            {
                Assert.Throws(baseTestData.ExceptionType, func);
            }
            else
            {
                func().Should().BeEquivalentTo(baseTestData.ObjTwo);
            }
        }

        internal void AssertMapDtoToModel(BaseTestData<TObjOne, TObjTwo> baseTestData)
        {
            Func<TObjOne> func = () => _objectToTest.MapTo(baseTestData.ObjTwo);

            if (baseTestData.ExpectException)
            {
                Assert.Throws(baseTestData.ExceptionType, func);
            }
            else
            {
                func().Should().BeEquivalentTo(baseTestData.ObjOne);
            }
        }
    }
}
