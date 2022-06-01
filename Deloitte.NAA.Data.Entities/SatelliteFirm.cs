using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class SatelliteFirm
    {
        public int SatelliteFirmId { get; set; }
        public string FirmCode { get; set; }
        public string Adcode { get; set; }
        public string LocationName { get; set; }
        public bool Active { get; set; }

        public virtual MemberFirm FirmCodeNavigation { get; set; }
    }
}
