using Deloitte.NAA.API.Models.Common;
using Deloitte.NAA.Core.Interfaces;
using Deloitte.NAA.Core.Objects.DTO.Common;
using System;

namespace Deloitte.NAA.Core.Mappers
{
    public class DocketMapper : IMapper<Docket, DocketDto>
    {
        public DocketDto MapTo(Docket objOne)
        {
            if (objOne == null)
                throw new NullReferenceException($"{objOne.GetType()} objOne is null");

            return new DocketDto
            {
                ChargeCode = objOne.ChargeCode,
                OperatingUnit = objOne.OperatingUnit,
                PartnerOfficeId = objOne.PartnerOfficeId
            };
        }

        public Docket MapTo(DocketDto objTwo)
        {
            if (objTwo == null)
                throw new NullReferenceException($"{objTwo.GetType()} objTwo is null");

            return new Docket
            {
                ChargeCode = objTwo.ChargeCode,
                OperatingUnit = objTwo.OperatingUnit,
                PartnerOfficeId = objTwo.PartnerOfficeId,
                
            };
        }
    }
}
