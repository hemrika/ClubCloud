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
    [KnownType(typeof(ClubCloud_Vereniging))]
    [KnownType(typeof(ClubCloud_Gebruiker))]
    
    public partial class ClubCloud_Address
    {
    	[DataMember]
        public System.Guid Id { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ParentId { get; set; }
    	[DataMember]
        public string Stad { get; set; }
    	[DataMember]
        public string Provincie { get; set; }
    	[DataMember]
        public Nullable<double> Latitude { get; set; }
    	[DataMember]
        public Nullable<double> Longitude { get; set; }
    	[DataMember]
        public string Naam { get; set; }
    	[DataMember]
        public string Postcode { get; set; }
    	[DataMember]
        public string Straat { get; set; }
    	[DataMember]
        public string Nummer { get; set; }
    	[DataMember]
        public string Actief { get; set; }
    	[DataMember]
        public string Land { get; set; }
    	[DataMember]
        public string Fax { get; set; }
    	[DataMember]
        public string Toevoeging { get; set; }
    	[DataMember]
        public string Postbus { get; set; }
    	[DataMember]
        public string TelefoonPrimair { get; set; }
    	[DataMember]
        public string TelefoonSecundair { get; set; }
    	[DataMember]
        public string TelefoonTertiair { get; set; }
    
    	[DataMember]
        public virtual ClubCloud_Vereniging ClubCloud_Vereniging { get; set; }
    	[DataMember]
        public virtual ClubCloud_Gebruiker ClubCloud_Gebruiker { get; set; }
    }
}