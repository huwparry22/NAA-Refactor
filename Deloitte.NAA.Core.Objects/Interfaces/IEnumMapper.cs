using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
