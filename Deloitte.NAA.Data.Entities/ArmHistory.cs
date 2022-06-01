using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ArmHistory
    {
        public int ArmhistoryId { get; set; }
        public int ReviewBaseId { get; set; }
        public string ArmentityId { get; set; }
        public DateTime? DateImportedFromArm { get; set; }
        public int? StateOfDocket { get; set; }
        public int? ImportedByPerson { get; set; }
        public byte[] ArmhistoryRowVersion { get; set; }
        public string EntityName { get; set; }
    }
}
