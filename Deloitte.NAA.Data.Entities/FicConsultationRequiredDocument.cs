using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class FicConsultationRequiredDocument
    {
        public int FicconsultationRequiredDocumentId { get; set; }
        public string FicconsultationId { get; set; }
        public int? TradeConfirmation { get; set; }
        public int? ClientValuations { get; set; }
        public int? ClientsForeignExchange { get; set; }
        public int? SummaryOfKeyTerms { get; set; }
        public int? HedgeDocumentation { get; set; }
        public int? EntityRetrospective { get; set; }
        public int? EntityProspective { get; set; }

        public virtual FicConsultation Ficconsultation { get; set; }
    }
}
