using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class CoreDataEmployee
    {
        public string ActiveDirectoryId { get; set; }
        public string SappersonnelNo { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitials { get; set; }
        public string EmployeeStatus { get; set; }
        public string LoginName { get; set; }
        public string DomainName { get; set; }
        public string SearchLastName { get; set; }
        public string SearchFirstName { get; set; }
        public string SearchLastNameSoundex { get; set; }
        public string SearchFirstNameSoundex { get; set; }
        public string Grade { get; set; }
        public int? OperatingUnit { get; set; }
        public string ServiceLineText { get; set; }
        public string OfficeCountryCode { get; set; }
        public string OfficeLocationCode { get; set; }
        public string OfficeCity { get; set; }
        public string ActiveDirectoryDisplayName { get; set; }
        public string LegalLocationCity { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PositionTitleText { get; set; }
    }
}
