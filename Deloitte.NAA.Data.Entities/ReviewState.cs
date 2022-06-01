using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ReviewState
    {
        public int ReviewStateId { get; set; }
        public int ReviewBaseId { get; set; }
        public int StateId { get; set; }
        public DateTime StateChangeTime { get; set; }
        public int? StateChangeSetByUserId { get; set; }
        public int? OperationId { get; set; }
        public string AdditionalText { get; set; }
        public byte[] RowVersion { get; set; }
        public string ConsultationTypeId { get; set; }

        public virtual ReviewBase ReviewBase { get; set; }
        public virtual State State { get; set; }
        public virtual User StateChangeSetByUser { get; set; }
    }
}
