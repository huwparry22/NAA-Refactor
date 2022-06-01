using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class CoreDataOrganisationOperatingUnit
    {
        public int OperatingUnit { get; set; }
        public string OperatingUnitText { get; set; }
        public int ServiceLineId { get; set; }
        public string ServiceLineText { get; set; }
        public int SubServiceLineId { get; set; }
        public string SubServiceLineText { get; set; }
        public string LegalCompanyId { get; set; }
        public string LegalCompanyText { get; set; }
    }
}
