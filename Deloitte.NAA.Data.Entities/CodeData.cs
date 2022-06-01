using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class CodeData
    {
        public int CodeId { get; set; }
        public int CodeDataId { get; set; }
        public int Status { get; set; }
        public int SequenceId { get; set; }
        public string CodeData1 { get; set; }

        public virtual Code Code { get; set; }
    }
}
