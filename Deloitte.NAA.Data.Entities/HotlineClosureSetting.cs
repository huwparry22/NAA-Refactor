using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class HotlineClosureSetting
    {
        public int HotlineClosureSettingId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string MessageText { get; set; }
        public int MemberFirmId { get; set; }
        public string HeaderText { get; set; }
        public string ReferenceLink { get; set; }

        public virtual MemberFirm MemberFirm { get; set; }
    }
}
