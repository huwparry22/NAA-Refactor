using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class FicGridSummary
    {
        public int FicgridSummaryId { get; set; }
        public int FicgridId { get; set; }
        public string AccountingTreatment { get; set; }
        public string ValuationTool { get; set; }
        public string Purpose { get; set; }
        public int? Number { get; set; }
        public double? TotalFairValue { get; set; }
        public bool? IsExchangeTraded { get; set; }

        public virtual FicGrid Ficgrid { get; set; }
    }
}
