//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClubCloud.Service.Model
{
    using System;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    
    [Serializable]
    [DataContract(IsReference = true)]
    [KnownType(typeof(ClubCloud_Functie))]
    [KnownType(typeof(ClubCloud_Vereniging))]
    [KnownType(typeof(ClubCloud_Gebruiker))]
    [KnownType(typeof(ClubCloud_District))]
    [KnownType(typeof(ClubCloud_Bestuursorgaan))]
    
    public partial class ClubCloud_Functionaris
    {
    	[DataMember]
        public System.Guid Id { get; set; }
    	[DataMember]
        public Nullable<System.Guid> FunctieId { get; set; }
    	[DataMember]
        public Nullable<System.Guid> VerenigingId { get; set; }
    	[DataMember]
        public Nullable<System.Guid> GebruikerId { get; set; }
    	[DataMember]
        public Nullable<System.Guid> BestuursorgaanId { get; set; }
    	[DataMember]
        public Nullable<System.Guid> DistrictId { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> TermijnBegin { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> TermijnEinde { get; set; }
    	[DataMember]
        public bool Autorisatie { get; set; }
    	[DataMember]
        public string Actief { get; set; }
    
    	[DataMember]
        public virtual ClubCloud_Functie ClubCloud_Functie { get; set; }
    	[DataMember]
        public virtual ClubCloud_Vereniging ClubCloud_Vereniging { get; set; }
    	[DataMember]
        public virtual ClubCloud_Gebruiker ClubCloud_Gebruiker { get; set; }
    	[DataMember]
        public virtual ClubCloud_District ClubCloud_District { get; set; }
    	[DataMember]
        public virtual ClubCloud_Bestuursorgaan ClubCloud_Bestuursorgaan { get; set; }
    }
}