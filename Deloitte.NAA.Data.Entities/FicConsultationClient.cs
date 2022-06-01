using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class FicConsultationClient
    {
        public int FicconsultationClientId { get; set; }
        public string FicconsultationId { get; set; }
        public bool? UkCompaniesAct { get; set; }
        public string UkCompaniesActReason { get; set; }
        public int? Gaapid { get; set; }
        public int? ConsultationPeriodType { get; set; }
        public bool? FirstYearAudit { get; set; }
        public bool? LastYearAudit { get; set; }
        public string ClientsBusiness { get; set; }
        public int? ClientReportingCurrency { get; set; }
        public string ClientReportingCurrencyOther { get; set; }
        public int? ClientFunctionalCurrency { get; set; }
        public string ClientFunctionalCurrencyOther { get; set; }
        public bool? IsConsultationRequiredForConsolidated { get; set; }
        public bool? IsConsultationRequiredForSolo { get; set; }
        public bool? PcaobAudit { get; set; }

        public virtual FicConsultation Ficconsultation { get; set; }
    }
}
