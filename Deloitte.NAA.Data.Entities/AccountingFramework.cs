using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class AccountingFramework
    {
        public int AccountingFrameworkId { get; set; }
        public string AccountingConsultationId { get; set; }
        public int FrameworkId { get; set; }
        public byte[] RowVersion { get; set; }
        public string Other { get; set; }

        public virtual AccountingConsultation AccountingConsultation { get; set; }
    }
}
