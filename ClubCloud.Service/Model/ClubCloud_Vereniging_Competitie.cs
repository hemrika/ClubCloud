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
    
    [DataContract(IsReference = true)]
    
    public partial class ClubCloud_Vereniging_Competitie
    {
    	[DataMember]
        public System.Guid Id { get; set; }
    	[DataMember]
        public System.Guid VerenigingId { get; set; }
    	[DataMember]
        public int AantalPloegen { get; set; }
    	[DataMember]
        public string Naam { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> UserUpdate { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> ClubUpdate { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> ClubCloudUpdate { get; set; }
    }
}
