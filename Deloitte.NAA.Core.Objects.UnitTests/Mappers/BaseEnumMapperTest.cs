using Deloitte.NAA.Core.Objects.Interfaces;
using Deloitte.NAA.Core.Objects.UnitTests.Mappers.TestData;
using FluentAssertions;
using System;
using Xunit;

namespace Deloitte.NAA.Core.Objects.UnitTests.Mappers
{
    public abstract class BaseEnumMapperTest<TEnumOne, TEnumTwo>
        where TEnumOne : struct, IConvertible
        where TEnumTwo : struct, IConvertible
    {
        internal abstract IEnumMapper<TEnumOne, TEnumTwo> _objectToTest { get; set; }

        internal void AssertMapModelToDto(BaseEnumTestData<TEnumOne, TEnumTwo> baseEnumTestData)
        {
            Func<TEnumTwo> func = () => _objectToTest.MapTo(baseEnumTestData.EnumOne);

            if (baseEnumTestData.ExpectException)
            {
                try
                {
                    func();

                    Assert.True(false, $"Expected exception: {baseEnumTestData.ExceptionType.Name}");
                }
                catch (Exception ex)
                {
                    Assert.True(ex.GetType() == baseEnumTestData.ExceptionType);
                }
            }
            else
            {
                func().Should().BeEquivalentTo(baseEnumTestData.EnumTwo);
            }
        }

        internal void AssertMapDtoToModel(BaseEnumTestData<TEnumOne, TEnumTwo> baseTestData)
        {
            Func<TEnumOne> func = () => _objectToTest.MapTo(baseTestData.EnumTwo);

            if (baseTestData.ExpectException)
            {
                try
                {
                    func();

                    Assert.True(false, $"Expected exception: {baseTestData.ExceptionType.Name}");
                }
                catch (Exception ex)
                {
                    Assert.True(ex.GetType() == baseTestData.ExceptionType);
                }
            }
            else
            {
                func().Should().BeEquivalentTo(baseTestData.EnumOne);
            }
        }
    }
}
