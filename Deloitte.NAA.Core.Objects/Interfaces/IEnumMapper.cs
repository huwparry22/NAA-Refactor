using System;

namespace Deloitte.NAA.Core.Objects.Interfaces
{
    public interface IEnumMapper<TEnumOne, TEnumTwo>
        where TEnumOne : struct, IConvertible
        where TEnumTwo : struct, IConvertible
    {
        TEnumTwo MapTo(TEnumOne enumOne);

        TEnumOne MapTo(TEnumTwo enumTwo);
    }
}
