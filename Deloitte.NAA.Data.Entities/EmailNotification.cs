using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class EmailNotification
    {
        public EmailNotification()
        {
            Email = new HashSet<Email>();
        }

        public int EmailNotificationId { get; set; }
        public int ReviewBaseId { get; set; }
        public int CurrentStateId { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ConsultationTypeId { get; set; }

        public virtual ReviewBase ReviewBase { get; set; }
        public virtual ICollection<Email> Email { get; set; }
    }
}
