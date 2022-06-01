using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class Code
    {
        public Code()
        {
            CodeColumnConstraint = new HashSet<CodeColumnConstraint>();
            CodeData = new HashSet<CodeData>();
        }

        public int CodeId { get; set; }
        public string CodeName { get; set; }
        public string CodeStoredProcedure { get; set; }
        public string CodeDescription { get; set; }

        public virtual ICollection<CodeColumnConstraint> CodeColumnConstraint { get; set; }
        public virtual ICollection<CodeData> CodeData { get; set; }
    }
}
