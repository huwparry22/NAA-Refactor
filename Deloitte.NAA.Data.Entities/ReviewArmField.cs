using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ReviewArmField
    {
        public int ReviewArmfieldId { get; set; }
        public int ReviewBaseId { get; set; }
        public int ArmfieldId { get; set; }

        public virtual ArmField Armfield { get; set; }
        public virtual ReviewBase ReviewBase { get; set; }
    }
}
