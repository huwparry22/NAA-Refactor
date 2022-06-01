using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class State
    {
        public State()
        {
            AccountingConsultation = new HashSet<AccountingConsultation>();
            Aqrmconsultation = new HashSet<AqrmConsultation>();
            AuditConsultation = new HashSet<AuditConsultation>();
            Cceconsultation = new HashSet<CceConsultation>();
            Cemoconsultation = new HashSet<CemoConsultation>();
            CgovConsultation = new HashSet<CgovConsultation>();
            Cstconsultation = new HashSet<CstConsultation>();
            Daemsconsultation = new HashSet<DaemsConsultation>();
            DelinquentConfigurations = new HashSet<DelinquentConfigurations>();
            Earconsultation = new HashSet<EarConsultation>();
            Ficconsultation = new HashSet<FicConsultation>();
            ReviewBase = new HashSet<ReviewBase>();
            ReviewState = new HashSet<ReviewState>();
            ReviewerTypeStatePriviledge = new HashSet<ReviewerTypeStatePriviledge>();
            SystemRoleStatePriviledge = new HashSet<SystemRoleStatePriviledge>();
        }

        public int StateId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AccountingConsultation> AccountingConsultation { get; set; }
        public virtual ICollection<AqrmConsultation> Aqrmconsultation { get; set; }
        public virtual ICollection<AuditConsultation> AuditConsultation { get; set; }
        public virtual ICollection<CceConsultation> Cceconsultation { get; set; }
        public virtual ICollection<CemoConsultation> Cemoconsultation { get; set; }
        public virtual ICollection<CgovConsultation> CgovConsultation { get; set; }
        public virtual ICollection<CstConsultation> Cstconsultation { get; set; }
        public virtual ICollection<DaemsConsultation> Daemsconsultation { get; set; }
        public virtual ICollection<DelinquentConfigurations> DelinquentConfigurations { get; set; }
        public virtual ICollection<EarConsultation> Earconsultation { get; set; }
        public virtual ICollection<FicConsultation> Ficconsultation { get; set; }
        public virtual ICollection<ReviewBase> ReviewBase { get; set; }
        public virtual ICollection<ReviewState> ReviewState { get; set; }
        public virtual ICollection<ReviewerTypeStatePriviledge> ReviewerTypeStatePriviledge { get; set; }
        public virtual ICollection<SystemRoleStatePriviledge> SystemRoleStatePriviledge { get; set; }
    }
}
