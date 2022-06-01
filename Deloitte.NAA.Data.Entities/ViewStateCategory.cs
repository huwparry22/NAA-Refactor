using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ViewStateCategory
    {
        public string Tag { get; set; }
        public int StateId { get; set; }
        public int Live { get; set; }
        public int Urgent { get; set; }
    }
}
