using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class DaemsConsultationIndividual
    {
        public int DaemsconsultationIndividualId { get; set; }
        public string DaemsconsultationId { get; set; }
        public int UserId { get; set; }
        public string Role { get; set; }

        public virtual DaemsConsultation Daemsconsultation { get; set; }
        public virtual User User { get; set; }
    }
}
