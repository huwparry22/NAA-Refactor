using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class PsrArmUpdateProcess
    {
        public DateTime? SsisjobLastRun { get; set; }
        public DateTime? WindowServiceSentLastRun { get; set; }
        public DateTime? WindowServiceProcessedLastRun { get; set; }
        public int SentFailureAttempts { get; set; }
        public Guid BatchGuid { get; set; }
        public int ProcessedFailureAttempts { get; set; }
    }
}
