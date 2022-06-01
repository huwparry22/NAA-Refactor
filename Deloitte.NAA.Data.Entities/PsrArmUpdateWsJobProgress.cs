using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class PsrArmUpdateWsJobProgress
    {
        public int Id { get; set; }
        public Guid BatchGuid { get; set; }
        public DateTime? SentLastFailureAttempt { get; set; }
        public int? SentFailureAttemptCount { get; set; }
        public DateTime? BatchSuccessfullySentOn { get; set; }
        public DateTime? ProcessLastFailureAttempt { get; set; }
        public int? ProcessFailureAttemptCount { get; set; }
        public DateTime? BatchSuccessfullyProcessedOn { get; set; }
        public int? NoofUpdatesIncluded { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
