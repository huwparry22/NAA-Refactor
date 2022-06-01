using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class EmailTemplateType
    {
        public EmailTemplateType()
        {
            Email = new HashSet<Email>();
        }

        public int EmailTemplateTypeId { get; set; }
        public string Name { get; set; }
        public string OfflineEmailActionWords { get; set; }
        public string OperationName { get; set; }

        public virtual ICollection<Email> Email { get; set; }
    }
}
