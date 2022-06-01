﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class EarConsultationOffshoreEntity
    {
        public int EarconsultationOffshoreEntityId { get; set; }
        public string EarconsultationId { get; set; }
        public int EaroffshoreEntityId { get; set; }
        public byte[] RowVersion { get; set; }
        public string Other { get; set; }

        public virtual EarConsultation Earconsultation { get; set; }
    }
}
