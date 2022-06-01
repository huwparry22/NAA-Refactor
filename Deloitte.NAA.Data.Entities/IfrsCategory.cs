using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class IfrsCategory
    {
        public IfrsCategory()
        {
            IfrscatApplicableMemberFirms = new HashSet<IfrsCatApplicableMemberFirms>();
            IfrsstandardAndTopic = new HashSet<IfrsStandardAndTopic>();
            IfrssubCategory = new HashSet<IfrsSubCategory>();
        }

        public int IfrscategoryId { get; set; }
        public int CodeId { get; set; }
        public int CodeDataId { get; set; }
        public string Category { get; set; }
        public bool IsActive { get; set; }
        public int Sequence { get; set; }
        public bool AllMemberFirmsApplicable { get; set; }

        public virtual CorpReportingSubjectMatter CodeData { get; set; }
        public virtual ICollection<IfrsCatApplicableMemberFirms> IfrscatApplicableMemberFirms { get; set; }
        public virtual ICollection<IfrsStandardAndTopic> IfrsstandardAndTopic { get; set; }
        public virtual ICollection<IfrsSubCategory> IfrssubCategory { get; set; }
    }
}
