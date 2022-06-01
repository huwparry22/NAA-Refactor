using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class DelinquentRecipients
    {
        public int DelinquentRecipientId { get; set; }
        public int DelinquentConfigId { get; set; }
        public int ReviewerTypeId { get; set; }
        public byte[] RowVersion { get; set; }
        public bool IsSlowMoving { get; set; }

        public virtual DelinquentConfigurations DelinquentConfig { get; set; }
        public virtual ReviewerType ReviewerType { get; set; }
    }
}
