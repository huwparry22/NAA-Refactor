using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class IfrsStandardAndTopic
    {
        public int IfrsstandardAndTopicId { get; set; }
        public string AccountingConsultationId { get; set; }
        public int? IfrscategoryId { get; set; }
        public int? IfrssubCategoryId { get; set; }

        public virtual AccountingConsultation AccountingConsultation { get; set; }
        public virtual IfrsCategory Ifrscategory { get; set; }
        public virtual IfrsSubCategory IfrssubCategory { get; set; }
    }
}
