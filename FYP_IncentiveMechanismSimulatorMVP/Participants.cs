//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FYP_IncentiveMechanismSimulatorMVP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Participants
    {
        public Participants()
        {
            this.Bids = new HashSet<Bids>();
            this.FederationParticipantsHistory = new HashSet<FederationParticipantsHistory>();
            this.InTrainings = new HashSet<InTrainings>();
            this.ParticipantHistory = new HashSet<ParticipantHistory>();
        }
    
        public int Id { get; set; }
        public int Gid { get; set; }
        public int Pid { get; set; }
        public string Strategy { get; set; }
        public bool HumanPlayer { get; set; }
    
        public virtual ICollection<Bids> Bids { get; set; }
        public virtual ICollection<FederationParticipantsHistory> FederationParticipantsHistory { get; set; }
        public virtual GameInstance GameInstance { get; set; }
        public virtual ICollection<InTrainings> InTrainings { get; set; }
        public virtual ICollection<ParticipantHistory> ParticipantHistory { get; set; }
    }
}
