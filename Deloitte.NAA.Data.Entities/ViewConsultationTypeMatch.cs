using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ViewConsultationTypeMatch
    {
        public int ConsultationTypeId { get; set; }
        public string Text { get; set; }
        public string Head { get; set; }
    }
}
