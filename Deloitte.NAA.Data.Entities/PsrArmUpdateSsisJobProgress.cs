using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class PsrArmUpdateSsisJobProgress
    {
        public int Id { get; set; }
        public DateTime PsrarmupdatesTableUpdatedOn { get; set; }
        public int NoOfRecordsPushed { get; set; }
    }
}
