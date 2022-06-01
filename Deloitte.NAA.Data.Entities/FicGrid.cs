using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class FicGrid
    {
        public FicGrid()
        {
            FicgridHedge = new HashSet<FicGridHedge>();
            FicgridSummary = new HashSet<FicGridSummary>();
        }

        public int FicgridId { get; set; }
        public string FicconsultationId { get; set; }
        public int GridType { get; set; }
        public int? ConfigType { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual FicConsultation Ficconsultation { get; set; }
        public virtual ICollection<FicGridHedge> FicgridHedge { get; set; }
        public virtual ICollection<FicGridSummary> FicgridSummary { get; set; }
    }
}
