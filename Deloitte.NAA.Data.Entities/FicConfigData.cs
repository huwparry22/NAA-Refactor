using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class FicConfigData
    {
        public int FicconfigId { get; set; }
        public int FicconfigDataId { get; set; }
        public string Text { get; set; }
        public int SequenceId { get; set; }
        public bool Active { get; set; }
    }
}
