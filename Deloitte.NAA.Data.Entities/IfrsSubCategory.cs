using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class IfrsSubCategory
    {
        public IfrsSubCategory()
        {
            IfrsstandardAndTopic = new HashSet<IfrsStandardAndTopic>();
            IfrssubCatApplicableMemberFirms = new HashSet<IfrsSubCatApplicableMemberFirms>();
        }

        public int IfrssubCategoryId { get; set; }
        public int IfrscategoryId { get; set; }
        public string SubCategory { get; set; }
        public bool IsActive { get; set; }
        public int Sequence { get; set; }
        public bool AllMemberFirmsApplicable { get; set; }

        public virtual IfrsCategory Ifrscategory { get; set; }
        public virtual ICollection<IfrsStandardAndTopic> IfrsstandardAndTopic { get; set; }
        public virtual ICollection<IfrsSubCatApplicableMemberFirms> IfrssubCatApplicableMemberFirms { get; set; }
    }
}
