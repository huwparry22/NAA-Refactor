using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ViewReviewerMain
    {
        public int ReviewBaseId { get; set; }
        public int? Emid { get; set; }
        public string Em { get; set; }
        public int? Epid { get; set; }
        public string Ep { get; set; }
        public int? Eqid { get; set; }
        public string Eq { get; set; }
        public int? Gpid { get; set; }
        public string Gp { get; set; }
        public int? Mcid { get; set; }
        public string Mc { get; set; }
    }
}
