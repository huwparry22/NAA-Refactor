using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class FileReview
    {
        public FileReview()
        {
            SubsidiaryEntity = new HashSet<SubsidiaryEntity>();
        }

        public int ReviewBaseId { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public int? FileReviewLocation { get; set; }
        public bool? FileReviewRequired { get; set; }
        public byte[] FileReviewRowVersion { get; set; }
        public string NotRequiredReason { get; set; }

        public virtual ReviewBase ReviewBase { get; set; }
        public virtual ICollection<SubsidiaryEntity> SubsidiaryEntity { get; set; }
    }
}
