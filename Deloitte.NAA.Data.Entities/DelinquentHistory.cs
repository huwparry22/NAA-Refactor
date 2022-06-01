using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class DelinquentHistory
    {
        public int Id { get; set; }
        public int ReviewBaseId { get; set; }
        public string ConsultationId { get; set; }
        public int ChaserFlag { get; set; }
        public DateTime EmailSentDateTime { get; set; }
        public int CurrentState { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ReviewBase ReviewBase { get; set; }
    }
}
