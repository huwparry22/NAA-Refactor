using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ArchiveDdextHistory
    {
        public int ArchiveDdextHistoryId { get; set; }
        public int ReviewBaseId { get; set; }
        public int UserId { get; set; }
        public int ExtendTo { get; set; }
        public DateTime ExtendOn { get; set; }
    }
}
