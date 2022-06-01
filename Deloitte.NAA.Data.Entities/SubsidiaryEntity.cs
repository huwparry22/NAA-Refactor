using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class SubsidiaryEntity
    {
        public int SubsidiaryEntityId { get; set; }
        public int ReviewBaseId { get; set; }
        public string ArmEntityId { get; set; }
        public string EntityName { get; set; }
        public string Uhcdunsnumber { get; set; }
        public int? EngagementPartnerId { get; set; }
        public int? EngagementManagerId { get; set; }
        public byte[] RowTimestamp { get; set; }

        public virtual User EngagementManager { get; set; }
        public virtual User EngagementPartner { get; set; }
        public virtual FileReview ReviewBase { get; set; }
    }
}
