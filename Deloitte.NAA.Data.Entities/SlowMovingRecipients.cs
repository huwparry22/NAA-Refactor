using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class SlowMovingRecipients
    {
        public int SlowmovingRecipientId { get; set; }
        public int DelinquentConfigId { get; set; }
        public int ReviewerTypeId { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual DelinquentConfigurations DelinquentConfig { get; set; }
    }
}
