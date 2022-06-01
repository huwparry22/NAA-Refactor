using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class DelinquentConfigurations
    {
        public DelinquentConfigurations()
        {
            DelinquentRecipients = new HashSet<DelinquentRecipients>();
            SlowMovingRecipients = new HashSet<SlowMovingRecipients>();
        }

        public int DelinquentConfigId { get; set; }
        public int NaaconsultationId { get; set; }
        public int StateId { get; set; }
        public bool Enabled { get; set; }
        public int? SlowmovingDays { get; set; }
        public int? DelinquentDays { get; set; }
        public int? WithdrwanDays { get; set; }
        public byte[] RowVersion { get; set; }
        public int MemberfirmId { get; set; }

        public virtual MemberFirm Memberfirm { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<DelinquentRecipients> DelinquentRecipients { get; set; }
        public virtual ICollection<SlowMovingRecipients> SlowMovingRecipients { get; set; }
    }
}
