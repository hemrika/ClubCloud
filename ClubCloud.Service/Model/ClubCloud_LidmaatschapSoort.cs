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
    
    public partial class ClubCloud_LidmaatschapSoort : BeheerBaseModel
    {
        public ClubCloud_LidmaatschapSoort()
        {
            this.ClubCloud_Lidmaatschap = new HashSet<ClubCloud_Lidmaatschap>();
        }
    
    	[DataMember]
        private System.Guid _id;
    	public System.Guid Id 
    	{ 
    		get { return _id; } 
    		set { SetProperty(ref _id, value); } 
    	}
    
    	[DataMember]
        private string _naam;
    	public string Naam 
    	{ 
    		get { return _naam; } 
    		set { SetProperty(ref _naam, value); } 
    	}
    
    	[DataMember]
        private string _beschrijving;
    	public string Beschrijving 
    	{ 
    		get { return _beschrijving; } 
    		set { SetProperty(ref _beschrijving, value); } 
    	}
    
    	[DataMember]
        private System.TimeSpan _dagBegin;
    	public System.TimeSpan DagBegin 
    	{ 
    		get { return _dagBegin; } 
    		set { SetProperty(ref _dagBegin, value); } 
    	}
    
    	[DataMember]
        private System.TimeSpan _dagEinde;
    	public System.TimeSpan DagEinde 
    	{ 
    		get { return _dagEinde; } 
    		set { SetProperty(ref _dagEinde, value); } 
    	}
    
    	[DataMember]
        private string _tarief;
    	public string Tarief 
    	{ 
    		get { return _tarief; } 
    		set { SetProperty(ref _tarief, value); } 
    	}
    
    
    	[DataMember]
        public virtual ICollection<ClubCloud_Lidmaatschap> ClubCloud_Lidmaatschap { get; set; }
    }
}
