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
    [KnownType(typeof(ClubCloud_Lidmaatschap))]
    
    public partial class ClubCloud_LidmaatschapSoort
    {
        public ClubCloud_LidmaatschapSoort()
        {
            this.ClubCloud_Lidmaatschap = new HashSet<ClubCloud_Lidmaatschap>();
        }
    
    	[DataMember]
        public System.Guid Id { get; set; }
    	[DataMember]
        public string Naam { get; set; }
    	[DataMember]
        public string Beschrijving { get; set; }
    	[DataMember]
        public System.TimeSpan DagBegin { get; set; }
    	[DataMember]
        public System.TimeSpan DagEinde { get; set; }
    	[DataMember]
        public string Tarief { get; set; }
    
    	[DataMember]
        public virtual ICollection<ClubCloud_Lidmaatschap> ClubCloud_Lidmaatschap { get; set; }
    }
}