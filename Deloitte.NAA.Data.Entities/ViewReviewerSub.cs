using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ViewReviewerSub
    {
        public int ReviewBaseId { get; set; }
        public int ConsultationTypeId { get; set; }
        public int? Haid { get; set; }
        public string Ha { get; set; }
        public DateTime? Hai { get; set; }
        public int? Cmid { get; set; }
        public string Cm { get; set; }
        public DateTime? Cmi { get; set; }
        public int? Npid { get; set; }
        public string Np { get; set; }
        public DateTime? Npi { get; set; }
    }
}
