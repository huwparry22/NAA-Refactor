using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class PeriodEndCorrectedLog
    {
        public int Id { get; set; }
        public int? PsrlogNo { get; set; }
        public DateTime OldPeriodEnd { get; set; }
        public DateTime NewPeriodEnd { get; set; }
        public int? CorrectedBy { get; set; }
        public DateTime? CorrectedOn { get; set; }
    }
}
