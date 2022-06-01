using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ViewStatePreview
    {
        public int RoleId { get; set; }
        public int FolderId { get; set; }
        public int StateId { get; set; }
        public int Consultation { get; set; }
        public int Active { get; set; }
    }
}
