using Deloitte.NAA.API.Models.Common.Enums;
using Deloitte.NAA.Core.Interfaces;
using Deloitte.NAA.Core.Objects.DTO.Enums;
using System;

namespace Deloitte.NAA.Core.Mappers
{
    public class RiskRatingMapper : IEnumMapper<RiskRating, RiskRatingDto>
    {
        public RiskRatingDto MapTo(RiskRating enumOne) => enumOne switch
        {
            RiskRating.Mgtn => RiskRatingDto.Mgtn,
            RiskRating.Gtn => RiskRatingDto.Gtn,
            RiskRating.Normal => RiskRatingDto.Normal,
            _ => throw new ArgumentOutOfRangeException(nameof(enumOne), $"Not expected value: {enumOne}")
        };

        public RiskRating MapTo(RiskRatingDto enumTwo) => enumTwo switch
        {
            RiskRatingDto.Mgtn => RiskRating.Mgtn,
            RiskRatingDto.Gtn => RiskRating.Gtn,
            RiskRatingDto.Normal => RiskRating.Normal,
            _ => throw new ArgumentOutOfRangeException(nameof(enumTwo), $"Not expected value: {enumTwo}")
        };
    }
}
