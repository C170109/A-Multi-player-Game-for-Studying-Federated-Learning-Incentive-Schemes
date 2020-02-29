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
    
    public partial class Federations
    {
        public Federations()
        {
            this.Bids = new HashSet<Bids>();
            this.FederationHistory = new HashSet<FederationHistory>();
            this.FederationParticipantsHistory = new HashSet<FederationParticipantsHistory>();
            this.InTrainings = new HashSet<InTrainings>();
        }
    
        public int Id { get; set; }
        public int Gid { get; set; }
        public int Fid { get; set; }
        public double FederationAsset { get; set; }
        public string SchemeAdopted { get; set; }
        public int AdmissionPolicyId { get; set; }
    
        public virtual ICollection<Bids> Bids { get; set; }
        public virtual ICollection<FederationHistory> FederationHistory { get; set; }
        public virtual ICollection<FederationParticipantsHistory> FederationParticipantsHistory { get; set; }
        public virtual GameInstance GameInstance { get; set; }
        public virtual ICollection<InTrainings> InTrainings { get; set; }
    }
}
