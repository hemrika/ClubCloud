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
    [KnownType(typeof(ClubCloud_Gebruiker))]
    
    public partial class ClubCloud_Profiel
    {
    	[DataMember]
        public System.Guid Id { get; set; }
    	[DataMember]
        public string Bondsnummer { get; set; }
    	[DataMember]
        public Nullable<System.Guid> GebruikerId { get; set; }
    
    	[DataMember]
        public virtual ClubCloud_Gebruiker ClubCloud_Gebruiker { get; set; }
    }
}